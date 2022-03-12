SET ANSI_NULLS ON
GO

SET QUOTED_IdENTIFIER ON
GO

ALTER TABLE [dbo].[Golfer] DROP CONSTRAINT IF EXISTS fk_Golfer_HomeCourseId__Course_CourseId
GO

DROP TABLE IF EXISTS [dbo].[Course]
GO

CREATE TABLE [dbo].[Course](
	[CourseId] [int] IdENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[EmailAddress] [varchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Address1] [varchar](100) NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](2) NULL,
	[PostalCode] [varchar](50) NULL,
	[IsActive] [bit] NOT NULL DEFAULT 1,
	PRIMARY KEY CLUSTERED 
	(
		[CourseId] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Golfer] ADD CONSTRAINT fk_Golfer_HomeCourseId__Course_CourseId 
	FOREIGN KEY (HomeCourseId) 
	REFERENCES Course (CourseId)
GO

INSERT INTO Course (Name) VALUES ('Washington County Golf Course')
INSERT INTO Course (Name) VALUES ('Hartford Golf Club')
INSERT INTO Course (Name) VALUES ('Oakwood Park')
INSERT INTO Course (Name) VALUES ('Whitnall Park')
INSERT INTO Course (Name) VALUES ('Brown Deer Park')
INSERT INTO Course (Name) VALUES ('Dretzka Park')

SELECT *
FROM Course