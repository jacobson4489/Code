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
	PRIMARY KEY CLUSTERED 
	(
		[GolferID] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]
GO

INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate) VALUES ('Tony', 'Jacobson', 'jacobson4489@gmail.com', '1982-06-26')
INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate) VALUES ('Mark', 'Jacobson', 'none@mail.com', '1982-06-26')
INSERT INTO Golfer (FirstName, LastName, EmailAddress, BirthDate, Nickname) VALUES ('Eric', 'Leonardson', 'none@mail.com', '1979-08-26', 'Big Dog')
INSERT INTO Golfer (FirstName, LastName, EmailAddress) VALUES ('Brad', 'Mikulice', 'none@mail.com')

SELECT *
FROM Golfer