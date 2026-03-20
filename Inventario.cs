using System.Net.Http.Headers;

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

        public bool EliminarProducto(string code)
        {
            for(int i = 0; i < numProductos; i++)
            {
                if(listaProductos[i].codigo == code)
                {
                    for(int j = i; j < numProductos; j++)
                    {
                        listaProductos[j] = listaProductos[j+1];
                    }
                    listaProductos[numProductos-1] = null;
                    numProductos--;
                    return true;
                }
            }
            return false;
        }

        public bool ActualizarProducto(string code, int nStock, double nPrecio)
        {
            for(int i = 0; i < numProductos; i++)
            {
                if(listaProductos[i].codigo == code)
                {
                    for(int j = i; j < numProductos; j++)
                    {
                        listaProductos[i].stock = nStock;
                        listaProductos[i].precio = nPrecio;
                    }
                    return true;
                }
            }
            return false;
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