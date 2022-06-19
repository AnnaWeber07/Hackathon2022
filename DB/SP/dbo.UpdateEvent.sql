SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.UpdateEvent') IS NULL
	EXEC ('CREATE PROCEDURE dbo.UpdateEvent AS RETURN 0')
GO

ALTER PROCEDURE dbo.UpdateEvent
	@ID          INT,
	@Descr       NVARCHAR(255),
	@Date        DATETIME,
	@BonusPoint  INT,
	@ComersLimit INT
AS

IF @ID IS NULL
	INSERT INTO Event(Descr, Date, BonusPoint, ComersLimit)
	VALUES
	(@Descr, @Date, @BonusPoint, @ComersLimit)
ELSE
	UPDATE Event
	SET Descr       = @Descr,
		Date        = @Date,
		BonusPoint  = @BonusPoint,
		ComersLimit = @ComersLimit
	WHERE ID = @ID