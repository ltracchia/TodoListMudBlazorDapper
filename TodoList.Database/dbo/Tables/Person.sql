CREATE TABLE [dbo].[Person] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50)   NOT NULL,
    [LastName]     VARCHAR (50)   NOT NULL,
    [UserName]     NVARCHAR (256) NULL,
    [DateCreated]  DATETIME       NULL,
    [DateModified] DATETIME       NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC)
);





