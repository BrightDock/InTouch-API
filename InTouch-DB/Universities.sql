﻿CREATE TABLE [dbo].[Universities]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Logo] NVARCHAR(100) NULL, 
    [About_info] NVARCHAR(MAX) NULL
)
