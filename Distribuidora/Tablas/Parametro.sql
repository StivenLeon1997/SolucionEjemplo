CREATE TABLE [dbo].[Parametro]
(
	[Id_Parametro] INT NOT NULL IDENTITY , 
    [Nombre_Parametro] VARCHAR(50) NOT NULL, 
    [Descripcion_Parametro] VARCHAR(500) NOT NULL, 
    PRIMARY KEY ([Id_Parametro])
)

GO

CREATE UNIQUE INDEX [IX_Parametro_Unico] ON [dbo].[Parametro] (Nombre_Parametro)
