SELECT Name from sys.Databases;
CREATE DATABASE Run;
use Run;


CREATE TABLE Empleado (
    EmpleadoID int,
    EmpleadoNombre varchar(255),
    EmpleadoApellido varchar(255),
    Address varchar(255),
    City varchar(255) 
);

CREATE TABLE NameNewTable AS
   SELECT EmpleadoID, EmpleadoNombre,EmpleadoApellido, Address, City
   FROM Empleado;

   