CREATE TABLE [dbo].[FuncionalidadXPerfil]
(
	[Id_FuncionalidadXPerfil] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Fk_DetalleParametro_Perfil] BIGINT NOT NULL, 
    [FK_DetalleParametro_Funcionalidad] BIGINT NOT NULL, 
    [Estado_FuncionalidadXPerfil] BIT NOT NULL,
    CONSTRAINT [FK_FuncionalidadXPerfil_ToDetalleParametro] FOREIGN KEY ([FK_DetalleParametro_Funcionalidad]) REFERENCES [DetalleParametro]([Id_DetalleParametro]),
	CONSTRAINT [FK_FuncionalidadXPerfil_ToDetalleParametro2] FOREIGN KEY ([FK_DetalleParametro_Perfil]) REFERENCES [DetalleParametro]([Id_DetalleParametro])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'IdDetalleParamero cuando el Nombre sea Perfil',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'FuncionalidadXPerfil',
    @level2type = N'COLUMN',
    @level2name = N'Fk_DetalleParametro_Perfil'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'IdDetalleParamero cuando el Nombre sea Funcionalidad',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'FuncionalidadXPerfil',
    @level2type = N'COLUMN',
    @level2name = N'FK_DetalleParametro_Funcionalidad'