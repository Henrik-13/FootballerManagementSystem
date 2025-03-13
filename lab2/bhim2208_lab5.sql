--Bálint Henrik
--521
--bhim2208

USE bhim2208_AB


CREATE LOGIN Adminisztrator WITH PASSWORD = 'admin'
CREATE USER Adminisztrator FOR LOGIN Adminisztrator
GRANT SELECT, DELETE, UPDATE ON DATABASE::bhim2208_AB TO Adminisztrator

CREATE LOGIN Vendeg WITH PASSWORD = 'vendeg'
CREATE USER Vendeg FOR LOGIN Vendeg
GRANT SELECT ON DATABASE::bhim2208_AB TO Vendeg


CREATE LOGIN Felhasznalo WITH PASSWORD = 'felhasznalo'
CREATE USER Felhasznalo FOR LOGIN Felhasznalo
GRANT SELECT, UPDATE ON DATABASE::bhim2208_AB TO Felhasznalo


GO
CREATE OR ALTER PROCEDURE sp_Regisztracio (@username NVARCHAR(50), @password NVARCHAR(50))
AS BEGIN
	SET NOCOUNT ON
	
	DECLARE @SQL NVARCHAR(MAX)

	IF EXISTS (SELECT name
     FROM sys.database_principals
     WHERE name = '@username')
	BEGIN
		RAISERROR ('User already exists', 11, 1)
		RETURN -1
	END

	SET @SQL = 'CREATE LOGIN ' + QUOTENAME(@username) + ' WITH PASSWORD = ' + QUOTENAME(@password, '''')
	EXEC sp_executesql @SQL

    SET @SQL = 'CREATE USER ' + QUOTENAME(@username) + ' FOR LOGIN ' + QUOTENAME(@username)
    EXEC sp_executesql @SQL

    SET @SQL = 'GRANT SELECT, UPDATE ON DATABASE::bhim2208_AB TO ' + QUOTENAME(@username)
    EXEC sp_executesql @SQL
	
END
GO

--EXEC sp_Regisztracio