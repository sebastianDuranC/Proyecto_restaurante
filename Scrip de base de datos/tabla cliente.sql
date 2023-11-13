use softrestaurant
go
create table pedido(
id_pedido int prymary key not null,
nombre varchar(50) not null,
qty int not null,
precio float not null,
)
create table Cliente(
id_cliente int primary key identity not null,
Nit int not null,
Nombre varchar(50),
Fecha_Registro date
);

INSERT INTO Cliente (Nit, Nombre, Fecha_Registro)
VALUES (10716511, 'Fabio Andres Zambrana', '2023-10-11 ');

INSERT INTO Cliente 
VALUES (32345872, 'Aniceto Andres Zambrana', '2023-10-31 ');

select* from cliente 
select * from pedidos
INSERT INTO Cliente (Nit, Nombre, Fecha_Registro)
VALUES (10716511, 'Fabio Andres Zambrana', GETDATE());


--agrego atributo fecha de registro en la tabla cliente
ALTER TABLE Cliente
ALTER COLUMN Fecha_Registro DATETime;

select Nombre from cliente where Nit=10716511 

--agrego el atributo id_cliente para poder relacionarlos
ALTER TABLE pedidos
ADD id_cliente int 

-- Crear la relación

 ALTER TABLE pedidos
ADD CONSTRAINT FK_Pedido_Cliente
FOREIGN KEY (id_cliente)
REFERENCES Cliente(id_cliente);
