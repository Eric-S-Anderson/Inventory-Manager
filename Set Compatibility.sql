



SELECT *
	INTO #buffer
	FROM sys.databases


DECLARE @CurrentDB VARCHAR(MAX)
DECLARE @SQLString VARCHAR(MAX)

WHILE EXISTS (SELECT * FROM #buffer)
BEGIN
	SELECT TOP 1 @CurrentDB = name
		FROM #buffer

	SET @SQLString = 'ALTER DATABASE "' + @CurrentDB + '"
						SET COMPATIBILITY_LEVEL = 100'

	PRINT (@SQLString)
	EXEC (@SQLString)

	DELETE FROM #buffer
		WHERE name = @CurrentDB

END

DROP TABLE #buffer