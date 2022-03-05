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

INSERT INTO Golfer (FirstName, LastName, EmailAddress, AddressID) VALUES ('Tony', 'Jacobson', 'jacobson4489@gmail.com', 1)
INSERT INTO Golfer (FirstName, LastName, EmailAddress) VALUES ('Mark', 'Jacobson', '')
INSERT INTO Golfer (FirstName, LastName, EmailAddress, Nickname) VALUES ('Eric', 'Leonardson', '', 'Big Dog')
INSERT INTO Golfer (FirstName, LastName, EmailAddress) VALUES ('Brad', 'Mikulice', '')

SELECT *
FROM Golfer