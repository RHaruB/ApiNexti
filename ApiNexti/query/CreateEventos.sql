use NEXTI

-- Creaci�n de la tabla Evento
CREATE TABLE Evento (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FechaEvento DATE,
    LugarEvento NVARCHAR(255),
    NumEntradas INT,
    DescripcionEvento NVARCHAR(MAX),
    Precio DECIMAL(10, 2),
    FechaCreacion DATETIME,
    FechaModificacion DATETIME,
    Eliminado BIT
);

-- Creaci�n de la tabla LogEventos
CREATE TABLE LogEventos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDEvento INT,
    Accion NVARCHAR(50),
    FechaAccion DATETIME,
    Usuario NVARCHAR(100)
);

-- Agregar una clave for�nea en LogEventos para hacer referencia a Evento
ALTER TABLE LogEventos
ADD CONSTRAINT FK_LogEventos_Evento
FOREIGN KEY (IDEvento)
REFERENCES Evento(ID);



---- Insertar registro 1 en Evento
--INSERT INTO Evento (FechaEvento, LugarEvento, NumEntradas, DescripcionEvento, Precio, FechaCreacion, FechaModificacion, Eliminado)
--VALUES ('2023-10-01', 'Lugar 1', 100, 'Descripci�n del Evento 1', 50.00, GETDATE(), GETDATE(), 0);

---- Insertar registro 2 en Evento
--INSERT INTO Evento (FechaEvento, LugarEvento, NumEntradas, DescripcionEvento, Precio, FechaCreacion, FechaModificacion, Eliminado)
--VALUES ('2023-10-02', 'Lugar 2', 100, 'Descripci�n del Evento 2', 50.00, GETDATE(), GETDATE(), 0);

---- Insertar registro 3 en Evento
--INSERT INTO Evento (FechaEvento, LugarEvento, NumEntradas, DescripcionEvento, Precio, FechaCreacion, FechaModificacion, Eliminado)
--VALUES ('2023-10-03', 'Lugar 3', 100, 'Descripci�n del Evento 3', 50.00, GETDATE(), GETDATE(), 0);

---- Insertar registro 4 en Evento
--INSERT INTO Evento (FechaEvento, LugarEvento, NumEntradas, DescripcionEvento, Precio, FechaCreacion, FechaModificacion, Eliminado)
--VALUES ('2023-10-04', 'Lugar 4', 100, 'Descripci�n del Evento 4', 50.00, GETDATE(), GETDATE(), 0);

---- Insertar registro 5 en Evento
--INSERT INTO Evento (FechaEvento, LugarEvento, NumEntradas, DescripcionEvento, Precio, FechaCreacion, FechaModificacion, Eliminado)
--VALUES ('2023-10-05', 'Lugar 5', 100, 'Descripci�n del Evento 5', 50.00, GETDATE(), GETDATE(), 0);


---- Insertar registro 1 en LogEventos
--INSERT INTO LogEventos (IDEvento, Accion, FechaAccion, Usuario)
--VALUES (1, 'Creaci�n', GETDATE(), 'Usuario1');

---- Insertar registro 2 en LogEventos
--INSERT INTO LogEventos (IDEvento, Accion, FechaAccion, Usuario)
--VALUES (2, 'Creaci�n', GETDATE(), 'Usuario1');

---- Insertar registro 3 en LogEventos
--INSERT INTO LogEventos (IDEvento, Accion, FechaAccion, Usuario)
--VALUES (3, 'Creaci�n', GETDATE(), 'Usuario1');

---- Insertar registro 4 en LogEventos
--INSERT INTO LogEventos (IDEvento, Accion, FechaAccion, Usuario)
--VALUES (4, 'Creaci�n', GETDATE(), 'Usuario1');

---- Insertar registro 5 en LogEventos
--INSERT INTO LogEventos (IDEvento, Accion, FechaAccion, Usuario)
--VALUES (5, 'Creaci�n', GETDATE(), 'Usuario1');

