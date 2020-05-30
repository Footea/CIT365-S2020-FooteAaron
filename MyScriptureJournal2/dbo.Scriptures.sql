CREATE TABLE [dbo].[Scriptures] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Book]      NVARCHAR (MAX) NULL,
    [Chapter]   INT            NOT NULL,
    [Verse]     NVARCHAR (MAX) NULL,
	[DateAdded] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Scriptures] PRIMARY KEY CLUSTERED ([ID] ASC)
);

