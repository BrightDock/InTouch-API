CREATE TABLE [dbo].[Tests]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Name] NVARCHAR(100) NOT NULL, 
    [Professor] UNIQUEIDENTIFIER NOT NULL, 
    [Subject] UNIQUEIDENTIFIER NOT NULL, 
    [Lection] UNIQUEIDENTIFIER NULL, 
    [Questions_count] INT NOT NULL, 
    [Light_questions_count] INT NULL DEFAULT 30, 
    [Medium_questions_count] INT NULL DEFAULT 50, 
    [Hard_questions_count] INT NULL DEFAULT 20, 
    [Date_start] DATETIME2 NULL, 
    [Date_end] DATETIME2 NULL, 
    CONSTRAINT [FK_Tests_Users] FOREIGN KEY (Professor) REFERENCES Users(Id), 
    CONSTRAINT [FK_Tests_Subjects] FOREIGN KEY (Subject) REFERENCES Subjects(Id), 
    CONSTRAINT [FK_Tests_Posts] FOREIGN KEY (Lection) REFERENCES Posts(Id)
)
