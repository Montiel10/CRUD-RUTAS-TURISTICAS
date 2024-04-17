
CREATE DATABASE VentaBoletosDB;

USE VentaBoletosDB;

CREATE TABLE Clientes (
    ClienteId INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
	Apellido NVARCHAR(100),
	Celular NVARCHAR(100),
);

CREATE TABLE Ventas (
    VentaId INT PRIMARY KEY IDENTITY,
    ClienteId INT,
    Ruta NVARCHAR(100),
    CantidadPersonas INT,
    MontoTotal DECIMAL(10, 2),
    FOREIGN KEY (ClienteId) REFERENCES Clientes(ClienteId)
);





