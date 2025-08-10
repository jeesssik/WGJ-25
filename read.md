# Bitácora de Desarrollo - Proyecto Unity

Este documento sirve como registro del progreso, decisiones, problemas y soluciones durante el desarrollo del proyecto Unity.

---

## Información General

- **Nombre del Proyecto:** My Project
- **Plataforma:** Unity
- **Versión de Unity:** *(Especificar la versión utilizada, por ejemplo, 2021.3.5f1)*
- **Lenguaje Principal:** C#
- **Repositorio:** *(Agregar enlace al repositorio si aplica)*

---

## Estructura del Proyecto

El proyecto sigue la estructura estándar de Unity, con carpetas como `Assets`, `Library`, `Packages`, y `ProjectSettings`. A continuación, se destacan algunos puntos importantes:

- **Assets:** Contiene los recursos del juego, como modelos, texturas, escenas y scripts.
- **Packages:** Incluye dependencias externas, como `com.unity.burst`, `com.unity.mathematics`, y otros paquetes relevantes.
- **.vscode:** Configuración para Visual Studio Code, incluyendo el archivo `settings.json` que define exclusiones de búsqueda.

---

## Registro de Desarrollo

### Día 1: Configuración Inicial
- **Tareas Realizadas:**
  - Configuración del entorno de desarrollo en Unity.
  - Creación del repositorio y configuración del archivo `.gitignore` basado en [Unity.gitignore](https://github.com/github/gitignore/blob/main/Unity.gitignore).
  - Instalación de paquetes esenciales como `com.unity.2d.common`, `com.unity.burst`, y `com.unity.mathematics`.

- **Problemas Encontrados:**
  - Conflictos al importar algunos paquetes debido a versiones incompatibles.

- **Soluciones Implementadas:**
  - Actualización de los paquetes a versiones compatibles según el archivo `packages-lock.json`.

---

### Día 2: Desarrollo de Mecánicas Básicas
- **Tareas Realizadas:**
  - Creación de la escena principal en la carpeta `Assets/Scenes`.
  - Implementación de scripts básicos para el control de personajes.
  - Configuración de prefabs en `Assets/Prefabs`.

- **Problemas Encontrados:**
  - Los archivos `.meta` no se sincronizaban correctamente en el repositorio.

- **Soluciones Implementadas:**
  - Verificación de que todos los archivos `.meta` estén incluidos en el control de versiones.

---

### Día 3: Integración de Gráficos y Animaciones
- **Tareas Realizadas:**
  - Importación de modelos `.fbx` y texturas.
  - Configuración de animaciones utilizando el paquete `com.unity.modules.animation`.

- **Problemas Encontrados:**
  - Algunos modelos `.fbx` no se importaban correctamente debido a configuraciones de escala.

- **Soluciones Implementadas:**
  - Ajuste de las configuraciones de importación en Unity para corregir la escala.

---

## Próximos Pasos

- Implementar el sistema de colisiones y físicas.
- Integrar el paquete `com.unity.2d.pixel-perfect` para mejorar la calidad visual.
- Configurar pruebas automatizadas utilizando `com.unity.test-framework`.

---

## Notas Adicionales

- **Configuración de Visual Studio Code:** El archivo `.vscode/settings.json` incluye exclusiones para carpetas como `Library/`, `Temp/`, y `Logs/` para mejorar el rendimiento de búsqueda.
- **Control de Versiones:** Se recomienda verificar que los archivos `.meta` estén siempre sincronizados para evitar problemas al compartir el proyecto.

---

## Créditos

- **Desarrolladores:** *(Agregar nombres del equipo de desarrollo)*
- **Fecha de Inicio:** *(Especificar la fecha de inicio del proyecto)*