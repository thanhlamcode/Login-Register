CREATE TABLE [dbo].[TaiKhoan] (
    [TenTaiKhoan] VARCHAR (50) NOT NULL,
    [MauKhau]     VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [isAdmin] BIT DEFAULT 0
);

