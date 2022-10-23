INSERT [dbo].[Material] ([Id], [Nombre], [Descripcion]) VALUES (1, N'FIERRO', N'FIERRO 50 MTS')
GO
INSERT [dbo].[Inventario] ([Id], [IdMaterial], [FechaEntrada], [FechaSalida]) VALUES (1, 1, CAST(N'2021-02-18T00:00:00.000' AS DateTime), CAST(N'2021-02-18T00:00:00.000' AS DateTime))
GO
