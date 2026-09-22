# Sistema de Gestión de Soporte Académico

## Descripción del Proyecto
Este proyecto es una aplicación de consola desarrollada en **C# (.NET 8)** para la gestión y priorización automática de solicitudes de soporte técnico y académico en una institución educativa. Permite registrar estudiantes, validar sus datos en tiempo real, asignar niveles de prioridad (ALTA, MEDIA, BAJA) de acuerdo con el tipo de consulta e imprimir fichas de resumen estructuradas.

---

## Autor
* **Nombre:** Jaime Mauricio Arias Villanueva
* **Curso:** Fundamentos de Programación / Git y GitHub
* **Institución:** Universidad Privada del Norte (UPN)

---

## Funcionalidades Principales
1. **Menú interactivo de consola:** Opciones para registrar, listar y salir del sistema.
2. **Validación estricta de entradas:**
   - Código de estudiante (mínimo 6 caracteres).
   - Nombre de estudiante (mínimo 2 caracteres).
   - Categoría de consulta (matrícula, pagos, constancia, plataforma, otro).
3. **Clasificación automática de prioridad:**
   - **ALTA:** Matrícula y Pagos.
   - **MEDIA:** Plataforma y Constancias.
   - **BAJA:** Otras consultas.
4. **Almacenamiento temporal:** Uso de arreglos unidimensionales (`string[]`) para gestionar hasta 10 solicitudes por sesión.

---

## Estructura del Código
El código está estructurado de forma modular con funciones de apoyo:
- `ValidarTexto()`: Verifica longitudes mínimas y cadenas no vacías.
- `ValidarTipo()`: Comprueba que el tipo de consulta pertenezca a la lista autorizada.
- `ObtenerPrioridad()`: Retorna el nivel de atención según la categoría.
- `MostrarMenu()` y `MostrarResumen()`: Funciones tipo `void` para la interfaz de usuario.

---
