CREATE TABLE [dbo].[TodoList] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [FkProjectId] INT           NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [Description] VARCHAR (200) NULL,
    CONSTRAINT [PK_TodoList] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO