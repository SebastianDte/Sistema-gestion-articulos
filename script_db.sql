USE master
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CATALOGO_P3_DB')
BEGIN
    CREATE DATABASE CATALOGO_P3_DB
END
GO

USE CATALOGO_P3_DB
GO

-- 1. TABLA MARCAS
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MARCAS')
BEGIN
    CREATE TABLE MARCAS (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Descripcion VARCHAR(50) NOT NULL
    )
END
GO

-- 2. TABLA CATEGORIAS
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'CATEGORIAS')
BEGIN
    CREATE TABLE CATEGORIAS (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Descripcion VARCHAR(50) NOT NULL
    )
END
GO

-- 3. TABLA ARTICULOS
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ARTICULOS')
BEGIN
    CREATE TABLE ARTICULOS (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        Codigo VARCHAR(50) NOT NULL,
        Nombre VARCHAR(50) NOT NULL,
        Descripcion VARCHAR(150) NULL,
        IdMarca INT NOT NULL FOREIGN KEY REFERENCES MARCAS(Id),
        IdCategoria INT NOT NULL FOREIGN KEY REFERENCES CATEGORIAS(Id),
        Precio MONEY NOT NULL
    )
END
GO

-- 4. TABLA IMAGENES
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'IMAGENES')
BEGIN
    CREATE TABLE IMAGENES (
        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        IdArticulo INT NOT NULL FOREIGN KEY REFERENCES ARTICULOS(Id) ON DELETE CASCADE,
        ImagenUrl VARCHAR(1000) NOT NULL
    )
END
GO

-- =============================================
-- DATOS SEMILLA / PRUEBA
-- =============================================

-- Marcas
IF NOT EXISTS (SELECT 1 FROM MARCAS)
BEGIN
    SET IDENTITY_INSERT MARCAS ON
    INSERT INTO MARCAS (Id, Descripcion) VALUES 
        (1, 'Samsung'),
        (2, 'Apple'),
        (3, 'Sony'),
        (4, 'Huawei'),
        (5, 'Motorola')
    SET IDENTITY_INSERT MARCAS OFF
END
GO

-- Categorías
IF NOT EXISTS (SELECT 1 FROM CATEGORIAS)
BEGIN
    SET IDENTITY_INSERT CATEGORIAS ON
    INSERT INTO CATEGORIAS (Id, Descripcion) VALUES 
        (1, 'Celulares'),
        (2, 'Televisores'),
        (3, 'Media'),
        (4, 'Audio')
    SET IDENTITY_INSERT CATEGORIAS OFF
END
GO

-- Artículos
IF NOT EXISTS (SELECT 1 FROM ARTICULOS)
BEGIN
    SET IDENTITY_INSERT ARTICULOS ON
    INSERT INTO ARTICULOS (Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES 
        (1, 'S01', 'Galaxy S10', 'Smartphone flagship de Samsung con pantalla Dynamic AMOLED de 6.1"', 1, 1, 69999.00),
        (2, 'M03', 'Moto G Play', 'Smartphone gama de entrada con batería duradera', 5, 1, 15699.00),
        (3, 'AR01', 'Smart TV 55 4K', 'Televisor inteligente resolución 4K HDR', 3, 2, 120500.00),
        (4, 'A01', 'iPhone 11', 'Apple iPhone 11 con doble cámara y chip A13 Bionic', 2, 1, 119999.00),
        (5, 'S02', 'Auriculares WH-1000XM4', 'Auriculares inalámbricos con cancelación de ruido líder', 3, 4, 85000.00)
    SET IDENTITY_INSERT ARTICULOS OFF
END
GO

-- Imágenes
IF NOT EXISTS (SELECT 1 FROM IMAGENES)
BEGIN
    INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES 
        (1, 'https://images.samsung.com/is/image/samsung/p6pim/ar/sm-g973fzkjaro/gallery/ar-galaxy-s10-sm-g973-sm-g973fzkjaro-thumb-149092497'),
        (2, 'https://motorolaus.vtexassets.com/arquivos/ids/159844-800-auto'),
        (3, 'https://www.sony.com.ar/image/bc6d2d373f71c4c9258fb56bf93c3b06?fmt=pjpeg&wid=330&hei=330&bgcolor=FFFFFF&bgf=bid'),
        (4, 'https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone11-select-2019-family'),
        (5, 'https://m.media-amazon.com/images/I/71o8Or1GhO7._AC_SL1500_.jpg')
END
GO

