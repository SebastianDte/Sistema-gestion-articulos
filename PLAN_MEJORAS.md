# Plan de Modernización y Escalabilidad: Sistema de Gestión de Artículos e Inventario (.NET WinForms)

Este documento detalla el plan integral de refactorización, modernización y agregado de funcionalidades para transformar el proyecto en un **software comercial de gestión de inventario y artículos**, apto para ferreterías, casas de repuestos, bazares o cualquier comercio minorista/mayorista.

---

## 🎯 Objetivos Principales
1. **Comercializable / Portfolio Senior:** Llevar la aplicación de un estado académico (TP de cursada) a un producto real, robusto y profesional.
2. **Universalidad de Negocio:** Incorporar la gestión de **Stock e Inventario Crítico** para que sea aplicable a cualquier rubro.
3. **Experiencia de Usuario Moderna:** Incorporar un Dashboard con métricas de negocio (KPIs), vistas responsivas y diseño optimizado con MaterialSkin.
4. **Funcionalidades de Alto Valor:** Login con autenticación real, exportación de reportes a Excel, y compatibilidad con lector de código de barras (físico o celular).

---

## 📋 Lista de Tareas y Funcionalidades

### Fase 1: Base de Datos y Modelo de Datos
- [ ] **Ampliación de la Tabla `ARTICULOS`:**
  - Agregar columna `Stock INT NOT NULL DEFAULT 0`
  - Agregar columna `StockMinimo INT NOT NULL DEFAULT 5`
  - Agregar columna `FechaRegistro DATETIME DEFAULT GETDATE()`
- [ ] **Creación de la Tabla `USUARIOS`:**
  - Campos: `Id`, `NombreUsuario`, `Pass` (hash SHA-256), `NombreCompleto`, `Email`, `Rol` (`Admin` / `Operador`), `Activo`.
- [ ] **Actualización del script SQL (`script_db.sql`):**
  - Incorporar nuevas tablas, campos y datos iniciales (usuario administrador por defecto y artículos con valores de stock).
- [ ] **Actualización de Clases de Dominio (`Dominio/`):**
  - Actualizar `Articulo.cs` con las propiedades `Stock`, `StockMinimo` y alertas lógicas.
  - Crear `Usuario.cs` y enumeración de roles.

---

### Fase 2: Autenticación y Seguridad (Login Real)
- [ ] **Capa de Negocio para Usuarios (`UsuarioNegocio.cs`):**
  - Método de autenticación comparando hash SHA-256 de contraseña.
  - Validación de estado activo/inactivo.
- [ ] **Manejo de Sesión Global (`SesionActual.cs`):**
  - Clase estática para persistir el usuario logueado en memoria durante la ejecución.
- [ ] **Formulario de Login Moderno (`frmLogin.cs`):**
  - Diseño con MaterialSkin (Usuario, Contraseña, botón Ingresar).
  - Bloqueo de controles o cierre limpio si no se autentica.
- [ ] **Control de Accesos por Rol (RBAC):**
  - Si el rol es `Operador`: Deshabilitar eliminación de artículos y gestión de usuarios.
  - Si el rol es `Admin`: Acceso completo.

---

### Fase 3: Dashboard Principal y Reestructuración de Vistas
- [ ] **Nueva Estructura de Navegación:**
  - Menú lateral organizado por secciones claras:
    - 📊 **Dashboard (Inicio)**
    - 📦 **Gestión de Artículos (Catálogo & Stock)**
    - ⚙️ **Marcas & Categorías (Tablas Maestras)**
    - 👤 **Seguridad & Sesión**
- [ ] **Vista Dashboard (Métricas de Negocio):**
  - Tarjeta 1: **Total de Artículos** registrados.
  - Tarjeta 2: **Valor Total del Inventario** en \$ (Precio × Stock).
  - Tarjeta 3: **Artículos con Stock Crítico / Faltante** (Stock ≤ StockMinimo).
  - Tarjeta 4: **Total de Marcas y Categorías activas**.
  - Acceso directo a acciones rápidas ("Nuevo Artículo", "Descargar Listado").
- [ ] **Optimización de Responsive en Monitores Grandes (Full HD / 24"):**
  - Configurar anclajes (`Anchor` y `Dock`) para evitar paneles cortados o vacíos en pantallas de alta resolución.

---

### Fase 4: Catálogo, Inventario y Lector de Código de Barras
- [ ] **Alertas Visuales de Stock en Grilla (`frmArticulos` / `Form1`):**
  - Colorear celdas/filas en amarillo o rojo suave cuando el producto esté en o por debajo de su `StockMinimo`.
- [ ] **Soporte de Lector de Código de Barras (Físico USB o Celular por Wi-Fi):**
  - Campo de búsqueda rápida con detección de tecla `Enter`.
  - Búsqueda instantánea por `Codigo` que focaliza el artículo o permite sumar/restar stock rápidamente.
  - Feedback sonoro (beep) al escanear exitosamente.
- [ ] **Formularios de Alta y Edición de Artículos:**
  - Incluir campos numéricos para `Stock` y `Stock Mínimo`.

---

### Fase 5: Reportes y Exportación a Excel
- [ ] **Integración de ClosedXML (o EPPlus):**
  - Instalación de paquete NuGet liviano para generación de archivos `.xlsx` nativos sin necesidad de tener Office instalado.
- [ ] **Botón "Exportar a Excel" en Catálogo:**
  - Exportación de la lista completa o filtrada actual.
  - Formato profesional: Encabezados estilizados, columnas auto-ajustadas y formato moneda en precios.
- [ ] **Reporte Rápido de Stock Crítico:**
  - Posibilidad de exportar específicamente la lista de compras/reposición (productos que requieren reposición urgente).

---

### Fase 6: Unificación de Marcas y Categorías
- [ ] **Pantalla Compacta de Tablas Maestras:**
  - Reemplazar las ventanas sobredimensionadas actuales por una sola vista con pestañas (Tabs):
    - Tab 1: Listado, creación y edición de **Marcas**.
    - Tab 2: Listado, creación y edición de **Categorías**.
  - Diálogos modales pequeños y centrados.

---

### Fase 7: Limpieza Final y Preparación para Portfolio / Web
- [ ] **Limpieza de Documentación interna:**
  - Actualizar `README.md` con capturas de pantalla, diagrama de arquitectura, badges de tecnologías y guía de instalación de 1 paso.
  - Actualizar ventana "Acerca de" (`info.html`) con autoría exclusiva de **Sebastián Duarte**.
- [ ] **Modo Demo / Datos Iniciales:**
  - Asegurar que al ejecutar el script SQL, el sistema tenga artículos variados con fotos reales para demostraciones inmediatas.

