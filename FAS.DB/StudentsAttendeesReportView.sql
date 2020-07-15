CREATE VIEW [dbo].[StudentsAttendeesReportView]
	AS SELECT 
       st.[Id]
      ,st.[FullName]
	  ,COUNT(s.Id) AS AttendeesCount
	  ,s.Id AS SeminarId
	  ,s.Name AS SeminarName
  FROM [dbo].[Students] st
  INNER JOIN SeminarSessionAttendees ssa ON st.Id = ssa.Id
  INNER JOIN SeminarSessions ss ON ssa.SessionId = ss.Id
  INNER JOIN Seminars s ON  ss.SeminarId = s.Id
  WHERE ss.Status = 'Finished'
  Group By st.Id, st.FullName, s.Id, s.Name
