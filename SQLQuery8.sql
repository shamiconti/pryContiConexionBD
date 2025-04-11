-- Crear base de datos
CREATE DATABASE Comercio;
GO

-- Usar la base
USE Comercio;
GO

-- Crear tabla Categorias
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50)
);

-- Crear tabla Productos
CREATE TABLE Productos (
    Codigo INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Descripcion NVARCHAR(255),
    Precio DECIMAL(10,2),
    Stock INT,
    CategoriaId INT,
    FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
);

-- Insertar categor�as
INSERT INTO Categorias (Nombre) VALUES ('Tecnolog�a'), ('Hogar'), ('Ropa');

-- Insertar productos
INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
('Notebook Lenovo', 'Notebook i5 8GB RAM', 850000, 10, 1),
('Licuadora Philips', '600W, vaso de vidrio', 320000, 5, 2),
('Camisa Blanca', 'Manga larga, algod�n', 180000, 15, 3);