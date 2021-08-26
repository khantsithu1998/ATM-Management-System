CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [account_no] NVARCHAR(50) NULL, 
    [full_name] NVARCHAR(50) NULL, 
    [mobile_no] NVARCHAR(50) NULL, 
    [address] NVARCHAR(100) NULL, 
    [pin] NVARCHAR(6) NULL, 
    [education] NVARCHAR(50) NULL, 
    [occupation] NVARCHAR(50) NULL, 
    [dob] NVARCHAR(50) NULL, 
    [amount] INT NULL
)
