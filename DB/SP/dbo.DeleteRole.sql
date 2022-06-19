SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.DeleteRole') IS NULL
	EXEC ('CREATE PROCEDURE dbo.DeleteRole AS RETURN 0')
GO

ALTER PROCEDURE dbo.DeleteRole
	@ID INT
AS

DELETE FROM Role
WHERE  ID = @ID