SELECT Name from sys.Databases;
CREATE DATABASE Run;
use DigitalShop;


CREATE TABLE Empleado (
    EmpleadoID int,
    EmpleadoNombre varchar(255),
    EmpleadoApellido varchar(255),
    Address varchar(255),
    City varchar(255) 
);

ALTER TABLE Empleado
DROP COLUMN column_name;
select * from INFORMATION_SCHEMA.TABLES
select * from Productos

INSERT INTO Productos (ProductoID, ProductoTitulo, ProductoDescripcion, ProductoPrecioc2222)
VALUES ('1', 'Hunter x Hunter', 'Anime hxh in japan', '10');


SET IDENTITY_INSERT [dbo].[Productos] ON