# Documentacion Transact-SQL

Documentacion basica Transact-SQL.
Ejecutar Sentencias de codigo seleccionado con Control + Shift + E
Para usar Intellisense escribir sql.

Indice
======
*   Mostrar todas Las base de datos de la Instancia SQL Server.
*   Seleccionar una Base de datos existente
*   Crear una nueva Base de datos
*   Borrar Base de datos
*   Elimina todos los registro de la tabla
*
*
*
*
*

Transact-SQL.
======

Mostrar todas Las base de datos de la Instancia SQL Server.
```sql
SELECT Name from sys.Databases;
```

Seleccionar una Base de datos existente
```sql
USE ExampleDatabaseName;
```

Crear una nueva Base de datos
```sql
CREATE DATABASE ExampleNameDataBase;
```


Borrar Base de datos
```sql
DROP DATABASE ExampleNameDataBase;
```




Elimina todos los registro de la tabla
```sql
TRUNCATE TABLE table_name;
```