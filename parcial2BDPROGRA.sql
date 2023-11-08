-- Crear la base de datos
CREATE DATABASE parcial2BDPROGRA;
--DAMARYS ELENA OSOSRIO GUTIERREZ
--JOSE RIGOBERTO MENDOZA RIVAS

-- Usar la base de datos
USE parcial2BDPROGRA;

-- Crear la tabla Departamento
CREATE TABLE Departamento (
    IDDepartamento INT PRIMARY KEY,
    Nombre VARCHAR(50)
);

-- Crear la tabla Municipio
CREATE TABLE Municipio (
    IDMunicipio INT PRIMARY KEY,
    Nombre VARCHAR(50),
    IDDepartamento INT,
    FOREIGN KEY (IDDepartamento) REFERENCES Departamento(IDDepartamento)
);

-- Crear la tabla Cliente
CREATE TABLE Cliente (
    IDCliente INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    IDDepartamento INT,
    IDMunicipio INT,
    FOREIGN KEY (IDDepartamento) REFERENCES Departamento(IDDepartamento),
    FOREIGN KEY (IDMunicipio) REFERENCES Municipio(IDMunicipio)
);

-- Insertar 4 departamentos
INSERT INTO Departamento (IDDepartamento, Nombre) VALUES
(1, 'SONSONATE'),
(2, 'SAN SALVADOR'),
(3, 'SAN MIGUEL'),
(4, 'CHALATENANGO');

-- Insertar 3 municipios por departamento
INSERT INTO Municipio (IDMunicipio, Nombre, IDDepartamento) VALUES
(1, 'SONSONATE', 1),
(2, 'JUAYUA', 1),
(3, 'SAN ANTONIO DEL MONTE', 1),
(4, 'SAN SALVADOR', 2),
(5, 'ANTIGUO CUSCATLAN', 2),
(6, 'SANTA TECLA', 2),
(7, 'MONCAGUA', 3),
(8, 'CHIRILAGUA', 3),
(9, 'CHAPELTIQUE', 3),
(10, 'AGUA CALIENTE', 4),
(11, 'COMALAPA', 4),
(12, 'EL PARAISO', 4);

-- Insertar 2 clientes
INSERT INTO Cliente (IDCliente, Nombre, Apellido, IDDepartamento, IDMunicipio) VALUES
(1, 'DAMARYS', 'OSORIO', 1, 1),
(2, 'JOSE', 'MENDOZA', 2, 4);

-- Realizar la consulta JOIN para unir tablas
SELECT Cliente.Nombre, Cliente.Apellido, Departamento.Nombre AS NombreDepartamento, Municipio.Nombre AS NombreMunicipio
FROM Cliente
JOIN Departamento ON Cliente.IDDepartamento = Departamento.IDDepartamento
JOIN Municipio ON Cliente.IDMunicipio = Municipio.IDMunicipio;



