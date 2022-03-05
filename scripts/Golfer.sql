SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE IF EXISTS [dbo].[Golfer]
GO

CREATE TABLE [dbo].[Golfer](
	[GolferID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[BirthDate] [datetime] NULL,
	[Nickname] [varchar](100) NULL,
	[MobilePhone] [varchar](20) NULL,
	[HomeCourseID] [int] NULL,
	[AddressID] [int] NULL,
	[IsActive] [bit] NOT NULL DEFAULT 1,
	[WhoCreatedID] [int] NULL,
	[WhenCreated] DATETIME NULL DEFAULT GETDATE(),
	[WhoModifiedID] [int] NULL,
	[WhenModified] DATETIME NULL DEFAULT GETDATE()
	PRIMARY KEY CLUSTERED 
	(
		[GolferID] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
GO

INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate, AddressID) VALUES ('Tony', 'Jacobson', 'jacobson4489@gmail.com', '1982-06-26', 1)
INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate) VALUES ('Mark', 'Jacobson', '', '1982-06-26')
INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate, Nickname) VALUES ('Eric', 'Leonardson', '', '1979-08-26', 'Big Dog')
INSERT INTO Golfer (FirstName, LastName, EmailAddress) VALUES ('Brad', 'Mikulice', '')

SELECT *
FROM Golfer