/*
 Plantilla de script anterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se ejecutarán antes del script de compilación	
 Use la sintaxis de SQLCMD para incluir un archivo en el script anterior a la implementación			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script anterior a la implementación		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*
USE master;
GO
 
SET NOCOUNT ON
DECLARE @DBName varchar(50)
DECLARE @spidstr varchar(8000)
DECLARE @ConnKilled smallint
SET @ConnKilled=0
SET @spidstr = ''
 
Set @DBName = 'BD_Distribuidora'
IF db_id(@DBName) < 4
BEGIN
PRINT 'Las conexiones a la base de datos de sistema no puedes ser eliminadas.'
RETURN
END
SELECT @spidstr=coalesce(@spidstr,',' )+'kill '+convert(varchar, spid)+ '; '
FROM master..sysprocesses WHERE dbid=db_id(@DBName)
 
IF LEN(@spidstr) > 0
BEGIN
EXEC(@spidstr)
SELECT @ConnKilled = COUNT(1)
FROM master..sysprocesses WHERE dbid=db_id(@DBName)
END


DROP DATABASE BD_Distribuidora;
CREATE DATABASE BD_Distribuidora;
USE BD_Distribuidora;
*/