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
  - Creación del repositorio y configuración del archivo `.gitignore` 
. **Ataque a distancia (`isRanged`)**:
   - Ahora se puede realizar tanto con la tecla `K` como con el clic izquierdo del mouse.
2. **Corrección en la animación de rodar (`isRolling`)**:
   - La animación de rodar ahora se activa inmediatamente al presionar la tecla `L`.
3. **Mejoras en el manejo de ataques**:
   - Se agregó soporte para detectar entradas del mouse para ataques cuerpo a cuerpo y a distancia.
---

## Asignaciones de Movimiento

A continuación, se detalla el cuadro de asignaciones para las acciones del personaje:

| **Acción**                | **Tecla(s) principal(es)** | **Alternativa(s) / Opcional** |
|---------------------------|----------------------------|--------------------------------|
| Mover izquierda           | A                        | Flecha izquierda              |
| Mover derecha             | D                        | Flecha derecha                |
| Saltar                    | W / Barra espaciadora    | Flecha arriba                 |
| Agacharse / Deslizar      | S                        | Flecha abajo                  |
| Correr                    | Left Shift               | Right Shift                   |
| Atacar cuerpo a cuerpo    | J                        | Mouse botón izquierdo         |
| Atacar a distancia        | K                        | Mouse botón derecho           |
—                  |
| Trepar / Escalar          | W (cerca de escalera)    | Flecha arriba                 |
| Empujar                   | E                        | —                              |
| Rodar / Esquivar          | L                        | —                              |
| Especial                  |                          | —                              |


---





---

## Créditos

- **Desarrolladores:** *(Agregar nombres del equipo de desarrollo)*
- **Fecha de Inicio:** *(Especificar la fecha de inicio del proyecto)*