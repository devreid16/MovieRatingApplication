CREATE TABLE [dbo].[Table]
(
	[orderId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[customerId] VARCHAR(50) NOT NULL,
	[orderDate] DATE NOT NULL, 
    [orderQty] VARCHAR(50) NOT NULL,
	[orderTax] INT NOT NULL, 
    [orderTotal] INT NOT NULL,
    [orderShipProvider] VARCHAR(50) NOT NULL, 
    [orderStatus] VARCHAR(50) NULL    
    
)
