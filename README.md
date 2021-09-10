# plat_desa_tp
TP Plataformas de Desarrollo

Detalles del tp:
- Las clases contienen atributos que se pueden modelar como properties p�blicas con
sus get y set correspondientes.
- Si bien no est�n en el diagrama (para optimizar espacio), todas las clases deben contar
con su constructor correspondiente:
o El campo ID es auto-incremental, es decir, se puede utilizar la cantidad de
elementos de la lista correspondiente +1 como ID.
o Usuario y Carro tienen el mismo ID. En su constructor, Usuario crea un nuevo
carro con el mismo ID que le pasan por par�metro.

o El constructor de �Mercado� no pide par�metros, la cantidad m�xima de
categor�as est� definida por la constante MaxCategorias mientras que la
cantidad de categor�as agregadas se guarda en CantCategorias (datos
necesarios ya que Categor�as es un arreglo).

- La clase Usuario es abstracta e implementa un orden por n�mero de DNI.
- La clase Producto implementa orden por Nombre.
- La clase Categor�a implementa orden por Nombre.
- La clase Compra implementa orden por ID.
- Las clases Carro y Mercado no implementan orden.
- Toda clase hace adem�s override del m�todo ToString(), retornando todas sus
propiedades separadas por un � � �, de modo que sea posible imprimir un objeto de
cualquier clase.
o Carro y Compra adem�s muestran todos los �tems en su diccionario
o Mercado no implmenta ToString().

M�todos:
- Los par�metros no se agregaron en el diagrama para optimizar espacio, debajo se
encuentra el detalle completo.
- Todos los m�todos de ABM (alta, baja o modificaci�n) devuelven un boolean que
indica si se pudo realizar la transacci�n correctamente.
- Recordar que a la hora de �Agregar� un nuevo elemento, no pedimos un ID porque
todav�a no lo tiene, Mercado se lo asigna en base a la cantidad de elementos que
tiene.
- Clase Mercado:
o bool AgregarProducto (string Nombre, double Precio, int Cantidad, int
ID_Categor�a)
o bool ModificarProducto (int ID, string Nombre, double Precio, int Cantidad, int
ID_Categor�a)
o bool EliminarProducto (int ID)
o void BuscarProductos (string Query): Muestra por pantalla, ordenado por
Nombre, los productos que contienen en su nombre la cadena ingresada por
el usuario para la b�squeda.
o void BuscarProductosPorPrecio (string Query): Muestra por pantalla,
ordenado por Precio de menor a mayor, los productos que contienen en su
nombre la cadena ingresada por el usuario para la b�squeda.
o void BuscarProductosPorCategoria (int ID_Categoria): Muestra por pantalla,
ordenado por Nombre, los productos que pertenecen a la categor�a con ID
ingresada por el usuario para la b�squeda.
o bool AgregarUsuario (int DNI, string Nombre, string Apellido, string Mail, string
Password, int CUIT_CUIL, bool EsEmpresa)
o bool ModificarUsuario (int ID, int DNI, string Nombre, string Apellido, string
Mail, string Password, int CUIT_CUIL, bool EsEmpresa)
o bool EliminarUsuario (int ID)

o void MostrarUsuarios(): Muestra por pantalla todos los usuarios que existen
en el mercado ordenados por defecto (DNI).
o bool AgregarCategoria (string Nombre)
o bool ModificarCategoria (int ID, string Nombre)
o bool EliminarCategoria (int ID): Cuidado al eliminar elementos de un arreglo!
o void MostrarCategoria (): Muestra por pantalla todos los usuarios que existen
en el mercado ordenados por defecto (DNI).
o bool AgregarAlCarro(int ID_Producto, int Cantidad, int ID_Usuario):
- Pide al usuario el carro.
- Si el par�metro Cantidad es menor a la Cantidad (atributo) del
producto �ID_Producto� (hay stock), agrega el Producto al carro del
usuario.
- Si no hay stock devuelve falso.
- Nota: En este punto no decremento el atributo Cantidad en la clase
Producto ya que el usuario todav�a NO realiz� la compra.

