namespace Tienda_Consola
{
    class Presentacion
    {
        private Inventario inventario;
        public Presentacion(Inventario inv)
        {
            inventario = inv;
        }
        public void MostrarInventario()
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
            string categoria = Console.ReadLine();

            Console.Write("Precio: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            inventario.AgregarProducto(nombre, categoria, precio, stock);
            Console.WriteLine("Producto agregado.");
        }
        public void Menu(Usuario usuario)
        {
           int opcion;
            do
            {
                Console.WriteLine("-------Menu-------");
                if (usuario.rol.AgregaProducto)
                    Console.WriteLine("1. Agregar producto");

                Console.WriteLine("2. Ver inventario");
                Console.WriteLine("3. Salir");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if(opcion == 1 && usuario.rol.AgregaProducto)
                {
                    AgregarProducto();
                } 
                else if(opcion == 2)
                {
                    MostrarInventario();
                }
                else if(opcion == 3)
                {
                    Console.WriteLine("Bye");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            } while(opcion != 3);
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