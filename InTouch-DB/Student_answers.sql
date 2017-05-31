CREATE TABLE [dbo].[Student_answers]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Question_ID] UNIQUEIDENTIFIER NOT NULL, 
    [Student_ID] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Student_answers_Questions] FOREIGN KEY (Question_ID) REFERENCES Questions(Id), 
    CONSTRAINT [FK_Student_answers_Users] FOREIGN KEY (Student_ID) REFERENCES Users(Id)
)
