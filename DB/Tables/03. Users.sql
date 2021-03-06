SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

USE UNEXUS_APPSERVER

CREATE TABLE Users
(
	ID         INT IDENTITY(1,1) PRIMARY KEY,
	Name       NVARCHAR(255),
	Password   NVARCHAR(255),
	Role       INT,
	BonusPoint INT,

	FOREIGN KEY (Role) REFERENCES Roles(ID)
)

GO