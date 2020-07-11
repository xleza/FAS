CREATE VIEW [dbo].[SeminarSessionsView]
	AS 
SELECT 
     ss.[Id],
     ss.[SeminarId],
	 s.[Name],
	 l.[Id] as LecturerId,
	 l.[FullName] as LecturerFullName,
	 l.FingerprintChecksum as LecturerFingerprint,
     ss.[Status],
     ss.[StartTime],
     ss.[EndTime]
  FROM [dbo].[SeminarSessions] ss
  INNER JOIN  [dbo].[Seminars] s 
  ON ss.SeminarId = s.Id
  INNER JOIN [dbo].Lecturers l
  ON l.Id = s.LecturerId
