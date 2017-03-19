CREATE TABLE [dbo].[ratings] (
    [Id]         INT  NOT NULL,
    [type]       INT  NOT NULL,
    [points]     INT  NOT NULL,
    [note]       TEXT NOT NULL,
    [student_id] INT  NOT NULL,
    [subject_id] INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [students_foreign] FOREIGN KEY ([student_id]) REFERENCES [dbo].[students] ([Id]),
    CONSTRAINT [subjects_foreign] FOREIGN KEY ([subject_id]) REFERENCES [dbo].[subjects] ([Id])
);

