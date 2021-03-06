CREATE DATABASE [dbVentasOnline]
GO
USE [dbVentasOnline]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProducto]    Script Date: 13/02/2016 19:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: scriptVentasOnline.sql|7|0|M:\CIBERTEC\MODULO2-CLASE18\scriptVentasOnline.sql
Create Procedure [dbo].[DeleteProducto] @ProductId Int
As
Begin
	Delete Producto Where ProductId=@ProductId;
End


GO
/****** Object:  StoredProcedure [dbo].[GetProducto]    Script Date: 13/02/2016 19:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: scriptVentasOnline.sql|19|0|M:\CIBERTEC\MODULO2-CLASE18\scriptVentasOnline.sql
Create Procedure [dbo].[GetProducto]  @Id Int=Null
As
Begin
	If @Id Is Null
		Select ProductId, Nombre, Precio From Producto With(NoLock);
	Else
		Select ProductId, Nombre, Precio From Producto With(NoLock) Where ProductId=@Id;
End


GO
/****** Object:  StoredProcedure [dbo].[GetProductos]    Script Date: 13/02/2016 19:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: scriptVentasOnline.sql|34|0|M:\CIBERTEC\MODULO2-CLASE18\scriptVentasOnline.sql
create procedure  [dbo].[GetProductos]
as 
begin
select ProductId, Nombre, Precio from Producto with(nolock) --No bloquear
end 

GO
/****** Object:  StoredProcedure [dbo].[InsertProducto]    Script Date: 13/02/2016 19:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: scriptVentasOnline.sql|45|0|M:\CIBERTEC\MODULO2-CLASE18\scriptVentasOnline.sql
create procedure  [dbo].[InsertProducto]
@Nombre nvarchar (100),
@precio decimal  (18,2)
as 
begin
insert into Producto (Nombre, Precio)
values(@Nombre,@precio)

select SCOPE_IDENTITY()  AS idProducto
end 


GO
/****** Object:  StoredProcedure [dbo].[UpdateProducto]    Script Date: 13/02/2016 19:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: scriptVentasOnline.sql|62|0|M:\CIBERTEC\MODULO2-CLASE18\scriptVentasOnline.sql
Create Procedure [dbo].[UpdateProducto] @ProductId Int, @Nombre As nVarChar(100), @Precio As decimal(18,2)
As
Begin
	Update Producto Set Nombre=@Nombre, Precio=@Precio Where ProductId=@ProductId;
End


GO
/****** Object:  Table [dbo].[Producto]    Script Date: 13/02/2016 19:03:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Precio] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (1, N'pantalla LCD ', CAST(20.20 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (2, N'Mouse', CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (3, N'tablet LG', CAST(50.60 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (4, N'TV', CAST(255.00 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (5, N'parlantes', CAST(63.00 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (6, N'audifonos samsumg V', CAST(15.90 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (7, N'celular LG', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (8, N'impresora HP', CAST(115.00 AS Decimal(18, 2)))
INSERT [dbo].[Producto] ([ProductId], [Nombre], [Precio]) VALUES (9, N'USB HP', CAST(95.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Producto] OFF
