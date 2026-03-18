using System.ComponentModel.Design;

int opcion = 0;
int totalEvaluados = 0;
int totalPublicados = 0;
int totalRechazados = 0;
int totalEnRevision = 0;
int totalConAjustes = 0;
int impactoAltocontador = 0;
int impactoMediocontador = 0;
int impactoBajocontador = 0;
void mostrarbienvenida()
{
    Console.WriteLine();
    Console.WriteLine("-_-_-_-_-_-_-_-_ SIMULADOR DE DECISIONES PARA PLATAFORMA DE STREAMING -_-_-_-_-_-_-_-_");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_- Universidad Rafael Landívar -_-_-_-_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_- Identidad Jesuita en Guatemala -_-_-_-_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine();
}
void Mostrarmenu()
{
    Console.WriteLine("-_-_-_-_-_-_-_-_-_ Menú -_-_-_-_-_-_-_-_");
    Console.WriteLine("1. Evaluar nuevo contenido.");
    Console.WriteLine("2. Mostrar reglas del sistema.");
    Console.WriteLine("3. Mostrar estadísticas de la sesión.");
    Console.WriteLine("4. Reiniciar estadísticas.");
    Console.WriteLine("5. Salir");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine();
    Console.Write("Por favor, ingrese una de las siguientes opciones del menú: ");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
void reglas()
{
    Console.WriteLine("-_-_-_-_-_-_-_-_-_- Reglas de clasificación _-_-_-_-_-_-_-_-_-_");
    Console.WriteLine();
    Console.WriteLine("-_-_Reglas de clasificación y horario_-_-");
    Console.WriteLine("* Todo público: cualquier hora *");
    Console.WriteLine("* +13: entre 6 y 22 horas *");
    Console.WriteLine("* +18: entre 22 y 5 horas *");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
    Console.WriteLine();
    Console.WriteLine("-_-_ Reglas de duración por tipo _-_-");
    Console.WriteLine("* Pelicula: 60 - 180 minutos *");
    Console.WriteLine("* Serie: 20-90 minutos *");
    Console.WriteLine("* Documental: 30-120 minutos *");
    Console.WriteLine("* Evento en vivo: 30 - 240 minutos *");
    Console.WriteLine("-_-_-_-_-_--_-_-_-_-_--_-_-_-_-_--_-_-");
    Console.WriteLine();
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_ Reglas de producción _-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine("* Producción baja solo válida para Todo público o +13*");
    Console.WriteLine("* Producción medio o altá valida para cualqueir clasificación *");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
    Console.WriteLine();
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
    Console.WriteLine();
}
mostrarbienvenida();
void evaluarcontenido()
{
    Console.WriteLine("Por favor, ingrese el tipo de contenido que se le solicitará:");
    Console.Write("Ingrese el tipo de contenido (Película, serie, documental, evento en vivo): ");
    string tipodecontenido = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Ingrese la duración en minutos: ");
    double duracionminutos=double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Ingrese la clasificación del contenido (Todo público, +13, +18): ");
    string clasificacioncontenido= Console.ReadLine();
    Console.WriteLine();
    Console.Write("Ingrese la hora programada (0-23): ");
    int horaprogramada=int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Ingrese el nivel de producción (Bajo, medio, alto): ");
    string niveldeproduccion=Console.ReadLine();
    Console.WriteLine();
    registro( tipodecontenido, duracionminutos, clasificacioncontenido, horaprogramada, niveldeproduccion);
    Console.WriteLine();
}
void registro(string tipodecontenido, double duracionminutos, string clasificacioncontenido, int horaprogramada, string niveldeproduccion)
{
    Console.WriteLine($"Tipo de contenido: {tipodecontenido}");
    Console.WriteLine($"Duración: {duracionminutos} minutos");
    Console.WriteLine($"Clasificación: {clasificacioncontenido}");
    Console.WriteLine($"Hora programada: {horaprogramada}:00 hrs");
    Console.WriteLine($"Nivel producción: {niveldeproduccion}");
}
void estadisticas()
{
    Console.WriteLine("_-_-_-_-ESTADÍSTICAS DE LA SESIÓN_-_-_-_-");
    Console.WriteLine();
    Console.WriteLine($"Total evaluados: {totalEvaluados}");
    Console.WriteLine($"Publicados: {totalPublicados}");
    Console.WriteLine($"Rechazados: {totalRechazados}");
    Console.WriteLine($"Enviados a revisión: {totalEnRevision}");
    Console.WriteLine($"Publicados con ajustes: {totalConAjustes}");
    Console.WriteLine();
    Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
}
void ReiniciarEstadisticas()
{
    Console.WriteLine();
    Console.Write("¿Confirmar reinicio de estadísticas? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();

    if (respuesta == "s")
    {
        totalEvaluados = 0;
        totalPublicados = 0;
        totalRechazados = 0;
        totalEnRevision = 0;
        totalConAjustes = 0;
        impactoAltocontador = 0;
        impactoMediocontador = 0;
        impactoBajocontador = 0;

        Console.WriteLine("Estadísticas reiniciadas correctamente.");
    }
    else
    {
        Console.WriteLine("Reinicio cancelado.");
    }
}
bool validacionTecnica(string tipodecontenido, double duracionminutos, string clasificacioncontenido, int horaprogramada, string niveldeproduccion)
{
    bool valido = true;
    if (clasificacioncontenido=="+13")
    {
        if (horaprogramada<6 || horaprogramada>22)
        {
            valido=false;
        }
    }
    else if (clasificacioncontenido=="+18")
    {
        if (horaprogramada>5 && horaprogramada<22)
        {
            valido = false;
        }
    }

    if (tipodecontenido.ToLower() == "película" || tipodecontenido.ToLower() == "pelicula")
    {
        if (duracionminutos>=60 && duracionminutos<=180)
        {
            valido=true;
        }
        else
        {
            valido= false;
        }
    }
    else if (tipodecontenido.ToLower()=="serie")
    {
        if (duracionminutos>=20 && duracionminutos<=90)
        {
            valido=true;
        }
        else
        {
            valido= false;
        }
    }
    else if (tipodecontenido.ToLower()=="documental")
    {
        if (duracionminutos>=30 && duracionminutos<=120)
        {
            valido=true;
        }
        else
        {
            valido= false;
        }
    }
    else if(tipodecontenido.ToLower()=="evento en vivo")
    {
        if (duracionminutos>=30 && duracionminutos<=240)
        {
            valido=true;
        }
        else
        {
            valido= false;
        }

    }
    return valido;

}
do
{
Mostrarmenu();
switch (opcion)
    {
        case 1:
            evaluarcontenido();
            break;
        case 2:
            reglas();
            break;
        case 3:
            estadisticas();
            break;
        case 4:
            ReiniciarEstadisticas();
            break;
        case 5:
            Console.WriteLine("Cerrando programa..."); return;
            break;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
} while (opcion != 5);