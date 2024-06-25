-- Tabla de Películas
CREATE TABLE GCC_Peliculas (
    PeliculaId INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(200),
    Genero NVARCHAR(50),
    Duracion INT, -- Duración en minutos
    Rating DECIMAL(3, 2)
);

-- Tabla de Salas
CREATE TABLE GCC_Salas (
    SalaId INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Location NVARCHAR(200),
    Capacidad INT
);

-- Tabla de Funciones
CREATE TABLE GCC_Funciones (
    FuncionId INT PRIMARY KEY IDENTITY(1,1),
    PeliculaId INT,
    SalaId INT,
    FechaFuncion DATETIME,
    Precio DECIMAL(10, 2),
    FOREIGN KEY (PeliculaId) REFERENCES GCC_Peliculas(PeliculaId),
    FOREIGN KEY (SalaId) REFERENCES GCC_Salas(SalaId)
);

-- Tabla de Asientos
CREATE TABLE GCC_Sillas (
    SillasId INT PRIMARY KEY IDENTITY(1,1),
    SalaId INT,
    Row NVARCHAR(5),
    NumeroSilla INT,
    FOREIGN KEY (SalaId) REFERENCES GCC_Salas(SalaId)
);