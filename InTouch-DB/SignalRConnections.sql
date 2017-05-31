CREATE TABLE [dbo].[SignalRConnections]
(
	[Connection_ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [User_Agent] UNIQUEIDENTIFIER NOT NULL, 
    [Connected] BIT NOT NULL, 
    CONSTRAINT [FK_SignalRConnections_Users] FOREIGN KEY (User_Agent) REFERENCES Users(Id)
)
