
int estadodeanimo;
Console.WriteLine ("escribe tu nombre");
String nombre = Console.ReadLine();
do{

Console.WriteLine ("diga su estado de animo");

Console.WriteLine( " 1. estas feliz");
Console.WriteLine( " 2. estas triste");
Console.WriteLine( " 3. estas enojado");
Console.WriteLine( " 4. estas pensativo");
Console.WriteLine( " 5. estas sorprendido");
Console.WriteLine( " 6. estas somnoliento");
Console.WriteLine( " 7. estas sañudable");
Console.WriteLine( " 8. estas enfermo");
Console.WriteLine( " 9. estas hambriento");
Console.WriteLine( " 10 estas asustado");
Console.WriteLine( " 11. salir");
 estadodeanimo = Convert.ToInt32(Console.ReadLine());
switch (estadodeanimo)
{
    case 1:
    Console.WriteLine(nombre + " estas feliz");
break;
    case 2:
    Console.WriteLine(nombre + " estas pensativo");
break;
    case 3:
    Console.WriteLine(nombre + " estas enojado");
break;
    case 4:
    Console.WriteLine(nombre + " estas pensativo");
break;
    case 5:
    Console.WriteLine(nombre + " estas sorprendido");
break;
    case 6:
    Console.WriteLine(nombre + " estas somnoliento");
break;
    case 7:
    Console.WriteLine(nombre + " estas saludable");
break;
    case 8:
    Console.WriteLine(nombre + " estas enfermo");
break;
    case 9:
    Console.WriteLine(nombre + " estas hambriento");
break;
    case 10:
    Console.WriteLine(nombre + " estas asustado");
break;
    case 11:
    Console.WriteLine(nombre + " haz salido");
break;

} 

}while( estadodeanimo!= 11);
 






