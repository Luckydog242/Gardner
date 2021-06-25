CREATE TABLE [dbo].[Blog] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (60)  NOT NULL,
    [Body]      NVARCHAR (MAX) NOT NULL,
    [Alias]     NVARCHAR (100) NOT NULL,
    [StartDate] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Blog_Alias] FOREIGN KEY ([Alias]) REFERENCES [dbo].[Alias] ([AliasName])
);

