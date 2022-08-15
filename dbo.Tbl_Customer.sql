CREATE TABLE [dbo].[Tbl_Customer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [cusName] VARCHAR(50) NOT NULL, 
    [cusNIC] CHAR(10) NOT NULL, 
    [cusAddress] VARCHAR(MAX) NOT NULL, 
    [cusContact] VARCHAR(50) NOT NULL, 
    [cusStatus] VARCHAR(50) NOT NULL
)