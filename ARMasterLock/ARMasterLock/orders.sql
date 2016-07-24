CREATE TABLE [dbo].[Table]
(
	[orderId] INT NOT NULL PRIMARY KEY IDENTITY,
	[orderDate] date NOT NULL,
	[customerId] VARCHAR (50) NOT NULL, 
    [orderQty] VARCHAR(50) NOT NULL, 
    [orderTax] VARCHAR(50) NOT NULL, 
    [orderTotal] VARCHAR(50) NOT NULL, 
    [orderShipProvider] VARCHAR(50) NULL, 
    [orderStatus] VARCHAR(50) NULL
)
