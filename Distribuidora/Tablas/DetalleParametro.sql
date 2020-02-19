CREATE TABLE [dbo].[DetalleParametro]
(
	[Id_DetalleParametro] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [DP_FK_Parametro] INT NOT NULL, 
    [DP_ValorNumero] BIGINT NULL, 
    [DP_ValorString] VARCHAR(MAX) NULL, 
    [DP_Estado] BIT NOT NULL, 
    CONSTRAINT [FK_DetalleParametro_ToParametro] FOREIGN KEY (DP_FK_Parametro ) REFERENCES Parametro(Id_Parametro)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'1 activo, 0 inactivo',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'DetalleParametro',
    @level2type = N'COLUMN',
    @level2name = N'DP_Estado'