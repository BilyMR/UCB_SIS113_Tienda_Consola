namespace Tienda_Consola
{
    class Inventario
    {
        protected int numProductos;
        protected int max = 1000;
        protected Producto[] listaProductos;

        public Inventario()
        {
            listaProductos= new Producto[max];
            numProductos = 0;
        }
        public void AgregarProducto(string n, string c, double p, int s)
        {
            listaProductos[numProductos] = new Producto(n, c, p, s);
            numProductos++;
        }
        public Producto[] ObtenerProductos()
        {
            return listaProductos;
        }
        public int ObtenerNumProductos()
        {
            return numProductos;
        }
    }
}