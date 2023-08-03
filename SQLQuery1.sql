--HELPERS

select * from TIPOSEDICION

select * from DISCOS

select * from ESTILOS

----------------------------------------------------------------------------------------------------------------------------


--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
 

select D.Titulo, D.FechaLanzamiento, E.Descripcion as Estilos from DISCOS D, ESTILOS E where D.IdEstilo = E.Id


----------------------------------------------------------------------------------------------------------------------------


--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

insert into ESTILOS values ('Trash metal')
insert into ESTILOS values('Heavy metal')
insert into TIPOSEDICION values ('Descarga digital')


----------------------------------------------------------------------------------------------------------------------------


--3. Insertar al menos dos discos nuevos cargando correctamente su información.

insert into DISCOS values ('Rust in peace', '1990-09-24,9','https://cdns-images.dzcdn.net/images/cover/e72c97303ec864bff2ce9059ff030c61/500x500.jpg',4,4)
insert into DISCOS values('Seasons in the abyss','1990-10-09,11','https://i.ytimg.com/vi/eQpvqPuDJWI/maxresdefault.jpg',5,1)


----------------------------------------------------------------------------------------------------------------------------


--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.


update DISCOS set CantidadCanciones=11 ,FechaLanzamiento='1990-10-09' where Id=4 



----------------------------------------------------------------------------------------------------------------------------


--5. Borrar un disco a elección.


delete from DISCOS where id=3


----------------------------------------------------------------------------------------------------------------------------


--6. Traer todos los estilos que estén asociados a algún disco.

select E.Descripcion as Estilo from ESTILOS E, DISCOS D
where D.IdEstilo=E.Id
select * from ESTILOS

----------------------------------------------------------------------------------------------------------------------------


--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).


select D.Titulo as Nombre, E.Descripcion as Estilo, T.Descripcion Edición from DISCOS D,ESTILOS E,TIPOSEDICION T
where D.IdEstilo=E.id AND D.IdTipoEdicion=T.Id


----------------------------------------------------------------------------------------------------------------------------


--8. Traer todos los discos que contengan en su nombre la sílaba "ho".
--Tuve que consular con juan carlos Chat GPT

select * from DISCOS
where DISCOS.Titulo like '%ho%'
