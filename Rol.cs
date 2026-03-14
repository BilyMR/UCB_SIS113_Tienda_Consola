namespace Tienda_Consola{
    class Rol
    {
        public  string nombre{get; private set;}
        public bool AgregaProducto{get; private set;}
        public bool VeInventario{get; private set;}

        public Rol(string nombre, bool AgregaProducto, bool VeInventario)
        {
            this.nombre = nombre;
            this.AgregaProducto = AgregaProducto;
            this.VeInventario = VeInventario;
        }
    }
}