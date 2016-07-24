CREATE TABLE [dbo].[Table]
(
	[customerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userName] VARCHAR(50) NOT NULL, 
    [firstName] VARCHAR(50) NOT NULL, 
    [lastName] VARCHAR(50) NOT NULL, 
    [shipToName] VARCHAR(50) NULL, 
    [shipToAddress] VARCHAR(50) NOT NULL, 
    [shipToCity] VARCHAR(50) NOT NULL, 
    [shipToState] VARCHAR(50) NOT NULL, 
    [shipToZip] VARCHAR(50) NOT NULL, 
    [shipProvider] VARCHAR(50) NOT NULL, 
    [trackNum] VARCHAR(50) NULL, 
    [orderNum] VARCHAR(50) NULL
)
