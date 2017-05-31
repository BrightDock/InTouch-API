CREATE TABLE [dbo].[Passed_tests]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Test_ID] UNIQUEIDENTIFIER NOT NULL, 
    [Question_ID] UNIQUEIDENTIFIER NOT NULL, 
    [User_ID] UNIQUEIDENTIFIER NOT NULL, 
    [Selected_answer_ID] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Passed_tests_Questions] FOREIGN KEY (Question_ID) REFERENCES Questions(Id), 
    CONSTRAINT [FK_Passed_tests_Users] FOREIGN KEY (User_ID) REFERENCES Users(Id), 
    CONSTRAINT [FK_Passed_tests_Question_options] FOREIGN KEY (Selected_answer_ID) REFERENCES Question_options(Id), 
    CONSTRAINT [FK_Passed_tests_Tests] FOREIGN KEY (Test_ID) REFERENCES Tests(Id)
)
