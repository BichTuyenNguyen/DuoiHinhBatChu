CREATE TABLE [dbo].[BangXepHang] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (50) NULL,
    [diem] INT           NULL,
    CONSTRAINT [PK_ketqua] PRIMARY KEY CLUSTERED ([id] ASC)
);

