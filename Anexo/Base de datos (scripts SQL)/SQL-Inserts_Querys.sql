/* --------------- USUARIO --------------- */
use BDD_NikeStore

select * from USUARIO

select u.IdUsuario, u.Documento, u.Nombre, u.Apellido, u.Correo, u.Clave, u.Estado, r.IdRol, r.descripcion from Usuario u
inner join ROL r on r.IdRol = u.IdRol

select IdCategoria, Descripcion, Estado from CATEGORIA

select IdProducto, codigo, nombre, p.descripcion[DescripcionProducto], c.idcategoria, c.descripcion[DescripcionCategoria], Stock, PrecioCompra, PrecioVenta from PRODUCTO p
inner join categoria c on c.IdCategoria = p.IdCategoria

select u.IdUsuario, u.Documento, u.Nombre, u.Apellido, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from USUARIO u
inner join ROL r on r.IdRol = u.IdRol

/* INSERTS DE USUARIOS:

insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (12345678, 'Nicolas', 'Gonzales', 'nico@gmail.com', '123', 1, 1)
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (87654321 , 'Carlos', 'Gómez', 'carlos.gomez@email.com', '123', 1, 1)

insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (11223344, 'Laura', 'Pérez', 'laura.perez@email.com', '123', 2, 1)
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (44332211, 'Juan', 'Sánchez', 'juan.sanchez@email.com', '123', 2, 1)

insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (01234567, 'María', 'Martínez', 'maria.martinez@email.com', '123', 3, 1)
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado)
values (76543210, 'Hernan', 'Parez', 'herpared02@email.com', '123', 3, 1)
*/

/* --------------- PRODUCTO --------------- */
select * from PRODUCTO

/* Una vez cargados todos los productos actualizar el estado de todos ellos a '1' */
UPDATE PRODUCTO set Estado = 1

/* INSERTS DE PRODUCTOS:

-- REMERAS - IdCategoria: 1 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('011', 'Remera Nike Sportswear 1', 'No necesitarás mucho para lucirte. Tiene un diseño simple y casual pero muy llamativo.', 1)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('012', 'Remera Nike Sportsfit', 'Diseño simple y casual pero muy llamativo creado con un cuello redondo, magas cortas.', 1)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('013', 'Remera Nike Swoosh League', 'Especial para todos los ambientes en lo que prefieras usarla.', 1)

-- ZAPATILLAS  - IdCategoria: 3 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('061', 'Zapatillas Nike Court Borough Low', 'Combinalas con lo que quieras, eso no es un problema, sino una ventaja.', 3)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('062', 'Zapatillas Running Nike React Pegasus', 'Diseñadas para que brindar comodidad, tracción y protección en terrenos difíciles.', 3)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('063', 'Zapatillas Nike Revolution Nature', 'Suma más y más kilómetros, aportan amortiguación y confort a cada paso que des.', 3)


-- PANTALONES  - IdCategoria: 4 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('051', 'Pantalón Nike Sportswear Sport Essentials', 'Pantalón Nike azul marino, con logo Nike rojo bordado y logos Nike amarillos estampados.', 4)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('052', 'Pantalón Nike Liverpool Fc Strike', 'Pantalón Nike de entrenamiento del Liverpool Football Club.', 4)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('053', 'Pantalón Nike Dri-FIT Challenger', 'Su diseño está pensado para que lo puedas llevar antes, durante o después de la carrera.', 4)


-- BUZOS  - IdCategoria: 5 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('021', 'Buzo Nike Dri-Fit Libero', 'Ideal a la hora de salir de tu casa en tus días de relax o lucirlo antes de un juego.', 5)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('022', 'Buzo Nike Sportswear', 'Es tu aliado ideal a la hora de salir de tu casa en tus días de relax.', 5)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('023', 'Buzo Nike Cr7 Dri-Fit', 'Cristiano Ronaldo trae alegrías y un nuevo diseño de su mano con el Buzo Nike Cr7 Dri-Fit.', 5)

-- CAMPERAS  - IdCategoria: 6 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('031', 'Campera Nike Essential Wild Run', 'Inspirada en el aire libre y en la felicidad de estar en contacto con la naturaleza.', 6)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('032', 'Campera Nike Windrunner', 'Para deportistas que necesitan estar activos y cumplir sus rutinas con comodidad y velocidad.', 6)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('033', 'Campera Nike Sportswear Essentials', 'Con su tejido Woven ligero garantiza suavidad y ventilación.', 6)

-- SHORTS  - IdCategoria: 7 --

insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('041', 'Short Nike Dri-FIT Story Knit 6.0', 'Diseñado con una tela resistente de poliéster y un estampado power para acompañarte siempre.', 7)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('042', 'Short Nike Dri-Fit Sport Clash', 'Su tela liviana y elástica está diseaña para mantenerte fresco en tu rutina de entrenamiento.', 7)
insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria)
values ('043', 'Short Nike F.C. Dri-FIT', 'Pensado para jugar por amor al deporte. Su diseño más largo, llega justo por encima de la rodilla.', 7)

*/

/* --------------- CATEGORIA --------------- */

select * from CATEGORIA

