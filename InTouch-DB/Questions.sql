CREATE TABLE [dbo].[Questions]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Text] NVARCHAR(MAX) NOT NULL, 
    [Type] INT NOT NULL, 
    [Difficulty] INT NOT NULL, 
    CONSTRAINT [FK_Questions_Question_types] FOREIGN KEY (Type) REFERENCES Question_types(Id), 
    CONSTRAINT [FK_Questions_Difficulty_of_questions] FOREIGN KEY (Difficulty) REFERENCES Difficulty_of_questions(Id)
)
