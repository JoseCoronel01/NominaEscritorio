INSERT [dbo].[Periodicidad] ([Id], [Nombre]) VALUES (1, N'SEMANAL')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (1, N'CARLOS JESUS PEREZ VALENZUELA', 1, 0, CAST(N'2015-06-15' AS Date), N'23816439428', N'Calle Sonora Num. 2037, Col. Estrella')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (2, N'ANGEL DANIEL LEYVA PALOMARES', 1, 0, CAST(N'2016-10-10' AS Date), N'2383651716', N'Calle Angostura 1797, Col. 28 de junio')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (3, N'DAVID DIAZ CRUZ', 1, 0, CAST(N'2016-11-07' AS Date), N'78998307090', N'C. Rio Santa Catalina 2857 Fracc Huertas')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (4, N'JULIAN HUMBERTO VERDUGO RUIZ', 1, 0, CAST(N'2016-10-10' AS Date), N'23967917990', N'Av. Orquidea 2116 Fracc Santa Luz')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (5, N'JAVIER CAMACHO LARA', 1, 0, CAST(N'2018-04-23' AS Date), N'23947713402', N'')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (6, N'JOSE ANGEL MORALES FELIX', 1, 0, CAST(N'2020-06-22' AS Date), N'23967825623', N'CALLEJON JUAN ESCUTIA 1465OTE COL LAZARO CARDENAS CP 81256')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (7, N'HECTOR ISRAEL VARGAS LUNA', 1, 0, CAST(N'2016-09-19' AS Date), N'23927526519', N'')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (8, N'ANGEL ALFONSO VELAZQUEZ', 1, 0, CAST(N'2018-11-12' AS Date), N'', N'SERAPIO RENDON 302')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (9, N'JOSE DANIEL LEYVA LIZARRAGA', 1, 0, CAST(N'2019-02-11' AS Date), N'23058925514', N'Calle Angostura 1797, Col. 28 de junio')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (10, N'ANTONIO ESPINOZA QUIÑONEZ', 1, 0, CAST(N'2019-03-04' AS Date), N'23916943956', N'CALLE MANUEL A CAMACHO 827 COL MORELOS')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (11, N'ADRIAN VALENCIA LOPEZ', 1, 0, CAST(N'2020-01-13' AS Date), N'23916943956', N'CALLE SALVADOR ALVARADO 1751 COL 28 DE JUNIO')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (12, N'ANGEL ALEJANDRO ESCALANTE APODACA', 1, 0, CAST(N'2019-09-09' AS Date), N'46149611645', N'PARAISO 2315 FRACC ALAMOS COUNTRY CP 81271')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (13, N'ISMAEL JURADO TALAMANTES', 1, 0, CAST(N'2020-06-15' AS Date), N'23998084968', N'CALLE CHOIX JUAN JOSE RIOS POSTE 226')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (14, N'DAMIAN SALVADOR HERNANDEZ FALOMIR', 1, 0, CAST(N'2020-11-02' AS Date), N'', N'')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (15, N'FRANCISCO VEGA GIL', 1, 0, CAST(N'2021-01-18' AS Date), N'', N'')
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [Periodicidad], [Baja], [FechaIngreso], [IMSS], [Direccion]) VALUES (16, N'MARIO ALBERTO FLORES MEZA', 1, 0, CAST(N'2020-09-28' AS Date), N'', N'')
GO
INSERT [dbo].[Prestamos] ([Id], [FechaI], [Monto], [Saldo], [Empleado]) VALUES (1, CAST(N'2021-01-30T18:20:48.597' AS DateTime), 15667, 15267, 1)
GO
INSERT [dbo].[Prestamos] ([Id], [FechaI], [Monto], [Saldo], [Empleado]) VALUES (2, CAST(N'2021-01-30T18:34:37.947' AS DateTime), 7013, 7013, 2)
GO
INSERT [dbo].[Prestamos] ([Id], [FechaI], [Monto], [Saldo], [Empleado]) VALUES (3, CAST(N'2021-01-30T18:35:02.233' AS DateTime), 3585, 3585, 3)
GO
INSERT [dbo].[Prestamos] ([Id], [FechaI], [Monto], [Saldo], [Empleado]) VALUES (4, CAST(N'2021-01-30T18:35:14.747' AS DateTime), 740, 740, 4)
GO
INSERT [dbo].[Prestamos] ([Id], [FechaI], [Monto], [Saldo], [Empleado]) VALUES (5, CAST(N'2021-01-30T18:35:24.770' AS DateTime), 245, 245, 5)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (1, 1, 2500)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (2, 2, 2500)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (3, 3, 2200)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (4, 4, 1400)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (5, 5, 1700)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (6, 6, 2200)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (7, 7, 1900)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (8, 8, 700)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (9, 9, 2200)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (10, 10, 2000)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (11, 11, 2300)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (12, 12, 1900)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (13, 13, 1700)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (14, 14, 2000)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (15, 15, 1800)
GO
INSERT [dbo].[Nomina] ([Id], [Empleado], [Sueldo]) VALUES (16, 16, 1400)
GO
INSERT [dbo].[NominaDetalle] ([Id], [Nomina], [Fecha], [DiaExtra], [Adelantado], [Prestamo], [Incentivo], [Faltas], [Vacaciones], [Aguinaldo]) VALUES (3, 2, CAST(N'2021-01-30T00:00:00.000' AS DateTime), 0, 600, 200, 500, 0, 0, 0)
GO
INSERT [dbo].[NominaDetalle] ([Id], [Nomina], [Fecha], [DiaExtra], [Adelantado], [Prestamo], [Incentivo], [Faltas], [Vacaciones], [Aguinaldo]) VALUES (4, 1, CAST(N'2021-02-06T00:00:00.000' AS DateTime), 800, 200, 400, 100, 0, 0, 0)
GO
INSERT [dbo].[Usuarios] ([Usuario], [Password], [Tipo]) VALUES (N'admin', N'123456', 0)
GO
