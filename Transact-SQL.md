
/* 
    Documentacion 
    Para usar Intellisense escribir sql
    Ejecutar Sentencias de codigo seleccionado con Control + Shift + E
*/
/**/
/* Mostrar Todas Las Base de datos*/
SELECT Name from sys.Databases;
/* Seleccionar Base de datos*/
use NombreDeLaBaseDeDatos
-- Create a new database called 'DatabaseName'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'ControlDeCondominios'
)
CREATE DATABASE ControlDeCondominios
GO
Asdasd**
