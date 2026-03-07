namespace Tienda_Consola
{
    class Presentacion: Inventario
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
        public void Menu()
        {
            
        }
    }
}