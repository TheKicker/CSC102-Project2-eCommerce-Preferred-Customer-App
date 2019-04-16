CREATE TABLE [dbo].[Catalogue]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ProductNumber] INT NOT NULL PRIMARY KEY, 
    [ProductName] NCHAR(10) NOT NULL, 
    [ProductPrice] DECIMAL NOT NULL, 
    [Quanity ] INT NOT NULL
)
