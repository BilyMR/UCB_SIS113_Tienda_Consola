namespace Tienda_Consola
{
    class Producto
    {
        public string codigo{get; set;}
        public string nombre{get; private set;}
        public double precio{get; set;}
        public int stock{get; set;}
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