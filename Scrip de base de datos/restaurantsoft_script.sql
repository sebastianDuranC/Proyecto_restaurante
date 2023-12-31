-- Crear la base de datos
CREATE DATABASE SoftRESTAURANT;
GO

-- Usar la base de datos recién creada
USE SoftRESTAURANT;
GO

-- Crear la tabla [acceso]
CREATE TABLE [dbo].[acceso](
    [userid] [int] IDENTITY(1,1) NOT NULL,
    [username] [varchar](25) NULL,
    [uspass] [varchar](25) NULL,
    [NOMBRE] [varchar](25) NULL,
    CONSTRAINT [PK_acceso] PRIMARY KEY CLUSTERED ([userid] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);
INSERT INTO [dbo].[acceso] VALUES ('admin', 'admin', 'sebas');
GO

-- Crear la tabla [Cliente]
CREATE TABLE [dbo].[Cliente](
    [id_cliente] [int] IDENTITY(1,1) NOT NULL,
    [Nit] [int] NOT NULL,
    [Nombre] [varchar](50) NULL,
    [Fecha_Registro] [datetime] NULL,
    CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([id_cliente] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);
GO

-- Crear la tabla [Comidas]
CREATE TABLE [dbo].[Comidas](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [Nombre] [nvarchar](255) NULL,
    [Costo] [float] NULL,
    [Categoria] [varchar](20) NULL,
    [Imagen] [image] NULL,
    CONSTRAINT [PK_Comidas] PRIMARY KEY CLUSTERED ([ID] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY];
GO

-- Crear la tabla [empleados]
CREATE TABLE [dbo].[empleados](
    [ID] [int] NOT NULL,
    [NOMBRE] [nvarchar](15) NULL,
    [APELLIDOS] [nvarchar](20) NULL,
    [TELEFONO] [int] NULL,
    [SALARIO] [int] NULL,
    [categoria] [nvarchar](10) NULL,
    CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED ([ID] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);
GO

-- Crear la tabla [pedidos]
CREATE TABLE [dbo].[pedidos](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [NOMBRE] [varchar](50) NOT NULL,
    [QTY] [int] NOT NULL,
    [PRECIO] [float] NOT NULL,
    [CANTIDAD] [int] NOT NULL,
    [id_cliente] [int] NULL,
    CONSTRAINT [PK_pedidos] PRIMARY KEY CLUSTERED ([ID] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);
GO

-- Crear la tabla [producto]
CREATE TABLE [dbo].[producto](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [NOMBRE] [nvarchar](20) NULL,
    [DESCRIPCION] [varchar](50) NULL,
    [MARCA] [varchar](25) NULL,
    [PRECIO] [float] NOT NULL,
    [STOCK] [int] NOT NULL,
    CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED ([ID] ASC)
    WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
);
GO

-- Agregar restricción de clave externa a la tabla [pedidos]
ALTER TABLE [dbo].[pedidos] WITH CHECK ADD CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente]);
GO

-- Verificar la restricción de clave externa en la tabla [pedidos]
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_Pedido_Cliente];
GO

-- Crear la tabla [compras]
create table compras (
id int primary key identity(1,1),
Cantidad int,
Producto varchar(50),
Precio float,
Tipo_Pago varchar (25),
Precio_Final float ,
)
insert into compras(cantidad,Producto,precio,Tipo_Pago,Precio_Final) 
values(2,'cebolaçla',25,'pagoporQR',50)
GO