namespace Tienda_Consola
{
    class Presentacion
    {
        private Inventario inventario;
        public Presentacion(Inventario inv)
        {
            inventario = inv;
        }
        private void MostrarInventario()
        {
            Producto[] lista = inventario.ObtenerProductos();
            int total = inventario.ObtenerNumProductos();

            if (total == 0)
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }
            for(int i = 0; i < total; i++)
            {
                lista[i].Mostrar();
            }
        }

        private void AgregarProducto()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Categoria: ");
            string codigo = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            inventario.AgregarProducto(nombre, codigo, precio, stock);
            Console.WriteLine("Producto agregado.");
        }
        private void Menu(Usuario usuario)
        {
           int opcion;
            do
            {
                Console.WriteLine("-------Menu-------");
                if (usuario.rol.AgregaProducto)
                {
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Actualizar producto");
                    Console.WriteLine("3. Eliminar producto");
                }

                Console.WriteLine("4. Ver inventario");
                Console.WriteLine("5. Salir");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if(opcion == 1 && usuario.rol.AgregaProducto)
                {
                    AgregarProducto();
                } 
                else if(opcion == 2 && usuario.rol.AgregaProducto)
                {
                    EliminarProducto();
                }
                else if(opcion == 3 && usuario.rol.AgregaProducto)
                {
                    ActualizarProducto();
                }
                else if(opcion == 4)
                {
                    MostrarInventario();                }
                else if(opcion == 0)
                {
                    Console.WriteLine("Bye");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            } while(opcion != 0);
        }

        private void EliminarProducto()
        {
            Console.Write("Nombre del producto a eliminar: ");
            string nombre = Console.ReadLine();

            if (inventario.EliminarProducto(nombre))
                Console.WriteLine("Producto eliminado.");
            else
                Console.WriteLine("Producto no encontrado.");
        }

        private void ActualizarProducto()
        {
            Console.Write("Codigo del producto a actualizar: ");
            string codigo = Console.ReadLine();

            Console.Write("Nuevo precio: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Nuevo stock: ");
            int stock = int.Parse(Console.ReadLine());

            if (inventario.ActualizarProducto(codigo, stock, precio))
                Console.WriteLine("Producto actualizado.");
            else
                Console.WriteLine("Producto no encontrado.");
        }
        public void Iniciar()
        {
            Rol rolAdmin = new Rol("admin", AgregaProducto: true, VeInventario: true);
            Rol rolInvitado = new Rol("invitado", AgregaProducto: false, VeInventario: false);

            Console.Write("Ingresar usuario: ");
            string nombre = Console.ReadLine();

            Rol rolUsuario = (nombre == "admin") ? rolAdmin: rolInvitado;
            Usuario usuario = new Usuario(nombre, rolUsuario);

            Menu(usuario);
        }
    }
}