CREATE TABLE [dbo].[Alias] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [AliasName] NVARCHAR (100) NOT NULL,
    [FirstName] NVARCHAR (50)  NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Alias] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([AliasName] ASC),
    CONSTRAINT [FK_Alias_Names] FOREIGN KEY ([FirstName], [LastName]) REFERENCES [dbo].[Author] ([FirstName], [LastName])
);

