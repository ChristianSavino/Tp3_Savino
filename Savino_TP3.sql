use TP_WEB
-- Borro los productos
Delete from Productos;
-- No cambia en nada la base, solo importa los productos con los que hice el trabajo
-- Ingreso los mejores premios existentes en la vida y un cliente (en caso de que no tenga)
Insert into Productos (Titulo,Descripcion,URLImagen) Values ('Merienda con Ocelot','Puedes particar para tener una merienda con este encantador sujeto','https://i.imgur.com/0o0qwd6.gif');
Insert into Productos (Titulo,Descripcion,URLImagen) Values ('Fumar un Habano con Big Boss','El sue�o de muchos','https://i.imgur.com/ttxmHta.gif');
Insert into Productos (Titulo,Descripcion,URLImagen) Values ('Comer una hamburguesa de Miller','Es Perfecta','https://i.imgur.com/NSH2QgT.gif');
Insert into Productos (Titulo,Descripcion,URLImagen) Values ('Paseo con Quiet','Solo d�as de lluvia','https://i.imgur.com/84yLDOP.gif');
Insert into Clientes (Nombre,DNI,Apellido,Email,Direccion,Ciudad,CodigoPostal,FechaRegistro) Values ('Roberto',40834656,'Planta','robertoplanta@gmail.com','Gran Tronco 2251','Milanesa','1614',GETDATE());

-- Selects para revisar
Select * from Productos
Select * from Vouchers
select * from Clientes