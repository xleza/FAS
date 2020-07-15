CREATE VIEW [dbo].[SeminarSessionAttendeesView]
	AS 
	SELECT 
	st.Id,
	st.FullName,
	sa.SessionId,
	sa.AttendeeStartTime
  FROM [dbo].[SeminarSessionAttendees] sa
  INNER JOIN [dbo].Students st
  ON sa.Id = st.Id
