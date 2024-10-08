/* --------------- PROCEDIMIENTOS PARA USUARIO  --------------- */

select * from USUARIO

/* PROCEDIMIENTO ALMACENADO PARA GUARDAR (INSERT) DE UN USUARIO */
create PROC sp_registrarusuario(
@Documento varchar (50),
@Nombre varchar (50),
@Apellido varchar (50),
@Correo varchar (100),
@Clave varchar (100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as 
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''
	
	if not exists(select * from USUARIO where Documento = @Documento)
	begin 
		insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado) values
		(@Documento, @Nombre, @Apellido, @Correo, @Clave, @IdRol, @Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else 
		set @Mensaje = 'No se puede repetir el Nro de Documento para mas de un usuario.'
end

go

/* PROCEDIMIENTO ALMACENADO PARA EDITAR (UPDATE) UN USUARIO */
create PROC sp_editarusuario(
@IdUsuario int,
@Documento varchar (50),
@Nombre varchar (50),
@Apellido varchar (50),
@Correo varchar (100),
@Clave varchar (100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)

as 
begin 

	set @Respuesta = 0
	set @Mensaje = ''
	
	if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	begin 
		update USUARIO set 
		Documento = @Documento, 
		Nombre = @Nombre, 
		Apellido = @Apellido,
		Correo = @Correo, 
		Clave = @Clave, 
		IdRol = @IdRol, 
		Estado = @Estado
		where IdUsuario = @IdUsuario
		
		set @Respuesta = 1

	end
	else 
		set @Mensaje = 'No se puede repetir el nro de documento para más de un usuario.'
end

go

/*
/* PROCEDIMIENTO ALMACENADO PARA 'DELETE' DE UN USUARIO */
create PROC SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)

as 
begin 

	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoRegla bit = 1
	
	if exists (select * from COMPRA c 
	inner join USUARIO u on u.IdUsuario = c.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin 
		set @pasoRegla = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una compra\n'
	end 

	if exists (select * from VENTA v 
	inner join USUARIO u on u.IdUsuario = v.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin 
		set @pasoRegla = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque el usuario se encuentra relacionado a una venta\n'
	end 
	
	if(@pasoRegla = 1)
	begin 
		
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1

	end
end
*/

/*
	if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	begin 
		update USUARIO set 
		Documento = @Documento, 
		Nombre = @Nombre, 
		Apellido = @Apellido,
		Correo = @Correo, 
		Clave = @Clave, 
		IdRol = @IdRol, 
		Estado = @Estado
		where IdUsuario = @IdUsuario
		
		set @Respuesta = 1
		
	end
	else 
		set @Mensaje = 'No se puede repetir el Nro de Documento para mas de un usuario.'
*/

declare @respuesta bit
declare @mensaje varchar(500)

/* 
exec sp_editarusuario 2, '123', 'pruebas 2', '4', 'test@gmail.com','456', 2, 1, @respuesta output, @mensaje output 
*/

select @respuesta
select @mensaje

select * from USUARIO

use BDD_NikeStore


/* --------------- PROCEDIMIENTOS PARA CATEGORIA  --------------- */


/* PROCEDIMIENTO ALMACENADO PARA REGISTRAR (INSERT)UNA CATEGORIA */
create PROC sp_registrarCategoria(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
As
Begin 
	SET  @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	Begin
		Insert Into CATEGORIA(Descripcion, Estado) Values (@Descripcion, @Estado) 
		Set @Resultado = SCOPE_IDENTITY()
	End
	ELSE
		set @Mensaje = 'No se puede repetir la descripción para más de una categoria.'
End

Go

/* PROCEDIMIENTO ALMACENADO PARA EDITAR (UPDATE)UNA CATEGORIA */
create PROCEDURE sp_EditarCategoria(
@IdCategoria int,
@Descripcion varchar (50),
@Estado bit, 
@Resultado bit output,
@Mensaje varchar (500) output
)
As
Begin 
	SET  @Resultado = 1
	IF NOT EXISTS (
	SELECT * FROM CATEGORIA 
	Where Descripcion = @Descripcion And IdCategoria != @IdCategoria)
		UPDATE CATEGORIA Set
		Descripcion = @Descripcion,
		Estado = @Estado
		Where IdCategoria = @IdCategoria
	ELSE
	Begin
		Set @Resultado = 0
		Set @Mensaje = 'No se puede repetir la descripcion de una categoria.'
	End
End

Go

/* PROCEDIMIENTO ALMACENADO PARA ELIMINAR (DELETE) UNA CATEGORIA */
/*
create PROCEDURE sp_EliminarProducto(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar (500) output
)

As
Begin 
	SET  @Resultado = 1
	IF NOT EXISTS (
	SELECT * FROM CATEGORIA c
	Inner Join PRODUCTO p On p.IdCategoria = c.IdCategoria
	Where c.IdCategoria = @IdCategoria
	)
	Begin
		DELETE Top (1) From CATEGORIA Where IdCategoria = @IdCategoria
	End
	ELSE
	Begin
		Set @Resultado = 0
		Set @Mensaje = 'La categoria se encuentra relacionada a un producto.'
	End
End
*/



/* --------------- PROCEDIMIENTOS PARA PRODUCTO  --------------- */

select * from producto

/* PROCEDIMIENTO ALMACENADO PARA REGISTRAR (INSERT) UN PRODUCTO */
create PROC sp_RegistrarProducto(
@Codigo varchar (50),
@Nombre varchar (50),
@Descripcion varchar(100),
@IdCategoria int,
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
As
Begin 
	/* El resultado se define como 0, o sea como falso */ 
	SET  @Resultado = 0
	/* Aca estamos validando que no existe un producto ya registrado con el mismo codigo */
	IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE Codigo = @Codigo)
	Begin
		/* Si no existe se procede a insertar en las columnas de codigo, nombre, descripcion, idcategoria y estado */
		/* Las columnas que no estan puestas aca es porque se van a cargar automanticamente con 0 */
		Insert Into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria, Estado) 
		Values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado) 
		/* Se almacena en @Resultado el ID del producto recien insertado */
		Set @Resultado = SCOPE_IDENTITY()
	End
	ELSE
		/* Sino en el caso de que ya exista un producto con el mismo codigo dira este mensaje */
		set @Mensaje = 'Ya existe un producto con el mismo codigo.'
End

Go

/* PROCEDIMIENTO ALMACENADO PARA EDITAR (UPDATE) UN PRODUCTO  */
create PROCEDURE sp_ModificarProducto(
@IdProducto int,
@Codigo varchar (50),
@Nombre varchar (50),
@Descripcion varchar (100),
@IdCategoria int,
@Estado bit, 
@Resultado bit output,
@Mensaje varchar (500) output
)
As
Begin 
	/* Definimos resultado como true, cosa que si no hay ningun cambio de esta validacion va a seguir siendo true */
	SET  @Resultado = 1
	/* De igual forma como todas las reglas de negocios que tuvimos le decimos que vas a actualizar este producto pero siempre y cuando no se repita o no tenga un codigo de producto ya anteriormente registrado */
	/* La palabra llave es codigo, esta no debe repetirse para todos, debe haber solo uno */
	IF NOT EXISTS (
	SELECT * FROM PRODUCTO 
	Where Codigo = @Codigo And IdProducto != @IdProducto)
		UPDATE PRODUCTO Set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria
		Where IdCategoria = @IdCategoria
	ELSE
	Begin
		Set @Resultado = 0
		Set @Mensaje = 'Ya existe un producto con el mismo codigo.'
	End
End

Go

/* PROCEDIMIENTO ALMACENADO PARA ELIMINAR (DELETE) UN PRODUCTO */
/*
create PROCEDURE sp_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar (500) output
)
As
Begin
	/* Aca comenzamos a definir las reglas, casi similiar a eliminar un usuario */
	/* Lo que sucede con los productos es que uno de estos siempre va a estar relacionado a una compra o tambien a una venta */
	/* Por ejemplo en DETALLE_VENTA siempre va a estar relacionada la columna IdProducto con la tabla PRODUCTO, lo mismo para DETALLE_COMPRA */
	/* NO SE PUEDE ELIMINAR UN PRODUCTO SI YA SE ESTA UTILIZANDO EN OTRAS TABLAS, lo que podemos hacer es desactivar ese producto (ponerlo como no activo) */
	SET  @Respuesta = 0
	SET @Mensaje = ' '
	DECLARE  @pasoreglas bit = 1
	/* Primero validamos que no se encuentre relacionado con un DETALLE_COMPRA */
	IF EXISTS (
	SELECT * FROM DETALLE_COMPRA dc
	Inner Join PRODUCTO p On p.IdProducto = dc.IdProducto
	Where dc.IdProducto = @IdProducto
	)
	Begin
		/* En caso de que si este relacionado dicho producto, mandamos este mensaje */
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado con una COMPRA\n'
	End
	IF EXISTS (select * from DETALLE_VENTA dv
	inner join producto p on p.IdCategoria = dv.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin 
		set @pasoreglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado con una VENTA\n'
	end
	/* Definimos la variable pasoreglas, esta esta en las condicionales cuando no se cumple, entonces si no hubo modificacion va a valer uno */
	/* Entonces con if, si paso reglas es 1, procedemos a eliminar el producto con el where de IdProducto */
	if(@pasoreglas = 1)
	Begin
		delete from producto where IdProducto = @IdProducto
		set @respuesta = 1
	End
End
*/

/* --------------- PROCEDIMIENTOS PARA CLIENTE  --------------- */

select * from CLIENTE 

/* PROCEDIMIENTO ALMACENADO PARA GUARDAR (INSERT) DE UN CLIENTE */
create PROC sp_RegistrarCliente(
@Documento varchar (50),
@Nombre varchar (50),
@Apellido varchar (50),
@Correo varchar (100),
@Telefono varchar (50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as 
begin
	set @Resultado = 0
	DECLARE @IDPERSONA INT
	if not exists(select * from CLIENTE where Documento = @Documento)
	begin 
		insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono, Estado) values
		(@Documento, @Nombre, @Apellido, @Correo, @Telefono, @Estado)

		set  @Resultado = SCOPE_IDENTITY()
	end
	else 
		set @Mensaje = 'El numero de documento ya existe.'
end

go

/* PROCEDIMIENTO ALMACENADO PARA EDITAR (UPDATE) UN CLIENTE */
create PROC sp_ModificarCliente(
@IdCliente int,
@Documento varchar (50),
@Nombre varchar (50),
@Apellido varchar (50),
@Correo varchar (100),
@Telefono varchar (100),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as 
begin 

	set @Resultado = 1
	DECLARE @IDPERSONA INT
	if not exists(select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
	begin 
		update CLIENTE set 
		Documento = @Documento, 
		Nombre = @Nombre, 
		Apellido = @Apellido,
		Correo = @Correo, 
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else 
	begin
		set @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe.'
	end
end

go

/* --------------- PROCEDIMIENTOS PARA PROVEEDOR  --------------- */

select * from PROVEEDOR 

/* PROCEDIMIENTO ALMACENADO PARA GUARDAR (INSERT) DE UN PROVEEDOR */
create PROC sp_RegistrarProveedor(
@Documento varchar (50),
@RazonSocial varchar (50),
@Correo varchar (100),
@Telefono varchar (50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)
as 
begin
	set @Resultado = 0
	DECLARE @IDPERSONA INT
	if not exists(select * from PROVEEDOR where Documento = @Documento)
	begin 
		insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono, Estado) values
		(@Documento, @RazonSocial, @Correo, @Telefono, @Estado)

		set  @Resultado = SCOPE_IDENTITY()
	end
	else 
		set @Mensaje = 'El numero de documento ya existe.'
end

go

/* PROCEDIMIENTO ALMACENADO PARA EDITAR (UPDATE) UN PROVEEDOR */
create PROC sp_ModificarProveedor(
@IdProveedor int,
@Documento varchar (50),
@RazonSocial varchar (50),
@Correo varchar (100),
@Telefono varchar (100),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as 
begin 

	set @Resultado = 1
	DECLARE @IDPERSONA INT
	if not exists(select * from PROVEEDOR where Documento = @Documento and IdProveedor != @IdProveedor)
	begin 
		update PROVEEDOR set 
		Documento = @Documento, 
		RazonSocial = @RazonSocial, 
		Correo = @Correo, 
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else 
	begin
		set @Resultado = 0
		set @Mensaje = 'El numero de documento ya existe.'
	end
end

go

/* --------------- PROCEDIMIENTOS PARA COMPRA  --------------- */

select * from COMPRA 

/* ESTRUCTURA DE TABLA DE DETALLE DE COMPRA */
create type [dbo].[EDetalle_Compra] as table(
	[IdProducto] int null,
	[PrecioCompra] decimal(18,2) null,
	[PrecioVenta] decimal(18,2) null,
	[Cantidad] int null,
	[MontoTotal] decimal(18,2)null
)

go

/* PROCEDIMIENTO ALMACENADO PARA GUARDAR (INSERT) DE UNA COMPRA */
create procedure sp_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] readonly,
@Resultado bit output,
@Mensaje varchar(500) output
)
as 
begin 
	
	begin try
		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		/* Registramos la COMPRA en la tabla COMPRA */
		insert into COMPRA(IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal) values(@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

		set @idcompra = SCOPE_IDENTITY()

		/* Registramos el DETALLE DE LA COMPRA en la tabla DETALLE COMPRA */
		insert into DETALLE_COMPRA(IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
		select @idcompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal from @DetalleCompra

		/* Actualizamos el STOCK, el precio COMPRA y el precio VENTA de cada PRODUCTO en la tabla PRODUCTO */
		update p set p.Stock = p.Stock + dc.Cantidad,
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on dc.IdProducto = p.IdProducto
		commit transaction registro
	end try
	begin catch
		/* Si hay un error antes del 'commit transaction', entra aca y hace un rollback y vuelve todo al punto antes de ejecutar al insert en la tabla COMPRA */
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()

		rollback transaction registro
	end catch
end

select * from COMPRA

select * from DETALLE_COMPRA

go

/*select * from COMPRA where NumeroDocumento = '00001'
select * from DETALLE_COMPRA where IdCompra = 1

select c.IdCompra, u.Apellido, pr.Documento, pr.RazonSocial, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103)[FechaRegistro] from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = '00001'

select p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal from DETALLE_COMPRA dc
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
where dc.IdCompra = 1*/


/* --------------- PROCEDIMIENTOS PARA VENTA  --------------- */

/* ESTRUCTURA DE TABLA DE DETALLE DE VENTA */
create type [dbo].[EDetalle_Venta] as table(
	[IdProducto] int null,
	[PrecioVenta] decimal(18,2) null,
	[Cantidad] int null,
	[SubTotal] decimal(18,2)null
)

go

/* PROCEDIMIENTO ALMACENADO PARA GUARDAR (INSERT) DE UNA VENTA */
create procedure sp_RegistrarVenta(
@IdUsuario int,
@TipoDocumento varchar(500),
@NumeroDocumento varchar(500),
@DocumentoCliente varchar(500),
@NombreCliente varchar(500),
@ApellidoCliente varchar(500),
@MontoPago decimal(18,2),
@MontoCambio decimal(18,2),
@MontoTotal decimal(18,2),
@DetalleVenta [EDetalle_Venta] readonly,
@Resultado bit output,
@Mensaje varchar(500) output
)
as 
begin 
	
	begin try
		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		/* Registramos la VENTA en la tabla VENTA */
		insert into VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, ApellidoCliente, MontoPago, MontoCambio, MontoTotal) 
		values(@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @ApellidoCliente, @MontoPago, @MontoCambio, @MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		/* Registramos el detalle de la VENTA en la tabla DETALLE VENTA */
		insert into DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
		select @idventa, IdProducto, PrecioVenta, Cantidad, SubTotal from @DetalleVenta

		commit transaction registro
	end try
	begin catch
		/* Si hay un error antes de 'commit transaction', entra aca y hace un rollback y vuelve todo al punto antes de ejecutar el insert en la tabla VENTA */
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro

	end catch

end

select * from VENTA where NumeroDocumento = '00001'

select * from DETALLE_VENTA where IdVenta = 1

select v.Idventa, u.Nombre, u.Apellido,
v.DocumentoCliente, v.NombreCliente, v.ApellidoCliente,
v.TipoDocumento, v.NumeroDocumento,
v.MontoPago, v.MontoCambio, v.MontoTotal,
convert(char(10), v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = '00001'

select p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal from DETALLE_VENTA dv
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
where dv.IdVenta = '00001'



/* --------------- CONSULTAS PARA MOSTRAR EN EL MENU REPORTES COMPRAS  --------------- */

/* PRUEBA DE LO QUE TIENE QUE MOSTRARSE EN EL REPORTE DE COMPRAS */
/*
select 
convert(char(10), c.FechaRegistro, 103)[FechaRegistro], c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
u.Apellido[UsuarioRegistro],
pr.Documento[DocumentoProveedor], pr.RazonSocial,
p.Codigo[CodigoProducto], p.Nombre[NombrePoducto], ca.Descripcion[Categoria], dc.PrecioCompra, dc.PrecioVenta, dc.Cantidad, dc.MontoTotal[SubTotal]
from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where convert(date, c.FechaRegistro) between '08/11/2023' and '18/11/2023'
and pr.IdProveedor = 3
*/

go

/* PROCEDIMIENTO ALMACENADO PARA MOSTRAR EN EL MENU REPORTES COMPRAS */
create proc sp_ReporteCompras(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
as
begin
	
	set Dateformat dmy; 
	select 
	CONVERT(char(10), c.FechaRegistro, 103)[FechaRegistro], c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
	u.Apellido[UsuarioRegistro],
	pr.Documento[DocumentoProveedor], pr.RazonSocial,
	p.Codigo[CodigoProducto], p.Nombre[NombrePoducto], ca.Descripcion[Categoria], dc.PrecioCompra, dc.PrecioVenta, dc.Cantidad, dc.MontoTotal[SubTotal]
	from COMPRA c
	inner join USUARIO u on u.IdUsuario = c.IdUsuario
	inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
	inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
	where convert(date, c.FechaRegistro) between @fechainicio and @fechafin
	and pr.IdProveedor = IIF(@idproveedor = 0, pr.IdProveedor, @idproveedor)

end

/*
exec sp_ReporteCompras '08/11/2023', '18/11/2023', 3
exec sp_ReporteCompras '08/11/2023', '18/11/2023', 0
*/

go

/* --------------- CONSULTAS PARA MOSTRAR EN EL MENU REPORTES COMPRAS  --------------- */

/* PROCEDIMIENTO ALMACENADO PARA MOSTRAR EN EL MENU REPORTES VENTAS */
create proc sp_ReporteVentas(
@fechainicio varchar(10),
@fechafin varchar(10)
)
as
begin
	
	set Dateformat dmy; 
	select 
	CONVERT(char(10), v.FechaRegistro, 103)[FechaRegistro], v.TipoDocumento, v.NumeroDocumento, v.MontoTotal,
	u.Apellido[UsuarioRegistro],
	v.DocumentoCliente, v.NombreCliente, v.ApellidoCliente,
	p.Codigo[CodigoProducto], p.Nombre[NombrePoducto], ca.Descripcion[Categoria], dv.PrecioVenta, dv.Cantidad, dv.SubTotal
	from VENTA v
	inner join USUARIO u on u.IdUsuario = v.IdUsuario
	inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
	where convert(date, v.FechaRegistro) between @fechainicio and @fechafin

end

/*
exec sp_ReporteVentas '10/11/2023', '18/11/2023'
exec sp_ReporteVentas '12/11/2023', '18/11/2023'
*/
