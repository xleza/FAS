CREATE TABLE [dbo].[SeminarSessionAttendees]
(
	[Id]  VARCHAR(250) NOT NULL PRIMARY KEY,
	[SessionId]  VARCHAR(250) NOT NULL,
	[AttendeeStartTime] DateTime  NOT NULL,
	FOREIGN KEY (Id) REFERENCES Students(Id),
	FOREIGN KEY (SessionId) REFERENCES SeminarSessions(Id)
)
