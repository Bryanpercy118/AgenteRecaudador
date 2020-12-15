CREATE TABLE [dbo].[Agente] (
    [Nit]               NUMERIC (18) NOT NULL,
    [MesReporte]        NUMERIC (18) NOT NULL,
    [Vigenciadereporte] NUMERIC (18) NOT NULL,
    [TipoEstampilla]    VARCHAR (25) NOT NULL,
    [ValorImpuesto]     DECIMAL (20) NOT NULL,
    [Identificacion]    VARCHAR (20) NULL,
    [Nombrecontratista] VARCHAR (30) NOT NULL,
    
);

  