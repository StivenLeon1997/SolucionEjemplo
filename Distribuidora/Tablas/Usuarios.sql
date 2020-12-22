CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre_Usuario] VARCHAR(50) NOT NULL, 
    [FK_DP_Rol] BIGINT NOT NULL, 
    [Correo_Usuario] VARCHAR(50) NULL, 
    [NumeroCelular] VARCHAR(10) NULL, 
    [Cedula_Usuario] NUMERIC(12) NOT NULL, 
    [Pass_Usuario] VARCHAR(200) NOT NULL, 
    CONSTRAINT [FK_Usuarios_ToDetalleParametro] FOREIGN KEY ([FK_DP_Rol]) REFERENCES [DetalleParametro]([Id_DetalleParametro])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id detalle parametro cuando el nombre de parametro sea ROL',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Usuarios',
    @level2type = N'COLUMN',
    @level2name = N'FK_DP_Rol'