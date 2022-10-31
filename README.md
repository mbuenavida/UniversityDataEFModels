# UniversityDataEFModels
<b>Curso IFCD38 - IFCD38 - DESARROLLADOR WEB Y CLOUD MICROSOFT.</b>
<p>Web App con plantilla ASP.NET Core Web App (Model-View-Controller).</p>
Se sigue como inicio las instrucciones en https://thecodeblogger.com/2021/06/18/entity-framework-core-migration-tool-and-commands/

# Proyecto
En La práctica esta de thecodeblogger.com se utilizan Librerías de clases y una Web API pero, en este caso, se desarrolla con Web App.
Del manual mencionado, se aplican:
- Migraciones
- Uso de Common Data Annotations
- Relaciones con EF Core
- Relaciones Explícitas en :NET EF Core

A partir de este punto, se van añadiendo componentes siguiendo las instrucciones del profesor.

Esta misma práctica se desarrolla siguiendo las plantillas como en el manual en otro proyecto: EFCoreDemoBlog
## Documentación
<p>01 - Get started with ASP.NET Core MVC.docx</p>
<p>02 - Repository_Cambiar context de Program a Repositorio en ASP.NET Core MVC</p>

## Controlador
- Sin Scaffolding

## SeedData
<p>Se añade clase para sembrar la DB durante el desarrollo.</p>
<p>Se siembran las tablas de Cursos Y módulos pero aún no se como generar las Foireign Keys automáticamente y debe hacerse a mano.</p>
<p>No olvidar que si los campos <b>notnull</b> no están completados, al levantar la app, petará.</p>
