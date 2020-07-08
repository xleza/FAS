CREATE VIEW [dbo].[SeminarsView]
	AS
	SELECT 
	s.[Id],
    s.[Name],
    s.[LecturerId],
    l.FullName as LecturerName
  FROM [dbo].[Seminars]  s
  INNER JOIN [dbo].[Lecturers] l
  ON s.LecturerId = l.Id