/****** Object:  Table [dbo].[Course]    Script Date: 3/1/2022 3:14:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address1] [varchar](100) NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](2) NULL,
	[PostalCode] [varchar](50) NULL,
	[Country] [varchar](100) NULL,
	[IsActive] [bit] NOT NULL,
	[WhenCreated] DATETIME NOT NULL DEFAULT GETDATE(),
	[WhenModified] DATETIME NOT NULL DEFAULT GETDATE()
PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Course] ADD  DEFAULT ((1)) FOR [IsActive]
GO


