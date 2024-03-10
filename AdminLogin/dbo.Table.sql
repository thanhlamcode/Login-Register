CREATE TABLE [dbo].[TaiKhoan]
(
	[TenTaiKhoan] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [MauKhau] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [isAdmin] BIT DEFAULT 0 -- Đặt giá trị mặc định là 0 (không phải admin)
)
