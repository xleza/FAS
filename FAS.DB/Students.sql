CREATE TABLE [dbo].[Students]
(
	[Id] VARCHAR(250) NOT NULL PRIMARY KEY,
	[FullName] NVARCHAR(250) NOT NULL,
	[BirthDate] DateTime NOT NULL,
	[FingerprintChecksum] VARBINARY(MAX) NOT NULL,
	[Image] VARBINARY(MAX) NOT NULL
)
