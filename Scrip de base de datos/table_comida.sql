use SoftRESTAURANT
go
select * from pedidos

CREATE TABLE Comidas (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(255),
    Costo float,
    Categoria varchar(20),
    Imagen image
);
drop table comidas
SELECT * FROM Comidas