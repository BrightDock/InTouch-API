CREATE TABLE [dbo].[Posts]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Author_ID] UNIQUEIDENTIFIER NOT NULL, 
    [Subject_ID] UNIQUEIDENTIFIER NULL, 
    [Post_type] INT NOT NULL, 
    [Text] NVARCHAR(MAX) NOT NULL, 
    [Lection_number] SMALLINT NULL, 
    CONSTRAINT [FK_Posts_Users] FOREIGN KEY (Author_ID) REFERENCES Users(id), 
    CONSTRAINT [FK_Posts_Subjects] FOREIGN KEY (Subject_ID) REFERENCES Subjects(Id), 
    CONSTRAINT [FK_Posts_Post_types] FOREIGN KEY (Post_type) REFERENCES Post_types(Id)
)
