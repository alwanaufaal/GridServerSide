USE [Tutorial]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 21/05/2021 10:29:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[StudentGPA] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (9, N'Ridho Kurniawan', 3)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (10, N'Marzota Dwi', 1)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (11, N'Muhammad Alwan Naufal', 4)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (12, N'Dzaky Kurniawan', 2)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (13, N'Lisa Blekpink', 4)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (14, N'Dimas Angga', 3)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (15, N'Jack', 4)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (16, N'Soekarno Jia', 1)
INSERT [dbo].[Student] ([StudentID], [StudentName], [StudentGPA]) VALUES (17, N'Jennie', 3)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetStudentCount]    Script Date: 21/05/2021 10:29:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetStudentCount]
AS
BEGIN
	SELECT COUNT(StudentID) FROM Student
END
GO
/****** Object:  StoredProcedure [dbo].[StudentPaging]    Script Date: 21/05/2021 10:29:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[StudentPaging]
	@PageNumber INT,
	@PageSize INT
AS
BEGIN
	DECLARE @sqlCommand NVARCHAR(MAX)
	SET @sqlCommand =
		'SELECT * FROM Student ORDER BY StudentID' + ' OFFSET ' + CONVERT(VARCHAR(10), @PageSize) + '*' + '(' + CONVERT(VARCHAR(10), @PageNumber) + '-' + '1) ROWS FETCH NEXT ' +
		CONVERT(VARCHAR(10), @PageSize) + ' ROWS ONLY OPTION (RECOMPILE);';	

	EXEC (@sqlCommand)
END
GO
