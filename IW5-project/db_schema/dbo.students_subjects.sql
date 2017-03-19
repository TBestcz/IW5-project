CREATE TABLE [dbo].[students_subjects] (
    [Id]         INT NOT NULL,
    [student_id] INT NOT NULL,
    [subject_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [student_foreign] FOREIGN KEY ([student_id]) REFERENCES [dbo].[students] ([Id]),
    CONSTRAINT [subject_foreign] FOREIGN KEY ([subject_id]) REFERENCES [dbo].[subjects] ([Id])
);

