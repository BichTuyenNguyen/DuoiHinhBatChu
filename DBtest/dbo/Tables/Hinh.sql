CREATE TABLE [dbo].[Hinh] (
    [id]     INT           NOT NULL,
    [hinh]   IMAGE         NULL,
    [dapan]  NVARCHAR (50) NULL,
    [cauhoi] NVARCHAR (50) NULL,
    CONSTRAINT [PK_hinh] PRIMARY KEY CLUSTERED ([id] ASC)
);

