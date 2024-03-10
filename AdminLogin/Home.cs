using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace AdminLogin
{
    public partial class Home : Form
    {
        private Modify modify;

        public Home()
        {
            InitializeComponent();
            modify = new Modify();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter2.Fill(this.database1DataSet2.Manager);
            //     this.WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'database1DataSet1.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter1.Fill(this.database1DataSet1.Manager);
            // TODO: This line of code loads data into the 'database1DataSet.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.database1DataSet.Manager);
            label_Total.Text = $"{dataGridView1.RowCount - 1}";
        }

        // Phương thức để thực hiện truy vấn và lấy dữ liệu vào DataTable
        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private void button_Sapxep_Click(object sender, EventArgs e)
        {
            // Lấy lựa chọn từ ComboBox
            string luaChon = comboBox_luachon.SelectedItem.ToString();

            // Kiểm tra lựa chọn và tạo câu truy vấn sắp xếp tương ứng
            string query = "";
            switch (luaChon)
            {
                case "Thời Gian Chơi":
                    query = "SELECT * FROM Manager ORDER BY timeplay DESC";
                    break;
                case "Số Lần Đăng Nhập":
                    query = "SELECT * FROM Manager ORDER BY soLanDangNhap DESC";
                    break;
                case "Lượng Boss Tiêu Diệt":
                    query = "SELECT * FROM Manager ORDER BY luongBossTieuDiet DESC";
                    break;
                case "Level":
                    query = "SELECT * FROM Manager ORDER BY level DESC";
                    break;
                case "Điểm Cao Nhất":
                    query = "SELECT * FROM Manager ORDER BY diemCaoNhat DESC";
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn một mục để sắp xếp");
                    return;
            }

            // Thực hiện truy vấn và lấy dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt = GetData(query);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dt;

            // Hiển thị thông báo hoặc cập nhật giao diện nếu cần
            MessageBox.Show("Đã sắp xếp và hiển thị dữ liệu trên DataGridView theo " + luaChon);
        }

        private void button_PDF_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu trong DataGridView không
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            // Tạo hộp thoại lưu tệp
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.Title = "Chọn nơi lưu trữ tệp Excel";

            // Mở hộp thoại và kiểm tra xem người dùng đã chọn địa chỉ lưu trữ hay chưa
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Tạo đối tượng Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false; // Không hiển thị ứng dụng Excel

                // Tạo một workbook mới
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                // Tạo một worksheet mới
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                // Đổ dữ liệu từ DataGridView vào worksheet
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu workbook vào địa chỉ đã chọn
                string filePath = saveFileDialog1.FileName;
                workbook.SaveAs(filePath);

                // Đóng workbook và ứng dụng Excel
                workbook.Close();
                excelApp.Quit();

                // Giải phóng tài nguyên COM
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Dữ liệu đã được xuất thành công vào: " + filePath);
            }
        }


        private void button_excel_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu trong DataGridView không
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            // Tạo một tài liệu PDF mới
            Document document = new Document();

            try
            {
                // Tạo hộp thoại lưu tệp
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog1.Title = "Chọn nơi lưu trữ tệp PDF";

                // Hiển thị hộp thoại lưu tệp và kiểm tra xem người dùng đã chọn địa chỉ lưu trữ hay chưa
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Khởi tạo một đối tượng PdfWriter để viết vào tệp PDF
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog1.FileName, FileMode.Create));

                    // Mở tài liệu
                    document.Open();

                    // Tạo một font Unicode hỗ trợ tiếng Việt
                    Font font = FontFactory.GetFont("Arial Unicode MS", BaseFont.IDENTITY_H, BaseFont.EMBEDDED, 12);

                    // Tạo một bảng PDF
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

                    // Thêm tiêu đề cột vào bảng PDF
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        pdfTable.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, font));
                    }

                    // Thêm dữ liệu từ DataGridView vào bảng PDF
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            // Kiểm tra xem giá trị của ô có null không
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                pdfTable.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), font));
                            }
                            else
                            {
                                // Nếu giá trị là null, thêm một cell trống vào bảng PDF
                                pdfTable.AddCell("");
                            }
                        }
                    }

                    // Thêm bảng PDF vào tài liệu
                    document.Add(pdfTable);

                    // Thông báo xuất PDF thành công
                    MessageBox.Show("Dữ liệu đã được xuất thành công vào: " + saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo nếu có lỗi
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                // Đóng tài liệu
                document.Close();
            }
        }


        private void button_Exit_Click(object sender, EventArgs e)
        {
            // Thoát khỏi ứng dụng
            Application.Exit();
        }
    }
}
