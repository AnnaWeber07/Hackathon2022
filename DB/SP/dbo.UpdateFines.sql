SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.UpdateFines') IS NULL
	EXEC ('CREATE PROCEDURE dbo.UpdateFines AS RETURN 0')
GO

ALTER PROCEDURE dbo.UpdateFines
	@ID               INT,
	@User             INT,
	@FinesPointAmount INT
AS

IF @ID IS NULL
	INSERT INTO Fines([User], FinesPointAmount)
	VALUES
	(@User, @FinesPointAmount)
ELSE
	UPDATE Fines
	SET	   [User]           = @User,
		   FinesPointAmount = @FinesPointAmount
	WHERE ID                = @ID