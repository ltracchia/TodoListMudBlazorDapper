CREATE TABLE [dbo].[TodoList] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FkProjectId]  INT           NULL,
    [Name]         VARCHAR (50)  NOT NULL,
    [Description]  VARCHAR (200) NULL,
    [IsDeleted]    BIT           CONSTRAINT [DF_TodoList_IsDeleted] DEFAULT ((0)) NOT NULL,
    [DateCreated]  DATETIME      NOT NULL,
    [DateModified] DATETIME      NULL,
    CONSTRAINT [PK_TodoList] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO