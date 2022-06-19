SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.UpdateRegistry') IS NULL
	EXEC ('CREATE PROCEDURE dbo.UpdateRegistry AS RETURN 0')
GO

ALTER PROCEDURE dbo.UpdateRegistry
	@ID	   INT,
	@Event INT,
	@Comer INT
AS

IF @ID IS NULL
	INSERT INTO Registry(Event, Comer)
	VALUES
	(@Event, @Comer)
ELSE
	UPDATE Registry
	SET   Event = @Event,
		  Comer = @Comer
	WHERE ID    = @ID