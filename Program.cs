using Tienda_Consola;
Inventario inv = new Inventario();
Presentacion pre = new Presentacion(inv);
inv.AgregarProducto("Calefacción", "ads", 300, 2);
inv.AgregarProducto("Palo de golf", "fss", 200, 8);
inv.AgregarProducto("Tornillo", "zxc", 2, 100);
pre.MostrarInventario();