CREATE TABLE [dbo].[Author] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Title]     NVARCHAR (60) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [U_Author_Names] UNIQUE NONCLUSTERED ([FirstName] ASC, [LastName] ASC)
);

