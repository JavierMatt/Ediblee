﻿CREATE TABLE [User](
	Username VARCHAR(255) NOT NULL,
	ID INT IDENTITY(1,1) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	[Password] VARCHAR(255) NOT NULL,
	PRIMARY KEY(Username,ID)
)