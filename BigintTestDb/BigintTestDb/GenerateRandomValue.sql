-- =============================================
-- Author:		Jos Menhart
-- Create date: 20231014
-- Description:	Designed to keep the insert statement simple
-- =============================================
CREATE FUNCTION GenerateRandomValue 
(
	-- Add the parameters for the function here
	@row_number BIGINT,
	@random_uid UNIQUEIDENTIFIER
)
RETURNS VARCHAR(255)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result VARCHAR(255)

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = 'This is row ' + CAST(@row_number AS VARCHAR(19)) + ' with random guid ' + CAST(@random_uid AS VARCHAR(36))

	-- Return the result of the function
	RETURN @Result

END
GO

