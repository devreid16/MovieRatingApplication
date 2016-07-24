CREATE TABLE [dbo].[Table]
(
	[productId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [productName] VARCHAR(50) NOT NULL, 
    [productType] VARCHAR(50) NOT NULL, 
    [productMdlNum] VARCHAR(50) NOT NULL,
	[productlkopt] VARCHAR (50) NULL,
	[productPrice] INT NOT NULL, 
    [productDetail] VARCHAR(MAX) NULL, 
    [productSize] VARCHAR(50) NULL, 
    [productWeight] VARCHAR(50) NULL, 
    [imageName] TEXT NOT NULL
)
