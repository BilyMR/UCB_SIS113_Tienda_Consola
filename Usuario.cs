namespace Tienda_Consola
{
    class Usuario
    {
        public string nombre{get; private set;}
        public Rol rol{get; private set;}

        public Usuario(string nombre, Rol rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        } 
    }
}