CREATE TABLE [dbo].[Question_options]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Question_ID] UNIQUEIDENTIFIER NOT NULL,
    [Option_text] NVARCHAR(MAX) NOT NULL, 
    [Is_right] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Question_options_Questions] FOREIGN KEY (Question_ID) REFERENCES Questions(Id)
)
