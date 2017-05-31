CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Name] NVARCHAR(40) NOT NULL, 
    [Surname] NVARCHAR(40) NOT NULL, 
    [Patronymic] NVARCHAR(40) NULL, 
    [Birthday] DATE NULL, 
    [University_certificate] NVARCHAR(20) NOT NULL, 
    [Password] VARCHAR(30) NOT NULL, 
    [Student_group] UNIQUEIDENTIFIER NULL, 
    [Student_group_start_year] DATE NULL, 
    [University] BIGINT NOT NULL, 
    [Avatar] NVARCHAR(100) NULL, 
    [User_type] INT NOT NULL, 
    [Email] NCHAR(60) NULL, 
    [IP] VARCHAR(15) NULL, 
    CONSTRAINT [FK_Users_User_types] FOREIGN KEY (User_type) REFERENCES User_types(Id), 
    CONSTRAINT [FK_Users_Universities] FOREIGN KEY (University) REFERENCES Universities(Id), 
    CONSTRAINT [FK_Users_Groups] FOREIGN KEY (Student_group) REFERENCES Groups(Id)
)
