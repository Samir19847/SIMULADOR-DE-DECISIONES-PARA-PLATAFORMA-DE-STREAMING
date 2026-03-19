int opcion;
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
    Console.WriteLine("-_-_-_-_-_-_-_-_ SIMULADOR DE DECISIONES PARA PLATAFORMA DE STREAMING -_-_-_-_-_-_-_-_-");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_ Evaluación, Validación y Publicación de Contenido -_-_-_-_-_-_-_-_-_");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_    Donde el contenido se convierte en impacto -_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine("                              Samir corp || StreamDash 1,984                       ");
    Console.WriteLine();

    Console.WriteLine();
}
void Mostrarmenu()
{
    Console.WriteLine("-_-_-_-_-_-_-_-_-_ Menú -_-_-_-_-_-_-_-_");
    Console.WriteLine("1. Evaluar nuevo contenido.");
    Console.WriteLine("2. Mostrar reglas del sistema.");
    Console.WriteLine("3. Mostrar estadísticas de la sesión.");
    Console.WriteLine("4. Reiniciar estadísticas.");
    Console.WriteLine("5. Salir.");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine();
    Console.Write("Por favor, ingrese una de las siguientes opciones del menú: ");
    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
    {
        Console.Write("Ingrese una opción válida (1-5): ");
    }
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
    while (tipodecontenido.ToLower()!="película" && tipodecontenido.ToLower() != "pelicula" && tipodecontenido.ToLower() != "serie" && tipodecontenido.ToLower() != "documental" && tipodecontenido.ToLower() !="evemtp em vivo")
    {
        Console.Write("Ingrese un tipo de contenido válido (Película, serie, documental, evento en vivo): ");
        tipodecontenido = Console.ReadLine();
    }
    Console.WriteLine();
    Console.Write("Ingrese la duración en minutos: ");
    double duracionminutos;
    while (!double.TryParse(Console.ReadLine(), out duracionminutos) || duracionminutos <= 0)
    {
        Console.Write("Ingrese una duración válida: ");
    }
    Console.WriteLine();
    Console.Write("Ingrese la clasificación del contenido (Todo público, +13, +18): ");
    string clasificacioncontenido= Console.ReadLine();
    while (clasificacioncontenido.ToLower() !="+13" && clasificacioncontenido.ToLower() !="+18"&&clasificacioncontenido.ToLower() !="todo publico"&& clasificacioncontenido.ToLower()!="todo público")
    {
        Console.Write("Ingrese una clasificación válida (Todo público, +13, +18): ");
        clasificacioncontenido = Console.ReadLine();
    }
    Console.WriteLine();
    Console.Write("Ingrese la hora programada (0-23): ");
    int horaprogramada;
    while (!int.TryParse(Console.ReadLine(), out horaprogramada) || horaprogramada < 0 || horaprogramada > 23)
    {
        Console.Write("Ingrese una hora válida (0-23): ");
    }
    Console.WriteLine();
    Console.Write("Ingrese el nivel de producción (Bajo, medio, alto): ");
    string niveldeproduccion=Console.ReadLine();
    while (niveldeproduccion.ToLower() != "bajo" && niveldeproduccion.ToLower() != "medio" && niveldeproduccion.ToLower() != "alto")
    {
        Console.Write("Ingrese un nivel válido (bajo, medio, alto): ");
        niveldeproduccion = Console.ReadLine();
    }
    Console.WriteLine();
    registro(tipodecontenido, duracionminutos, clasificacioncontenido, horaprogramada, niveldeproduccion);
    Console.WriteLine();
    Console.WriteLine("A continuación verá la decisión final según los resultados de su evaluación de contenido:");
    decisionFinal(tipodecontenido, duracionminutos, clasificacioncontenido, horaprogramada, niveldeproduccion);
Console.WriteLine();
}
void registro(string tipodecontenido, double duracionminutos, string clasificacioncontenido, int horaprogramada, string niveldeproduccion)
{
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_ CONTENIDO REGISTRADO -_-_-_-_-_-_-_-_-_-_-_");
    Console.WriteLine($"Tipo de contenido: {tipodecontenido}");
    Console.WriteLine($"Duración: {duracionminutos} minutos");
    Console.WriteLine($"Clasificación: {clasificacioncontenido}");
    Console.WriteLine($"Hora programada: {horaprogramada}:00 hrs");
    Console.WriteLine($"Nivel producción: {niveldeproduccion}");
    Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
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
    if (impactoAltocontador>impactoBajocontador&&impactoAltocontador>impactoMediocontador)
    {
        Console.WriteLine($"Impacto predominante: Alto, con {impactoAltocontador} unidades.");
    }
    else if (impactoMediocontador>impactoBajocontador && impactoMediocontador > impactoAltocontador)
    {
        Console.WriteLine($"Impacto predominante: Medio, con {impactoMediocontador} unidades.");
    }
    else if (impactoBajocontador>impactoMediocontador && impactoBajocontador > impactoAltocontador)
    {
        Console.WriteLine($"Impacto predominante: Bajo, con {impactoBajocontador} unidades.");
    }
    double porcentaje = 0;
    if (totalEvaluados > 0)
    {
        porcentaje = (double)totalPublicados / totalEvaluados * 100;
    }
    Console.WriteLine($"Porcentaje de aprobación: {porcentaje}%");
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
    if (clasificacioncontenido == "+13")
    {
        if (horaprogramada < 6 || horaprogramada > 22)
        {
            valido = false;
        }
    }
    else if (clasificacioncontenido == "+18")
    {
        if (horaprogramada > 5 && horaprogramada < 22)
        {
            valido = false;
        }
    }

    if (tipodecontenido.ToLower() == "película" || tipodecontenido.ToLower() == "pelicula")
    {
        if (!(duracionminutos >= 60 && duracionminutos <= 180))
        {
            valido = false;
        }
    }
    else if (tipodecontenido.ToLower() == "serie")
    {
        if (!(duracionminutos >= 20 && duracionminutos <= 90))
        {
            valido = false;
        }
    }
    else if (tipodecontenido.ToLower() == "documental")
    {
        if (!(duracionminutos >= 30 && duracionminutos <= 120))
        {
            valido = false;
        }
    }
    else if (tipodecontenido.ToLower() == "evento en vivo")
    {
        if (!(duracionminutos >= 30 && duracionminutos <= 240))
        {
            valido = false;
        }
    }

    if (niveldeproduccion.ToLower() == "bajo")
    {
        if (!(clasificacioncontenido== "todo publico" || clasificacioncontenido == "todo público" || clasificacioncontenido == "+13"))
        {
            valido = false;
        }
    }
    return valido;
}
string clasificacionimpacto(string niveldeproduccion, double duracionminutos, int horaprogramada)
{
    string impacto = "Bajo";
    if (niveldeproduccion == "alto" || duracionminutos > 120 || horaprogramada >= 20 && horaprogramada <= 23)
    {
        impacto = "Alto";
    }
    else if (niveldeproduccion == "medio" || duracionminutos >= 60 && duracionminutos <= 120)
    {
        impacto = "Medio";
    }
    else if (niveldeproduccion == "bajo" && duracionminutos < 60)
    {
        impacto = "Bajo";
    }
    return impacto;
}
void decisionFinal(string tipodecontenido, double duracionminutos, string clasificacioncontenido, int horaprogramada, string niveldeproduccion)
{
    totalEvaluados++;
    bool valido=validacionTecnica(tipodecontenido, duracionminutos, clasificacioncontenido, horaprogramada, niveldeproduccion);
    if (!valido)
    {
        Console.WriteLine("Resultado: Rechazado (Incumple alguna regla obligatoria).");
        totalRechazados++; return;
    }

    string impacto = clasificacionimpacto(niveldeproduccion, duracionminutos, horaprogramada);
    Console.WriteLine($"El impacto calculado es: {impacto}");
    if (impacto == "Alto")
    {
        impactoAltocontador++;
    }
    else if (impacto == "Medio")
    {
        impactoMediocontador++;
    }
    else
    {
        impactoBajocontador++;
    }

    if (impacto=="Bajo" ||impacto=="Alto")
    {
        Console.WriteLine("Resultado: Publicado.");
        Console.WriteLine("Cumple con todas las reglas técnicas.");
        totalPublicados++;
    }
    else if (impacto=="Alto")
    {
        Console.WriteLine("Resultado: Enviar a revisión.");
        Console.WriteLine("Cumple reglas técnicas, pero requiere modificación menor.");
        totalEnRevision++;
    }
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
            Console.WriteLine("Opción inválida.");
            Console.WriteLine("Por favor, escoga una de las opciones del menú.");
            Console.WriteLine();
            break;
    }
} while (opcion != 5);