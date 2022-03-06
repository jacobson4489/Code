SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[Golfer] DROP CONSTRAINT IF EXISTS fk_Golfer_HomeCourseID__Course_CourseID
GO

DROP TABLE IF EXISTS [dbo].[Course]
GO

CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[AddressID] [int] NULL,
	[IsActive] [bit] NOT NULL DEFAULT 1,
	PRIMARY KEY CLUSTERED 
	(
		[CourseID] ASC
	) WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Golfer] ADD CONSTRAINT fk_Golfer_HomeCourseID__Course_CourseID 
	FOREIGN KEY (HomeCourseID) 
	REFERENCES Course (CourseID)
GO

INSERT INTO Course (Name) VALUES ('Washington County Golf Course')
INSERT INTO Course (Name) VALUES ('Hartford Golf Club')
INSERT INTO Course (Name) VALUES ('Oakwood Park')
INSERT INTO Course (Name) VALUES ('Whitnall Park')
INSERT INTO Course (Name) VALUES ('Brown Deer Park')
INSERT INTO Course (Name) VALUES ('Dretzka Park')

SELECT *
FROM Course