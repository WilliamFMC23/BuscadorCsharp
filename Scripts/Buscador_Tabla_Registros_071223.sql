create database GOFF;
use GOFF;
create table clientes(
id int primary key identity(1,1),
nombre varchar(30),
edad int
)



DECLARE @num INT = 0;

WHILE @num < 1000
BEGIN
INSERT INTO clientes(nombre, edad)
VALUES
    ('Juan P�rez', 25),
    ('Mar�a Garc�a', 30),
    ('Carlos Rodr�guez', 22),
    ('Laura Mart�nez', 28),
    ('Jos� Gonz�lez', 35),
    ('Ana L�pez', 27),
    ('Pedro S�nchez', 40),
    ('Isabel Ram�rez', 32),
    ('Francisco D�az', 26),
    ('Elena Castro', 21),
    ('Miguel Fern�ndez', 45),
    ('Luis Torres', 33),
    ('Carmen Ruiz', 29),
    ('Ra�l Herrera', 38),
    ('Sof�a Medina', 24),
    ('Diego Vargas', 31),
    ('Victoria Morales', 37),
    ('Javier Jim�nez', 23),
    ('Luc�a Flores', 36),
    ('�ngel Silva', 39),
    ('Patricia Herrera', 34),
    ('Rub�n Mendoza', 42),
    ('Valeria G�mez', 28),
    ('Daniel Ortega', 41),
    ('Adriana N��ez', 33),
    ('Alejandro Castillo', 29),
    ('Silvia Aguilar', 44),
    ('Hugo Miranda', 26),
    ('Gabriela Cruz', 35),
    ('Ricardo R�os', 30),
    ('Natalia Varela', 37),
    ('Gustavo Cordero', 28),
    ('Olga Montes', 43),
    ('Fernando Herrera', 32),
    ('Emma Salazar', 27),
    ('Jorge Medina', 39),
    ('Marina Soto', 31),
    ('Mart�n Rojas', 34),
    ('Lorena Paredes', 40),
    ('Renata Torres', 29),
    ('Mart�n L�pez', 37),
    ('Gabriela Ram�rez', 31),
    ('Andr�s Castro', 25),
    ('Isabella Rodr�guez', 33),
    ('Diego S�nchez', 28),
    ('Valentina D�az', 35),
    ('Emilio G�mez', 30),
    ('Camila Mendoza', 26),
    ('Joaqu�n Vargas', 42),
    ('Ana Sof�a Garc�a', 36),
    ('David P�rez', 27),
    ('Renzo Herrera', 39),
    ('Juliana Medina', 24),
    ('Mateo Ruiz', 32),
    ('Regina Jim�nez', 38),
    ('Alejandro N��ez', 41),
    ('Luna Silva', 23),
    ('H�ctor Morales', 40),
    ('Valeria Salazar', 34),
    ('Gael Cruz', 31),
    ('Ren� Aguilar', 37),
    ('Mariana Rojas', 29),
    ('Axel Paredes', 44),
    ('Eva Montes', 28),
    ('Sebasti�n Ortega', 35),
    ('Luciana Torres', 30),
    ('Santiago Mendoza', 33),
    ('Alicia Soto', 39),
    ('Federico Varela', 26),
    ('Natalie Cordero', 43),
    ('Sim�n Castillo', 32),
    ('Isabel Miranda', 27),
    ('Felipe N��ez', 38),
    ('Catalina Rojas', 25),
    ('Le�n Jim�nez', 34),
    ('Abril Herrera', 40),
    ('Maximiliano Ram�rez', 36),
    ('Daniela P�rez', 29),
    ('Hugo Medina', 37);
    SET @num = @num + 1;
END;

