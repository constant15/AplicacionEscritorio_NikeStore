# Proyecto de Taller de Programación 2 (2023)

``
CARRERA: Licenciatura en Sistemas de Información
``

``
GRUPO NRO: 7
``

``
INTEGRANTES:
``

| APELLIDO Y NOMBRE | DNI |
| ------ | ------ |
| OLIVOS, Nicolas | 46.073.510 |
| PINAT, Juan Matias | 39.190.409 |


``
MANUAL O GUIA PARA EL USUARIO:
``

### Iniciar al Sistema

#### Esta es la vista para iniciar sesion (LOGIN) donde debemos ingresar nuestro nro. de documento y contraseña:

[![1-Login.png](https://i.postimg.cc/wMnVGM0D/1-Login.png)](https://postimg.cc/T5qgyd8P)

#### Por defecto vamos a poder ingresar solo 8 caracteres como maximo en el primer recuadro y en el segundo van a estar cifrados con asteriscos para la contraseña:

[![4.png](https://i.postimg.cc/Y0jVg8qG/4.png)](https://postimg.cc/sGdwCYWs)

#### Al ingresar datos incorrectos o incompletos saltara este mensaje de advertencia:

[![2-Login.png](https://i.postimg.cc/JhwhzLdK/2-Login.png)](https://postimg.cc/Hr2m6fm7)

#### Al ingresar correctamente al sistema tendra acceso al inicio del mismo, donde vera los dos menus principales:

[![3.png](https://i.postimg.cc/j50vcL3N/3.png)](https://postimg.cc/jWczddbd)

#### Del lado izquierdo tenemos la parte de los menus, en el cual aparecerar los menus a los que tendra acceso el ROL de ese determinado USUARIO que ingreso al sistema:

[![71.png](https://i.postimg.cc/6q89c525/71.png)](https://postimg.cc/4HTkNGQr)

#### Del lado derecho tenemos la parte del nombre del USUARIO y su ROL, como tambien un boton para Cerrar Sesión:

[![72.png](https://i.postimg.cc/76sHSTLW/72.png)](https://postimg.cc/0MS1sjDY)

#### Asi se veria el inicio de sesion de un USUARIO con ROL de Empleado:

[![73.png](https://i.postimg.cc/4404dtqK/73.png)](https://postimg.cc/CdjprZFY)

#### Asi se veria el inicio de sesion de un USUARIO con ROL de Gerente:

[![74.png](https://i.postimg.cc/2ygCKRhd/74.png)](https://postimg.cc/hQbFXYCh)

#### Creamos 2 usuarios por tipo de ROL (2 administradores, 2 empleados y 2 gerentes), el cual cada uno tiene sus PERMISOS (acceso a los menus) correspondientes:

| ROL | Nro. Documento | Contraseña |
| ------ | ------ |  ------ |
| Admin 1  | 12345678| 123 |
| Admin 2  | 87654321 | 123 |
| Empleado 1  | 11223344 | 123 |
| Empleado 2  | 44332211 | 123 |
| Gerente 1  | 1234567 | 123 |
| Gerente 2  | 76543210 | 123 |


#### Como modelo usamos siempre un USUARIO con ROL de Administrador para poder mostrar todas las funcionalidades del sistema, ya que tiene acceso a todas allas.

#### Como primer menu tenemos el de Usuario:

[![5.png](https://i.postimg.cc/Kvkw89HC/5.png)](https://postimg.cc/9r2JxBVB)

#### A la izquierda tenemos la parte de Detalle Usuario, donde ingresaremos todos los datos a la hora de crear un nuevo usuario:

[![9.png](https://i.postimg.cc/85Z9jxDg/9.png)](https://postimg.cc/Hc7BNZV6)

#### Si damos en el boton guardar sin cargar ningun dato nos saltara un mensaje de advertencia diciendonos que carguemos estos datos:

[![6.png](https://i.postimg.cc/HsqKcwGn/6.png)](https://postimg.cc/F7xGwJHX)

#### Si cargamos todos y nos olvidamos uno, tambien nos saltara dicho mensaje de advertencia, ya que se deben completar todos y cada uno de ellos:

[![7.png](https://i.postimg.cc/bw15QZ8T/7.png)](https://postimg.cc/87PwGP7J)

#### En la parte superior tenemos la parte de Lista de Usuarios:

[![10.png](https://i.postimg.cc/nzFNVpy1/10.png)](https://postimg.cc/WDy5XLbD)

#### Veremos un filtro para buscar usuarios por determinado campo, al lado podemos escribir letras o palabras correspondientes a la busqueda que queramos hacer:

[![20.png](https://i.postimg.cc/mDM3n52W/20.png)](https://postimg.cc/PpX8pKwS)

#### Un ejemplo de busqueda por nombre donde solo se ingresa una parte de el mismo:

[![21.png](https://i.postimg.cc/L5pkF3nY/21.png)](https://postimg.cc/gXgLvRym)

#### Al finalizar o si queremos realizar otra busqueda podemos hacer clic en la escoba para limpiar y volver todo como al inicio:

[![22.png](https://i.postimg.cc/prJfW5F0/22.png)](https://postimg.cc/XBXGxJxF)

#### Abajo en la parte mas importante se podria decir porque es la que contiene los registros con los datos de los usuarios, veremos cada uno de estos:

[![11.png](https://i.postimg.cc/GtNfjYHM/11.png)](https://postimg.cc/PvWKXCbZ)

#### Vemos que al comienzo de cada registro hay un boton de 'check', al cual si le damos click podremos editar los datos de este registro (en este caso usuario):

[![12.png](https://i.postimg.cc/sf0byFwp/12.png)](https://postimg.cc/Z0pwFQkR)

#### En todos los formularios decidimos sacar el boton de eliminar, ya que nos pidieron que la eliminacion debia ser logica y no fisica, consideramos que esta eliminacion logica se hace a traves de la baja de un usuario (en este caso) editandolo y poniendo como 'No Acvito'. De esta manera este usuario no podra ingresar al sistema.

#### Hacemos una prueba como ejemplo editando y cambiando el estado de un usuario de 'Activo' a 'No activo':

[![23.png](https://i.postimg.cc/rwKfJgWM/23.png)](https://postimg.cc/hXR84Lp5)

[![24.png](https://i.postimg.cc/HsWZJTkJ/24.png)](https://postimg.cc/xq7yhDHY)

[![25.png](https://i.postimg.cc/8PyyMx7Z/25.png)](https://postimg.cc/ZCdFh7FN)

#### Si hacemos la prueba de entrar con este usuario al sistema:

[![80.png](https://i.postimg.cc/RC2JWqD0/80.png)](https://postimg.cc/Hj4kKWHG)

#### Veremos que no podra hacerlo y no tendra acceso al mismo:

[![81.png](https://i.postimg.cc/8k7rkLw3/81.png)](https://postimg.cc/z31f0bsS)

#### Tambien podemos cambiar su tipo de ROL, para que este pueda tener acceso a otros menus:

[![26.png](https://i.postimg.cc/7Pj14DT8/26.png)](https://postimg.cc/grqLyCDN)

#### En el menu de Mantenedor tenemos 3 subcategorias (Categoria, Productos y Negrocio):

[![30.png](https://i.postimg.cc/CxJR4Z9g/30.png)](https://postimg.cc/pmhVWd2G)

#### De manera similar veremos todos los menus en los que se veran registros cargados con los datos correspodientes a dicho menu:

* Menu Categorias:

[![31.png](https://i.postimg.cc/D0V0z14q/31.png)](https://postimg.cc/hzrcyzrj)

* Menu Productos:

[![32.png](https://i.postimg.cc/nhVzMFrw/32.png)](https://postimg.cc/0b3xBqpp)

* Menu Negocio:

[![33.png](https://i.postimg.cc/XJBX3sqj/33.png)](https://postimg.cc/CBYwsHbX)

#### En este podremos cargar los datos correspodientes a nuestro negocio, los cuales se mostraran en la factura/boleta descargada.

#### Podemos subir una imagen o logo de nuestro negocio:

[![34.png](https://i.postimg.cc/8Pmc1Jp6/34.png)](https://postimg.cc/ppyRCdnW)

#### Una vez completos todos los datos, guardamos y nos saldra un mensaje de exito:

[![35.png](https://i.postimg.cc/nLPM6yHS/35.png)](https://postimg.cc/zLTJhPHT)

* Menu Clientes:

[![36.png](https://i.postimg.cc/BZDtV7RN/36.png)](https://postimg.cc/QV8XBm8W)

* Menu Proveedores:

[![37.png](https://i.postimg.cc/wTp38cpz/37.png)](https://postimg.cc/qg1p2KqD)

* Menu Compras tendra dos subcategorias (Registrar y Ver Detalle):

[![38.png](https://i.postimg.cc/rsSmRz57/38.png)](https://postimg.cc/Wq1jQNW7)

* Menu Registrar Compra:

[![39.png](https://i.postimg.cc/jjmd8yXG/39.png)](https://postimg.cc/rdGks07J)

#### En el primer recuadro veremos la información de la compra, donde por defecto nos pondra la fecha actual podremos elegir si queremos boleta o factura como comprobante de la compra:

[![40.png](https://i.postimg.cc/9frQtLGd/40.png)](https://postimg.cc/94H2ctg0)

#### En el segundo recuadro veremos la información del proveedor, donde podremos cargar manualmente su numero de documento o razon social; o buscar con la lupa el proveedor de una lista:

[![41.png](https://i.postimg.cc/RFtC2qpq/41.png)](https://postimg.cc/mzbGHZsG)

#### Al hacer click en la lupa veremos la lista de proveedores:

[![42.png](https://i.postimg.cc/6qN6KwFc/42.png)](https://postimg.cc/BLMfcWSP)

#### En esta venta en la parte superior tendremos un filtro de busqueda:

[![43.png](https://i.postimg.cc/d3mstpYY/43.png)](https://postimg.cc/JH0VpT06)

#### Como ejemplo ingresamos datos de una razón social para ver el resultado:

[![44.png](https://i.postimg.cc/RCcVR6nD/44.png)](https://postimg.cc/bdwhYvgx)

#### Al hacer click en la escoba limpiara todo:

[![45.png](https://i.postimg.cc/GmSc2vZH/45.png)](https://postimg.cc/87M8XfkS)

#### Cargamos los datos de un proveedor determinado:

[![46.png](https://i.postimg.cc/RV4CbS7V/46.png)](https://postimg.cc/c6kNvNkV)

#### En la parte del medio veremos el recuadro de información de producto: 

[![47.png](https://i.postimg.cc/K8YGx0p6/47.png)](https://postimg.cc/9rv5BYhb)

#### Al hacer click en la lupa nos abrira una ventana para elegir productos de la misma manera que con proveedor. Veremos su codigo, nombre, caretegoria y el stock actual de cada uno:

[![48.png](https://i.postimg.cc/nLjnQCJT/48.png)](https://postimg.cc/Lqpcc4hZ)

#### Elegimos un producto y deberemos ingresar el precio al cual compramos el producto como tambien el precio en el que vamos a vender el mismo, la cantidad de unidades que vamos a comprar y damos click en el boton Agregar:

[![49.png](https://i.postimg.cc/sDmjkkmP/49.png)](https://postimg.cc/TpyvmHZh)

#### Abajo veremos los productos cargados para la compra que haremos:

[![50.png](https://i.postimg.cc/TPzfjf2x/50.png)](https://postimg.cc/Lq3c2dZQ)

#### Una vez cargados todos los productos con sus cantidades a comprar, damos click en el boton Registrar y nos saldra un mensaje de exito y si queremos copiar el Numero de Compra (el cual se debe se debe copiar):

[![51.png](https://i.postimg.cc/kGcCdSQM/51.png)](https://postimg.cc/xNchvcpB)

#### Debemos copiar ese numero de compra para despues irnos al Menu de Reportes, despues Reporte Compras.

* Menu Reportes - Reporte Compras:

[![52.png](https://i.postimg.cc/B62sMktK/52.png)](https://postimg.cc/r0yvph1V)

#### Accederemos al mismo, pegaremos este Numero de Compra, damos click en buscar y veremos el registro de esa compra:

[![53.png](https://i.postimg.cc/3N7h61Db/53.png)](https://postimg.cc/Q96vKpmp)

#### Aqui podremos descargar un comprobante, boleta o factura (el que hayamos elegido). Damos click en el boton Descargar PDF, elegimos la ruta donde descargar y damos click en Guardar:

[![54.png](https://i.postimg.cc/9FmVYx2D/54.png)](https://postimg.cc/nMP6HGCx)

#### Nos saldra una mensaje de exito: 

[![55.png](https://i.postimg.cc/DfdnG99V/55.png)](https://postimg.cc/SjsBFvQV)

#### Abrimos y vemos el documento en formato PDF descargado como ejemplo de una compra:

[![56.png](https://i.postimg.cc/L6xSCz4N/56.png)](https://postimg.cc/MvfgXfQQ)

* Menu Ventas:

#### Para el caso de ventas es lo mismo, tenemos el Menu de Ventas, con dos submenus, Registrar y Ver Detalle.

[![57.png](https://i.postimg.cc/134QLffP/57.png)](https://postimg.cc/DSVHGfrY)

#### De la misma manera que con compras tendremos la vista para cargar una venta:

[![59.png](https://i.postimg.cc/bvtjwWxB/59.png)](https://postimg.cc/JyMFTTdN)

#### Con la unica diferencia que al cargar productos veremos automaticamente el precio de venta que pusimos a la hora de comprar el producto, como tambien el stock del mismo:

[![58.png](https://i.postimg.cc/rwbkcMr4/58.png)](https://postimg.cc/9DGSY31X)

* Menu Reportes:

#### Menu Reportes tendra dos subcategorias (Reporte Compras y Reporte Ventas).

[![60.png](https://i.postimg.cc/zBYYb7pX/60.png)](https://postimg.cc/FfpBwj22)

#### Reporte Compras, buscamos los reportes de compras en este caso las del 18/11/2023 y veremos la compra realizada en ese dia:

[![61.png](https://i.postimg.cc/BbNrz03X/61.png)](https://postimg.cc/MfM3cgvS)

#### Reporte Ventas, buscamos los reportes de ventas en este caso las del 14/11/2023 y veremos las ventas realizadas en ese dia:

[![62.png](https://i.postimg.cc/wTj8m75J/62.png)](https://postimg.cc/fkpr4WrT)

#### Como en los formularios anteriores (Usuarios, Productos, Categorias) tambien veremos el mismo formato para el menu de Clientes y Proveedores.

* Menu de Clientes:

[![63.png](https://i.postimg.cc/157xcsMd/63.png)](https://postimg.cc/9r9Nc36P)

* Menu de Proveedores:

[![64-1.png](https://i.postimg.cc/wj1CwZGj/64-1.png)](https://postimg.cc/mPGpDX4v)

#### En todos estos formularios vimos que tenemos un boton para descargar un Excel, este sirve para descargar un archivo en formato Excel con todos los registros cargados y a la vista en dicho formulario.

[![64-2.png](https://i.postimg.cc/7PVrhgzw/64-2.png)](https://postimg.cc/hhf53QM5)

#### Vamos a hacer la prueba con el formulario de Proveedores, hacemos click en el boton y se nos abrira una ventana elegir la ruta y el nombre del mismo (el cual ya tiene un formato predefinido):

[![64-3.png](https://i.postimg.cc/pL3g4CwY/64-3.png)](https://postimg.cc/Yvfnm6qh)

#### Aceptamos y nos saldra un mensaje de exito:

[![64-4.png](https://i.postimg.cc/HxgFsxsr/64-4.png)](https://postimg.cc/JypppRX8)

#### Donde elegimos descargar veremos el archivo con el nombre 'ReporteProveedores' seguido por la fecha y la hora:

[![64-5.png](https://i.postimg.cc/HL5fg5HG/64-5.png)](https://postimg.cc/t1qrdsYD)

#### Al abrir el archivo vereremos los registros de los proveedores en este formato:

[![64-6.png](https://i.postimg.cc/XJkmZbpQ/64-6.png)](https://postimg.cc/PpN2c0bw)

#### Tambien implementamos el backup, este se aplicara a nuestra base de datos completa del sistema, con todo lo cargado hasta el momento del mismo respaldo de seguridad. El archivo sera descargado en formato .bak como sabemos.
 
#### Haremos una prueba del mismo.

* Menu Backup:

#### Podemos ingresar manualmente la ruta donde se va a guardar el archivo de la copia de seguridad, como tambien apretar el boton Ruta para buscar dicha ruta:

[![65.png](https://i.postimg.cc/MHZ4VFBx/65.png)](https://postimg.cc/qhYjdQQZ)

#### Hacemos click en el boton Ruta y elegimos el escritorio como ruta:

[![66.png](https://i.postimg.cc/Y28TMtcS/66.png)](https://postimg.cc/CdBc4Txy)

#### Luego damos click en el boton Copia de seguridad:

[![67.png](https://i.postimg.cc/Y0XP3zNF/67.png)](https://postimg.cc/V0C4sMVs)

#### Nos aparecera un mensaje de exito:

[![68.png](https://i.postimg.cc/7Y6dLjDn/68.png)](https://postimg.cc/PNg233CC)

#### El boton para realizar el backup se bloqueara automaticamente para como prueba de exito y tambien para asegurar el respaldo de mas de un archivo en ese momento:

[![69.png](https://i.postimg.cc/QxyPKSdG/69.png)](https://postimg.cc/3d29PXGn)

#### Podremos ver el archivo descargado en formato .bak donde el nombre 'database' seguido por la fecha (año-mes-dia) y la hora (hora-minutos-segundos):

[![70.png](https://i.postimg.cc/9QwkdTD4/70.png)](https://postimg.cc/75DXD5MD)
