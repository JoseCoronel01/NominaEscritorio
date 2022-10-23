select e.Nombre, (n.Sueldo + ((nd.DiaExtra + nd.Incentivo) - (nd.Adelantado + nd.Prestamo))) as Total
from Nomina n
inner join NominaDetalle nd on nd.Nomina = n.Id
left join Empleado e on e.Id = n.Empleado
where nd.Fecha = '2020-12-06'
