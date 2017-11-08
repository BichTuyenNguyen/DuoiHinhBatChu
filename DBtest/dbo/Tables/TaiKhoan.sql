CREATE TABLE [dbo].[TaiKhoan] (
    [UserName] NVARCHAR (50) NOT NULL,
    [Password] NCHAR (20)    NULL,
    [NickName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([UserName] ASC)
);

