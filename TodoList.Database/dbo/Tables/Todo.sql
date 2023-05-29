CREATE TABLE [dbo].[Todo] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Description]  VARCHAR (100) NOT NULL,
    [IsComplete]   BIT           CONSTRAINT [DF_Todo_IsComplete] DEFAULT ((0)) NOT NULL,
    [IsFavorite]   BIT           CONSTRAINT [DF_Todo_IsFavorite] DEFAULT ((0)) NOT NULL,
    [IsDeleted]    BIT           CONSTRAINT [DF_Todo_IsDeleted] DEFAULT ((0)) NOT NULL,
    [DateCreated]  DATETIME      NOT NULL,
    [DateModified] DATETIME      NULL,
    CONSTRAINT [PK_Todo] PRIMARY KEY CLUSTERED ([Id] ASC)
);

