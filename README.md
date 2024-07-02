# CRUD - AVES


## Sobre mí

Me llamo Lautaro Muller y tengo 22 años, nací en Avellaneda, pero actualmente vivo en Lanús. Estoy cursando el segundo cuatrimestre de la Tecnicatura en Programación en la UTN y es mi primera vez trabajando con esta tecnología.


## Descripción del proyecto

Aplicación desarrollada en C# utilizando Windows Forms, Herencia de clases, Serialización y Deserialización, Task, Delegados, Eventos, Test unitarios, Intefaces, Generics y SQL Server.

La aplicación empieza con un formulario de login donde el usuario ingresa un correo y una contraseña, estos datos son comparados con los del archivo data_usuarios.json. Si los datos son válidos se ingresa a un formulario CRUD (Crear, Leer, Actualizar, Eliminar) que permite al usuario, según su nivel de permisos (administrador, supervisor o empleado), agregar, modificar y eliminar distintas aves con sus respectivas características. Al cerrar el formulario las aves cargadas se guardan en un archivo XML y en una DB asociada al proyecto, para que, en un posterior ingreso, recuperar los datos.

### Funcionalidades del menú:
Ordenar: Ordena la lista de aves por nombre o edad y de forma ascendente o descendente. Al hacer esto también se invoca un evento que escribe el criterio elegido en pantalla para ayudar al usuario.  
Guardar como: Nos permite guardar la lista en una ubicación específica como archivo XML para después poder levantarla desde ahí.   
Cargar: Permite traer la información desde un archivo XML de nuestra computadora o desde la base de datos.   
Historial de usuarios: Abre un formulario donde podemos visualizar los usuarios que iniciaron sesión últimamente, con la hora en la que lo hicieron.   

### Permisos según perfil del usuario:
Administrador: CRUD. Tiene permiso de hacer todas las operaciones que ofrece la aplicación: AGREGAR, LEER, MODIFICAR y ELIMINAR.   
Supervisor: CRU. Puede hacer todas las operaciones menos la de ELIMINAR.   
Vendedor: R. Solo puede leer los datos de la DB.   

## Diagrama de clases

![Diagrama de Clases](ClassDiagram1.png)
