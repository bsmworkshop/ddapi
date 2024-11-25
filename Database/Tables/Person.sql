CREATE TABLE [dbo].[Person]
(
	[Id]															INT							NOT NULL	IDENTITY(90000,1),
	[FamilyName]													NVARCHAR(70)				NOT NULL,
	[GivenName]														NVARCHAR(70)				NOT NULL,
	[OtherNames]													NVARCHAR(100)				NULL,
	[IsArchived]													BIT							NOT NULL	DEFAULT(0),
	[CreatedById]													INT							NOT NULL,
	[CreatedAt]														DATETIME2(0)				NOT NULL,
	[UpdatedById]													INT							NULL,
	[UpdatedAt]														DATETIME2(0)				NULL,
	[DeletedById]													INT							NULL,
	[DeletedAt]														DATETIME2(0)				NULL,
	CONSTRAINT [PK_Person] PRIMARY KEY (
		[Id]
	),
	CONSTRAINT [FK_Person_CreatedPerson] FOREIGN KEY (
		[CreatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_Person_UpdatedPerson] FOREIGN KEY (
		[UpdatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_Person_DeletedPerson] FOREIGN KEY (
		[DeletedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	)
)
GO

GRANT SELECT, INSERT, UPDATE ON [dbo].[Person] TO [ddapi]