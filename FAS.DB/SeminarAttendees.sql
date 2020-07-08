﻿CREATE TABLE [dbo].[SeminarAttendees]
(
	[Id] VARCHAR(250) NOT NULL PRIMARY KEY,
	[SeminarId] VARCHAR(250) NOT NULL,
	[RegistrationTime] DATETIME NOT NULL,
	FOREIGN KEY (SeminarId) REFERENCES Seminars(Id)
)