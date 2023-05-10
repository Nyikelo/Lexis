CREATE DATABASE Lexis
GO 
CREATE  TABLE TitleDeed
(
	TitleDeedId int identity(1,1) not null ,
	OwnerID int,
	Notes NVARCHAR(800),
	DateLodged Date,
	DateProcessed Date,
	TMStamp Datetime 
)
CREATE  TABLE PropertyOwner
(
	OwnerID int identity(1,1) not null ,
	IDNumber NVARCHAR(20),
	FirstName NVARCHAR(40),
	Surname NVARCHAR(40),
	CellNumber NVARCHAR(30)
)
Go
CREATE  TABLE PropertyAddress
(
	AddressID int identity(1,1) not null ,	
	OwnerID int,
	ERFNumber NVARCHAR(20),
	StreetNo NVARCHAR(10),
	StreetName NVARCHAR(250),
	ComplexName NVARCHAR(100),
	SurburbName NVARCHAR(100),
	City NVARCHAR(100),
	Province NVARCHAR(100),
	PostalCode NVARCHAR(5)
)
GO

INSERT INTO [Lexis].[dbo].[TitleDeed]
           ([OwnerID]
           ,[Notes]
           ,[DateLodged]
           ,[DateProcessed]
           ,[TMStamp])
     VALUES
           (1
           ,'property Lodged'
           ,'2020-05-02'
           ,'2021-01-06'
           ,GETDATE())
GO



INSERT INTO [Lexis].[dbo].[PropertyOwner]
           ([IDNumber]
           ,[FirstName]
           ,[Surname]
           ,[CellNumber])
     VALUES
           ('9002055422084'
           ,'David'
           ,'Smith'
           ,'0721231231')
GO


INSERT INTO [Lexis].[dbo].[PropertyAddress]
           ([OwnerID]
           ,[ERFNumber]
           ,[StreetNo]
           ,[StreetName]
           ,[ComplexName]
           ,[SurburbName]
           ,[City]
           ,[Province]
           ,[PostalCode])
     VALUES
           (1
           ,'ERF90'
           ,'123'
           ,'Botha Street'
           ,'Alpine'
           ,'Centurion'
           ,'Pretoria'
           ,'GP'
           ,'0002')
GO


