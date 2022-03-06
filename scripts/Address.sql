SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[Golfer] DROP CONSTRAINT IF EXISTS fk_Golfer_AddressID__Address_AddressID
GO

ALTER TABLE [dbo].[Course] DROP CONSTRAINT IF EXISTS fk_Course_AddressID__Address_AddressID
GO

DROP TABLE IF EXISTS [dbo].[Address]
GO

CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address1] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](100) NOT NULL,
	[State] [varchar](2) NOT NULL,
	[PostalCode] [varchar](50) NOT NULL,
	[Country] [varchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT 1,
	PRIMARY KEY CLUSTERED 
	(
		[AddressID] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Golfer] ADD CONSTRAINT fk_Golfer_AddressID__Address_AddressID 
	FOREIGN KEY (AddressID) 
	REFERENCES Address (AddressID) 
GO

ALTER TABLE [dbo].[Course] ADD CONSTRAINT fk_Course_AddressID__Address_AddressID 
	FOREIGN KEY (AddressID) 
	REFERENCES Address (AddressID) 
GO

INSERT INTO Address (Address1, City, State, PostalCode, Country) VALUES ('8652 S Roxbury Way', 'Oak Creek', 'WI', '53154', 'United States')
UPDATE Golfer SET AddressID = 1 WHERE GolferID = 1

SELECT *
FROM Address