CREATE TABLE [dbo].[Groups]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Number] NVARCHAR(10) NOT NULL, 
    [University] BIGINT NULL, 
    CONSTRAINT [FK_Groups_Universities] FOREIGN KEY (University) REFERENCES Universities(Id)
)
