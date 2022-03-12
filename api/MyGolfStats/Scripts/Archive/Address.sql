SET ANSI_NULLS ON
GO

SET QUOTED_IdENTIFIER ON
GO

ALTER TABLE [dbo].[Golfer] DROP CONSTRAINT IF EXISTS fk_Golfer_AddressId__Address_AddressId
GO

ALTER TABLE [dbo].[Course] DROP CONSTRAINT IF EXISTS fk_Course_AddressId__Address_AddressId
GO

DROP TABLE IF EXISTS [dbo].[Address]
GO

/*
CREATE TABLE [dbo].[Address](
	[AddressId] [int] IdENTITY(1,1) NOT NULL,
	[Address1] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](100) NOT NULL,
	[State] [varchar](2) NOT NULL,
	[PostalCode] [varchar](50) NOT NULL,
	[Country] [varchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL DEFAULT 1,
	PRIMARY KEY CLUSTERED 
	(
		[AddressId] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Golfer] ADD CONSTRAINT fk_Golfer_AddressId__Address_AddressId 
	FOREIGN KEY (AddressId) 
	REFERENCES Address (AddressId) 
GO

ALTER TABLE [dbo].[Course] ADD CONSTRAINT fk_Course_AddressId__Address_AddressId 
	FOREIGN KEY (AddressId) 
	REFERENCES Address (AddressId) 
GO

INSERT INTO Address (Address1, City, State, PostalCode, Country) VALUES ('8652 S Roxbury Way', 'Oak Creek', 'WI', '53154', 'United States')
UPDATE Golfer SET AddressId = 1 WHERE GolferId = 1

SELECT *
FROM Address
*/