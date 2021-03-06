﻿CREATE VIEW [dbo].[SeminarAttendeesView]
	AS 
	SELECT 
	st.Id,
	st.FullName,
	st.FingerprintChecksum,
	sa.SeminarId,
	sa.RegistrationTime
  FROM [dbo].[SeminarAttendees] sa
  INNER JOIN [dbo].Students st
  ON sa.Id = st.Id
