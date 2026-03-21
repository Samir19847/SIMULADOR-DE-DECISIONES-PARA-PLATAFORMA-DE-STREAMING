StreamDash 1,984 — Simulador de Decisiones para Plataforma de Streaming

🧠Descripción del sistema

StreamDash 1,984 es un sistema de consola desarrollado en C# que simula el proceso de toma de decisiones en una plataforma de streaming. 
El sistema evalúa contenido en base a: 
-Tipo de contenido. 
-Duración. 
-Clasificación. 
-Horario de emisión. 
-Nivel de producción.

A partir de estas variables, el sistema determina automáticamente: 
✅ Publicar. 
⚠️ Enviar a revisión. 
❌ Rechazar.

Además, mantiene estadísticas en tiempo real y genera un resumen final al finalizar la sesión.

Características principales: 
-Validación técnica completa (reglas obligatorias). 
-Clasificación de impacto (Bajo, Medio, Alto). 
-Sistema de decisiones automatizado. 
-Control de errores en entrada de datos (TryParse). 
-Estadísticas dinámicas de la sesión. 
-Identificación de impacto predominante. 
-Cálculo de porcentaje de aprobación.

🖥️ Ejecución 
Requisitos: 
-.NET SDK 6.0 o superior.
-Conexión a internet para descargar el repositorio desde GitHub.

PASOS PARA EJECUTARLO:
-Verificar instalación de .NET
* Abrir la terminal correspondiente a tu sistema operativo:

Windows:
Opción 1: Presionar la tecla con el logo de Windows + R, escribir cmd y presionar Enter.
Opción 2: Buscar "Símbolo del sistema"/"CMD" en el menú Inicio.

macOS:
Opción 1: Abrir Spotlight con Cmd + Espacio, esscribir terminal y presionar Enter.
Opción 2: Ir a Aplicaciones > Utilidades > Terminal.

Linux:
Opción 1: Presionar Ctrl + Alt + T.
Opción 2: Buscar "Terminal" en tu menú de aplicaciones.
Opción 3: Hacer click derecho en el escritorio y seleccionar "Abrir terminal aquí"

* Escribir:
dotnet --version
Si aparece un número como 6.0.x, ya está instalado. Si da error, descárgalo gratis en dotnet.microsoft.com.

-Descargar el programa.
* Entrar al repositorio de GitHub: 
github.com/Samir19847/SIMULADOR-DE-DECISIONES-PARA-PLATAFORMA-DE-STREAMING y hacer click en el botón verde que dice "Code"
* Seleccionar "Download ZIP".
* Descomprimir la carpeta donde se quiera.

-Entrar a la carpeta principal del proyecto.
* Abrir la carpeta descomprimida.
* Entrar a la carpeta "SIMULADOR DE DECISIONES PARA PLATAFORMA DE STREAMING".

-Copiar la ruta de la carpeta del proyecto.  
* Hacer click en la barra de direcciones del explorador de archivos.
(La barra donde aparece el nombre de la carpeta, en la parte superior de la ventana).
* Copia la dirección completa con la combinación de letras: Ctrl + C.


-Entrar en la ruta de la carpeta en la terminar. 
* Pegar la dirección de la carpeta en la terminal correspondiente a tu sistema operativo con el comando: cd
* Colocar la ruta de la carpeta que se copió.

-Ejecutar el programa.
* Ejecutar el dicho programa con el comando: dotnet run
* Presionar Enter.

🧩 Lógica del sistema

El flujo del sistema sigue tres etapas principales: 
-Validación técnica. 
-Verifica cumplimiento de reglas obligatorias. 
-Si falla → Rechazado inmediato.

Clasificación de impacto: 
Bajo / Medio / Alto.
Decisión final: Alto → En revisión.
Medio/Bajo → Publicado.

📊 Estadísticas que el sistema registra: 
-Total evaluados. 
-Publicados. 
-Rechazados. 
-En revisión.
-Publicados con ajustes.
-Impacto predominante. 
-Porcentaje de aprobación.

💡 Manejo de errores

El sistema incluye validaciones para evitar errores en la entrada de datos del usuario, utilizando herramientas como "TryParse" y normalización de texto.
