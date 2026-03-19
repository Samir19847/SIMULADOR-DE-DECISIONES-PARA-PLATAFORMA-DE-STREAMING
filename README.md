StreamDash 1,984 — Simulador de Decisiones para Plataforma de Streaming

🧠Descripción del sistema

StreamDash es un sistema de consola desarrollado en C# que simula el proceso de toma de decisiones en una plataforma de streaming. 
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
*Validación técnica completa (reglas obligatorias). 
*Clasificación de impacto (Bajo, Medio, Alto). 
*Sistema de decisiones automatizado. 
*Control de errores en entrada de datos (TryParse). 
*Estadísticas dinámicas de la sesión. 
*Identificación de impacto predominante. 
*Cálculo de porcentaje de aprobación.

🖥️ Ejecución Requisitos: 
.NET SDK 6.0 o superior.

PASOS:

-Clonar repositorio.
git clone https://github.com/Samir19847/SIMULADOR-DE-DECISIONES-PARA-PLATAFORMA-DE-STREAMING.git

-Entrar a la carpeta principal del proyecto. 
cd SIMULADOR-DE-DECISIONES-PARA-PLATAFORMA-DE-STREAMING-master

-Entrar a la carpeta del proyecto. 
cd "SIMULADOR DE DECISIONES PARA PLATAFORMA DE STREAMING"
Ejecutar dotnet run.

🧩 Lógica del sistema

El flujo del sistema sigue tres etapas principales: 
-Validación técnica. 
-Verifica cumplimiento de reglas obligatorias. 
-Si falla → Rechazado inmediato.

Clasificación de impacto: 
Bajo / Medio / Alto.
Decisión final: Alto → En revisión.
Medio/Bajo → Publicado.

📊 Estadísticas El sistema registra: 
-Total evaluados. 
-Publicados. 
-Rechazados. 
-En revisión.
-Publicados con ajustes.
-Impacto predominante. 
-Porcentaje de aprobación.

💡 Nota: 
Durante el desarrollo se enfrentaron varios retos relacionados con la validación de datos, especialmente en el manejo de entradas del usuario y condiciones lógicas.
Se implementaron soluciones como el uso de "TryParse" y normalización de strings para evitar errores en tiempo de ejecución.
