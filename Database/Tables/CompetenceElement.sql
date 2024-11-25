CREATE TABLE [dbo].[CompetenceElement]
(
	[Id]															INT							NOT NULL	IDENTITY(1,1),
	[Label]															NVARCHAR(100)				NOT NULL,
	[CompetenceElementGroupId]										INT							NOT NULL,
	[ViewOrder]														SMALLINT					NOT NULL	DEFAULT(0),
	[CreatedById]													INT							NOT NULL,
	[CreatedAt]														DATETIME2(0)				NOT NULL,
	[UpdatedById]													INT							NULL,
	[UpdatedAt]														DATETIME2(0)				NULL,
	[DeletedById]													INT							NULL,
	[DeletedAt]														DATETIME2(0)				NULL,
	CONSTRAINT [PK_CompetenceElement] PRIMARY KEY (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElement_CompetenceElementGroup] FOREIGN KEY (
		[CompetenceElementGroupId]
	) REFERENCES [dbo].[CompetenceElementGroup] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElement_CreatedPerson] FOREIGN KEY (
		[CreatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElement_UpdatedPerson] FOREIGN KEY (
		[UpdatedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	),
	CONSTRAINT [FK_CompetenceElement_DeletedPerson] FOREIGN KEY (
		[DeletedById]
	) REFERENCES [dbo].[Person] (
		[Id]
	)
)
GO

GRANT SELECT, INSERT, UPDATE ON [dbo].[CompetenceElement] TO [ddapi]
GO