SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.GetEvents') IS NULL
	EXEC('CREATE PROCEDURE dbo.GetEvents AS RETURN 0')
GO

ALTER PROCEDURE dbo.GetEvents
AS

SELECT ID,
	   Descr,
	   Date,
	   BonusPoint,
	   ComersLimit
FROM   dbo.Events