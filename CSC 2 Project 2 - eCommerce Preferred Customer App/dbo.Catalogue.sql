CREATE TABLE [dbo].[Catalogue] (
    [Id]            INT          NOT NULL,
    [ProductNumber] INT          NULL,
    [ProductName]   NVARCHAR(50)   NULL,
    [ProductPrice]  DECIMAL (18) NULL,
    [Quanity ]      INT          NULL,
    CONSTRAINT [PK_Catalogue] PRIMARY KEY CLUSTERED ([Id] ASC)
);

