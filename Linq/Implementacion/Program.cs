/*
Explicación:
Filtrado: Se filtran los empleados mayores de 30 años 
usando .Where().

Ordenamiento: Se ordenan los empleados por edad 
utilizando .OrderBy().

Proyección: Se seleccionan los nombres en mayúsculas de los 
empleados con .Select().

Agrupamiento: Se agrupan los empleados en "Mayores de 30" y 
"Menores de 30" con .GroupBy().

Operación de agregado: Se calcula el promedio de edad de los 
empleados con .Average().

Unión de colecciones: Se unen los empleados con sus departamentos 
a través de .Join().

Selección del empleado más joven: Se selecciona el empleado 
más joven usando .OrderBy() y .First().

Conteo: Se cuenta cuántos empleados tienen más de 40 años 
utilizando .Count().
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lista de empleados (ID, Nombre, Edad)
        var empleados = new List<(int ID, string Nombre, int Edad)>
        {
            (1, "Juan", 25),
            (2, "Ana", 35),
            (3, "Pedro", 28),
            (4, "Luis", 23),
            (5, "Maria", 30),
            (6, "Sofia", 45),
            (7, "Carlos", 55)
        };

        // Lista de departamentos (ID, Departamento)
        var departamentos = new List<(int ID, string Departamento)>
        {
            (1, "Ventas"),
            (2, "Finanzas"),
            (3, "IT"),
            (4, "Recursos Humanos")
        };

        // 1. Filtrado de empleados mayores de 30 años
        var empleadosMayoresDe30 = empleados.Where(e => e.Edad > 30);
        Console.WriteLine("Empleados mayores de 30 años:");
        foreach (var empleado in empleadosMayoresDe30)
        {
            Console.WriteLine($"{empleado.Nombre} ({empleado.Edad})");
        }

        // 2. Ordenar empleados por edad
        var empleadosOrdenadosPorEdad = empleados.OrderBy(e => e.Edad);
        Console.WriteLine("\nEmpleados ordenados por edad:");
        foreach (var empleado in empleadosOrdenadosPorEdad)
        {
            Console.WriteLine($"{empleado.Nombre} ({empleado.Edad})");
        }

        // 3. Proyección: Seleccionar solo los nombres de los empleados en mayúsculas
        var nombresMayusculas = empleados.Select(e => e.Nombre.ToUpper());
        Console.WriteLine("\nNombres en mayúsculas:");
        foreach (var nombre in nombresMayusculas)
        {
            Console.WriteLine(nombre);
        }

        // 4. Agrupar empleados por si son mayores o menores de 30 años
        var agrupadosPorEdad = empleados.GroupBy(e => e.Edad > 30 ? "Mayores de 30" : "Menores de 30");
        Console.WriteLine("\nAgrupados por edad:");
        foreach (var grupo in agrupadosPorEdad)
        {
            Console.WriteLine($"{grupo.Key}:");
            foreach (var empleado in grupo)
            {
                Console.WriteLine($"  {empleado.Nombre} ({empleado.Edad})");
            }
        }

        // 5. Operación de agregado: Obtener el promedio de edad de los empleados
        var edadPromedio = empleados.Average(e => e.Edad);
        Console.WriteLine($"\nEdad promedio de los empleados: {edadPromedio}");

        // 6. Unión: Asignar departamentos a los empleados (por ID)
        var empleadosConDepartamentos = empleados.Join(departamentos,
            emp => emp.ID,
            dep => dep.ID,
            (emp, dep) => new { emp.Nombre, emp.Edad, dep.Departamento });

        Console.WriteLine("\nEmpleados con sus departamentos:");
        foreach (var item in empleadosConDepartamentos)
        {
            Console.WriteLine($"{item.Nombre} ({item.Edad}) - {item.Departamento}");
        }

        // 7. Encontrar el empleado más joven
        var empleadoMasJoven = empleados.OrderBy(e => e.Edad).First();
        Console.WriteLine($"\nEl empleado más joven es {empleadoMasJoven.Nombre} con {empleadoMasJoven.Edad} años.");

        // 8. Conteo de empleados mayores de 40 años
        var empleadosMayoresDe40 = empleados.Count(e => e.Edad > 40);
        Console.WriteLine($"\nNúmero de empleados mayores de 40 años: {empleadosMayoresDe40}");
    }
}