o bool QuitarDelCarro (int ID_Producto, int Cantidad, int ID_Usuario): Disminuye
la cantidad del producto ID_Producto en el carro del usuario.
o bool VaciarCarro (int ID_Usuario): vac�a el carro del usuario.
o bool Comprar (int ID_Usuario): Genera una nueva compra:
- Busca el usuario pasado como par�metro
- Le pide su carro y a este los productos con la cantidad respectiva.
- En base a esto calcula el total seg�n el tipo de usuario, a la hora de
hacer una compra existe una diferencia si el usuario es ClienteFinal o
Empresa ya que este �ltimo paga 21% menos (descuenta IVA), esto se
debe ver reflejado en el total de la compra.
- Crea un nuevo elemento compra con el detalle necesario (ID auto-
incremental, Comprador = ID_Usuario, Productos copiando los
elementos del carrito a un nuevo diccionario (�cuidado con las
referencias!) y el total seg�n calculado).
- Disminuye el stock de los productos seg�n lo comprado por el usuario.
- Luego vac�a el carrito del usuario.
- Muestra el resultado por pantalla (ToString de la compra
recientemente creada) y devuelve el valor correspondiente indicando
si la ejecuci�n fue correcta.

o bool ModificarCompra (int ID, double Total): solo se permite modificar el total
en caso que haya un error de facturaci�n. El resto de los datos no pueden ser
modificados.
o bool EliminarCompra (int ID): Nuestro �bot�n de arrepentimiento��
o void MostrarTodosProductosPorPrecio(): Muestra todos los productos del
mercado ordenados por precio.
o void MostrarTodosProductosPorCategoria(): Muestra todas las categor�as del
mercado y para cada una de ellas los productos dentro de la misma.

- Clase Carro:

o bool AgregarProducto (Producto P, int Cantidad): Crea una nueva entrada en
el diccionario del carro para el producto. Si el producto ya existe, se actualiza
la entrada correspondiente.
o bool AgregarProducto (Producto P, int Cantidad): Disminuye la cantidad del
producto P. Si la cantidad es 0, se elimina la entrada del diccionario.
o Vaciar(): Reinicia el diccionario de Productos.

Condiciones de aprobaci�n:
Para aprobar el trabajo se deben cumplir con los siguientes escenarios:
- Se deben implementar todas las clases que componen el modelo abordado
previamente.
- La implementaci�n de los m�todos relacionados con la compra de productos es
opcional (aunque recomendable) en esta etapa, siendo posible dejar la
implementaci�n de los mismos para el TP2.
- Se debe crear una clase program con una aplicaci�n por consola que:
o Al iniciar el programa, se crea un �mercado� que es la clase principal con un
arreglo de categor�as de tama�o definido en la constante MaxCategorias y el
resto de las listas vac�as.
o Al ingresar el usuario visualiza una pantalla con las opciones para:
1. Administrar
2. Comprar
o Si elije la opci�n 1, administrar, se muestran las opciones para:
1. Alta de categor�a
2. Baja de categor�a
3. Modificaci�n de categor�a
4. Mostrar categor�as que existen en el sistema
5. Alta de usuario
6. Baja de usuario
7. Modificaci�n de usuario
8. Mostrar usuarios que existen en el sistema
9. Alta de producto
10. Baja de producto
11. Modificaci�n de producto
12. Mostrar productos que existen en el sistema
13. Mostrar productos que existen en el sistema ordenados por precio
14. Mostrar productos que existen en el sistema ordenados por categor�a
o Si elije la opci�n 2, comprar, se muestra: �Bajo construcci�n, pr�ximamente en
TP2!�

- Cada vez que se muestren los elementos de una clase deben estar ordenados seg�n lo
establecido en el punto anterior, salvo que el m�todo especifique lo contrario (por
ejemplo ProductosPorPrecio).