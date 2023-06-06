CREATE TABLE [dbo].[Person] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50)   NOT NULL,
    [LastName]  VARCHAR (50)   NOT NULL,
    [FkUserId]  NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Person_AspNetUsers] FOREIGN KEY ([FkUserId]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

