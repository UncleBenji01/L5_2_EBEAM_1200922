int ndia;
Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese el numero de dia");
ndia = Convert.ToInt32(Console.ReadLine());
if (ndia < 0)
{
    Console.WriteLine("Error: El numero a ingresar debe estar contenido 1 y 7");
}
else if (ndia > 7)
{
    Console.WriteLine(" Error: El numero a ingresar debe estar contenido 1 y 7");

}

 if (ndia == 1)
{
    Console.WriteLine(" Lunes ");
}
 if (ndia == 2)
{
    Console.WriteLine(" Martes ");
}
 if (ndia == 3)
{
    Console.WriteLine(" Miercoles ");
}
if (ndia == 4)
{
    Console.WriteLine(" Jueves ");
}
 if (ndia == 5)
{
    Console.WriteLine(" Viernes ");
}
if (ndia == 6)
{
    Console.WriteLine(" Sabado ");
}
if (ndia == 7)
{
    Console.WriteLine(" Domingo ");
}