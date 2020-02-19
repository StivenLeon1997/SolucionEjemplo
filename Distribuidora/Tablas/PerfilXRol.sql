CREATE TABLE [dbo].[PerfilXRol]
(
	[Id_PerfilXRol] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FK_DetalleParametro_Rol] BIGINT NOT NULL, 
    [FK_DetalleParametro_Perfil] BIGINT NOT NULL, 
    [estado_PerfilXRol] BIT NOT NULL, 
    CONSTRAINT [FK_PerfilXRol_ToDetalleParametro] FOREIGN KEY ([FK_DetalleParametro_Rol]) REFERENCES [DetalleParametro]([Id_DetalleParametro]),
	CONSTRAINT [FK_PerfilXRol_ToDetalleParametro2] FOREIGN KEY ([FK_DetalleParametro_Perfil]) REFERENCES [DetalleParametro]([Id_DetalleParametro])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'IdDetalleParamero cuando el Nombre sea Perfil',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'PerfilXRol',
    @level2type = N'COLUMN',
    @level2name = N'FK_DetalleParametro_Perfil'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'IdDetalleParamero cuando el Nombre sea Rol',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'PerfilXRol',
    @level2type = N'COLUMN',
    @level2name = N'FK_DetalleParametro_Rol'