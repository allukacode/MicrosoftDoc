# Documentacion Transact-SQL
Documentacion basica Transact-SQL
Ejecutar Sentencias de codigo seleccionado con Control + Shift + E
Para usar Intellisense escribir sql.

### Indice

```sql
SELECT Name from sys.Databases;
```




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
