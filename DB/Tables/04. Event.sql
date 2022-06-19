SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

USE UNEXUS_APPSERVER

CREATE TABLE Event
(
	ID          INT IDENTITY(1,1) PRIMARY KEY,
	Descr       NVARCHAR(255),
	Date        DATETIME,
	BonusPoint  INT,
	ComersLimit INT
)

GO