CREATE TABLE [dbo].[Subjecst_professors]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Subject] UNIQUEIDENTIFIER NOT NULL, 
    [Professor] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Subjecst_professors_Subjects] FOREIGN KEY (Subject) REFERENCES Subjects(Id), 
    CONSTRAINT [FK_Subjecst_professors_Users] FOREIGN KEY (Professor) REFERENCES Users(Id)
)