/* LOS 6 TIPOS DE CATEGORIAS:

1. Remeras (IdCategoria: 1)
2. Zapatillas (IdCategoria: 3)
3. Pantalones (IdCategoria: 4)
4. Buzos (IdCategoria: 5)
5. Camperas (IdCategoria: 6)
6. Shorts (IdCategoria: 7) 
*/

/* INSERTS DE CATEGORIA:

insert into CATEGORIA(Descripcion, Estado) 
values ('Remeras', 1)
insert into CATEGORIA(Descripcion, Estado) 
values ('Zapatillas', 1)
insert into CATEGORIA(Descripcion, Estado) 
values ('Pantalones', 1)
insert into CATEGORIA(Descripcion, Estado) 
values ('Buzos', 1)
insert into CATEGORIA(Descripcion, Estado) 
values ('Camperas', 1)
insert into CATEGORIA(Descripcion, Estado) 
values ('Shorts', 1)

*/

/* --------------- ROL --------------- */

select * from ROL

/* INSERTS DE ROL:

insert into ROL(descripcion) values ('Administrador')
insert into ROL(descripcion) values ('Empleado')
insert into ROL(descripcion) values ('Gerente')
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado) values ('30','Gerente','Rojas','@gmail.com','789',3,1)
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado) values ('20','Empleado','Romero','@gmail.com','456',2,1)
insert into USUARIO(Documento, Nombre, Apellido, Correo, Clave, IdRol, Estado) values ('101010','Admin','Perez','@gmail.com','123',1,1)
*/

/* --------------- PERMISO --------------- */

select * from PERMISO 

/*
UPDATE PERMISO set NombreMenu = 'menuProveedores'
where IdPermiso = 26
*/

select p.IdRol, p.NombreMenu from PERMISO p
inner join ROL r on r.IdRol = p.IdRol
inner join USUARIO u on u.IdRol = r.IdRol
where u.IdUsuario = 1;

/* INSERTS DE PERMISO:

insert into PERMISO(IdRol, NombreMenu) values
(1, 'menuUsuarios'),
(1, 'menuMantenedor'),
(1, 'menuVentas'),
(1, 'menuCompras'),
(1, 'menuClientes'),
(1, 'menuProveedores'),
(1, 'menuReportes'),
(1, 'menuBackup')

insert into PERMISO(IdRol, NombreMenu) values
(2, 'menuVentas'),
(2, 'menuCompras'),
(2, 'menuClientes'),
(2, 'menuProveedores'),

insert into PERMISO(IdRol, NombreMenu) values
(3, 'menuVentas'),
(3, 'menuCompras'),
(3, 'menuClientes'),
(3, 'menuReportes')
*/

/* --------------- CLIENTE --------------- */

select * from CLIENTE 

select IdCliente, Documento, Nombre, Apellido, Correo, Telefono, Estado from CLIENTE

/* Una vez cargados todos los clientes actualizar el estado de todos ellos a '1' */
UPDATE CLIENTE set Estado = 1

/* INSERTS DE CLIENTE:

insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('10000000', 'Ramon', 'Galarza', 'ramgalarza@gmail.com', '3794123')
insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('20000000', 'Maria', 'Hernandez', 'marihernandez@gmail.com', '3794456')
insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('30000000', 'Eduardo', 'Ramirez', 'eduramirez@gmail.com', '3794789')
insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('40000000', 'Romina', 'Alvarez', 'rominalvarez@gmail.com', '3794321')
insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('50000000', 'Daira', 'Fernandez', 'daifer@gmail.com', '3794654')
insert into CLIENTE(Documento, Nombre, Apellido, Correo, Telefono)
values ('60000000', 'Mateo', 'Herrera', 'materra@gmail.com', '3794987')
*/

/* --------------- PROVEEDOR --------------- */

select * from PROVEEDOR 

select IdCliente, Documento, Nombre, Apellido, Correo, Telefono, Estado from PROVEEDOR

/* Una vez cargados todos los clientes actualizar el estado de todos ellos a '1' */
UPDATE PROVEEDOR set Estado = 1

/* INSERTS DE PROVEEDOR:

insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('12345678-A', 'DeportesElite Proveedores S.A.', 'info@deporteselite.com', '+1 (555) 123-4567')
insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('87654321-B', 'GlobalSports Trading Ltda.', 'contact@globalsports.com', '+1 (555) 987-6543')
insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('13579246-C', 'FitGear Solutions S.C.', 'sales@fitgearsolutions.com', '+1 (555) 246-8139')
insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('98765432-D', 'SportFashion Distributors Inc.', 'info@sportfashiondistributors.com', '+1 (555) 654-3210')
insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('24681357-E', 'PrimeAthlete Supply Co.', 'contact@primeathlete.com', '+1 (555) 135-7924')
insert into PROVEEDOR(Documento, RazonSocial, Correo, Telefono)
values ('57381924-F', 'DynamicFit Sports Enterprises', 'sales@dynamicfit.com', '+1 (555) 819-2437')
*/

/* --------------- NEGOCIO --------------- */

select * from NEGOCIO

/* INSERT DE NEGOCIO:

insert into NEGOCIO(IdNegocio, NombreNegocio, Rut, Direccion)
values (1, 'Nike-Store', '1995123', 'Av. Libertad 3405')
*/
