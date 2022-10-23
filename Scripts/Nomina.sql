CREATE TABLE Periodicidad (
	Id int not null,
	Nombre varchar(100) not null,
	Constraint PK_Periodicidad_Id Primary Key CLUSTERED (Id)
);

Insert into Periodicidad (Id,Nombre) values (1,'SEMANAL')

CREATE TABLE Usuarios (
	Usuario varchar(15) not null,
	Password varchar(15) not null,
	Tipo tinyint not null
	Constraint PK_Usuarios Primary Key CLUSTERED (Usuario)
);

Insert into Usuarios (Usuario,Password,Tipo) values ('admin', 123456, 0)

CREATE TABLE Empleado (
	Id int not null,
	Nombre varchar(200) not null,
	Periodicidad int not null,
	Baja tinyint not null,
	FechaIngreso date null,
	IMSS varchar(12) null,
	Direccion varchar(80) null,
	Constraint PK_Empleado_Id Primary Key CLUSTERED (Id),
	Constraint FK_Periodicidad_Id Foreign Key (Periodicidad) References Periodicidad (Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

--ALTER TABLE Empleado Add Baja tinyint not null
--ALTER TABLE Empleado Add FechaIngreso date null
--ALTER TABLE Empleado Add IMSS varchar(12) null
--ALTER TABLE Empleado Add Direccion varchar(80) null

CREATE TABLE Prestamos (
	Id int not null,
	FechaI datetime not null,
	Monto float not null,
	Saldo float not null,
	Empleado int not null,
	Constraint PK_Prestamos_Id Primary Key CLUSTERED (Id),
	Constraint FK_Empleado_Id Foreign Key (Empleado) References Empleado (Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Nomina (
	Id int not null,
	Empleado int not null,
	Sueldo float not null,
	Constraint PK_Nomina_Id Primary Key CLUSTERED (Id),
	Constraint FK_Empleado_Nomina Foreign Key (Empleado) References Empleado (Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE
);

CREATE TABLE NominaDetalle (
	Id int not null,
	Nomina int not null,
	Fecha datetime not null,
	DiaExtra float null,
	Adelantado float null,
	Prestamo float null,
	Incentivo float null,
	Faltas int null,
	Vacaciones float null,
	Aguinaldo float null,
	Constraint PK_Nomina_Detalle Primary Key CLUSTERED (Id),
	Constraint FK_Nomina_NominaD Foreign Key (Nomina) References Nomina (Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE 
);

--ALTER TABLE NominaDetalle Add Faltas int null
--ALTER TABLE NominaDetalle Add Vacaciones float null
--ALTER TABLE NominaDetalle Add Aguinaldo float null
