CREATE TABLE [dbo].[CompetenceElementGroup]
(
	[Id]															INT							NOT NULL	IDENTITY(1,1),
	[Label]															NVARCHAR(100)				NOT NULL,
	[OwnerId]														INT							NOT NULL,
	[ViewOrder]														SMALLINT					NOT NULL	DEFAULT(0),
	[CreatedById]													INT							NOT NULL,
	[CreatedAt]														DATETIME2(0)				NOT NULL,
	[UpdatedById]													INT							NULL,
	[UpdatedAt]														DATETIME2(0)				NULL,
	[DeletedById]													INT							NULL,
	[DeletedAt]														DATETIME2(0)				NULL,
	CONSTRAINT [PK_CompetenceElementGroup] PRIMARY KEY (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElementGroup_CreatedPerson] FOREIGN KEY (
		[CreatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElementGroup_UpdatedPerson] FOREIGN KEY (
		[UpdatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElementGroup_DeletedPerson] FOREIGN KEY (
		[DeletedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElementGroup_Owner] FOREIGN KEY (
		[OwnerId]
	) REFERENCES [dbo].[Person] (
		[Id]
	)
)
GO

GRANT SELECT, INSERT, UPDATE TO [ddapi]
GO