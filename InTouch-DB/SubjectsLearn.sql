﻿CREATE TABLE [dbo].[SubjectsLearn]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Subject_ID] UNIQUEIDENTIFIER NOT NULL, 
    [User_ID] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_SubjectsLearn_Subjects] FOREIGN KEY (Subject_ID) REFERENCES Subjects(Id), 
    CONSTRAINT [FK_SubjectsLearn_Users] FOREIGN KEY (User_ID) REFERENCES Users(Id)
)
