namespace Tienda_Consola
{
    class Producto
    {
        private string codigo;
        private string nombre;
        private double precio;
        private int stock;
        public Producto(string nombre, string codigo, double precio, int stock)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.precio = precio;
            this.stock = stock;
        }
        public void Mostrar()
        {
            Console.WriteLine(nombre + " | codigo: " + codigo + " | precio: " + precio + " | stock: " + stock);
        }
    }
}