SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('dbo.UpdateUser') IS NULL
	EXEC ('CREATE PROCEDURE dbo.UpdateUser AS RETURN 0')
GO

ALTER PROCEDURE dbo.UpdateUser
	@ID			INT,
	@Name		NVARCHAR(255),
	@Password	NVARCHAR(255),
	@Role		INT,
	@BonusPoint INT
AS

IF @ID IS NULL
	INSERT INTO Users(Name, Password, Role, BonusPoint)
	VALUES
	(@Name, @Password, @Role, @BonusPoint)
ELSE
	UPDATE Users 
	SET    Name = @Name,
	       Password = @Password,
		   Role = @Role,
		   BonusPoint = @BonusPoint
	WHERE ID = @ID