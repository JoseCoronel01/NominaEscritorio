--CREATE DATABASE Inventario
USE Inventario

CREATE TABLE Material (
	Id int not null,
	Nombre varchar(150) not null,
	Descripcion varchar(500) not null,
	CONSTRAINT PK_Material_Id PRIMARY KEY CLUSTERED (Id)
)

CREATE TABLE Inventario (
	Id int not null,
	IdMaterial int not null,
	FechaEntrada datetime not null,
	FechaSalida datetime null,
	CONSTRAINT PK_Inventario_Id PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Inventario_Material_Id FOREIGN KEY (IdMaterial) REFERENCES Material (Id)
	ON UPDATE CASCADE 
	ON DELETE CASCADE 
)

