CREATE TABLE [dbo].[students] (
    [Id]         INT      NOT NULL,
    [username]   TEXT     NOT NULL,
    [password]   TEXT     NOT NULL,
    [name]       TEXT     NOT NULL,
    [surname]    TEXT     NOT NULL,
    [born_year]  INT      NOT NULL,
    [photo]      TEXT     NOT NULL,
    [created_at] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

