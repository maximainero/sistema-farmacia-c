﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFarmacia.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Farmacia : DbContext
    {
        public Farmacia()
            : base("name=Farmacia")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bitacora_precios> Bitacora_precios { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Drogas> Drogas { get; set; }
        public virtual DbSet<Presentaciones> Presentaciones { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Productos_Drogas> Productos_Drogas { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Temp2> Temp2 { get; set; }
        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
        public virtual DbSet<VClientes_> VClientes_ { get; set; }
        public virtual DbSet<VTemp2> VTemp2 { get; set; }
        public virtual DbSet<VVentas> VVentas { get; set; }
    
        public virtual int Agregar_Cliente(string nombre, string apellido, Nullable<int> telefono1, Nullable<int> telefono2, Nullable<int> id_ciudad, string direccion, Nullable<short> caract1, Nullable<short> caract2)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var telefono1Parameter = telefono1.HasValue ?
                new ObjectParameter("telefono1", telefono1) :
                new ObjectParameter("telefono1", typeof(int));
    
            var telefono2Parameter = telefono2.HasValue ?
                new ObjectParameter("telefono2", telefono2) :
                new ObjectParameter("telefono2", typeof(int));
    
            var id_ciudadParameter = id_ciudad.HasValue ?
                new ObjectParameter("id_ciudad", id_ciudad) :
                new ObjectParameter("id_ciudad", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var caract1Parameter = caract1.HasValue ?
                new ObjectParameter("caract1", caract1) :
                new ObjectParameter("caract1", typeof(short));
    
            var caract2Parameter = caract2.HasValue ?
                new ObjectParameter("caract2", caract2) :
                new ObjectParameter("caract2", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Agregar_Cliente", nombreParameter, apellidoParameter, telefono1Parameter, telefono2Parameter, id_ciudadParameter, direccionParameter, caract1Parameter, caract2Parameter);
        }
    
        public virtual int Agregar_Temp(string nombre, Nullable<byte> idpresentacion, Nullable<decimal> precio, string componentes)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idpresentacionParameter = idpresentacion.HasValue ?
                new ObjectParameter("idpresentacion", idpresentacion) :
                new ObjectParameter("idpresentacion", typeof(byte));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var componentesParameter = componentes != null ?
                new ObjectParameter("componentes", componentes) :
                new ObjectParameter("componentes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Agregar_Temp", nombreParameter, idpresentacionParameter, precioParameter, componentesParameter);
        }
    
        public virtual int Agregar_Venta(Nullable<int> idcliente, Nullable<int> idprodcuto, Nullable<System.DateTime> fecha, Nullable<byte> cantidad)
        {
            var idclienteParameter = idcliente.HasValue ?
                new ObjectParameter("idcliente", idcliente) :
                new ObjectParameter("idcliente", typeof(int));
    
            var idprodcutoParameter = idprodcuto.HasValue ?
                new ObjectParameter("idprodcuto", idprodcuto) :
                new ObjectParameter("idprodcuto", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Agregar_Venta", idclienteParameter, idprodcutoParameter, fechaParameter, cantidadParameter);
        }
    
        public virtual int Aumentar_precios(Nullable<int> id, Nullable<decimal> porcentaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Aumentar_precios", idParameter, porcentajeParameter);
        }
    
        public virtual int Eliminar_Temp(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Temp", idParameter);
        }
    
        public virtual int Modificar_temp(Nullable<int> id, string nombre, Nullable<byte> idpresentacion, Nullable<decimal> precio, string componentes)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idpresentacionParameter = idpresentacion.HasValue ?
                new ObjectParameter("idpresentacion", idpresentacion) :
                new ObjectParameter("idpresentacion", typeof(byte));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            var componentesParameter = componentes != null ?
                new ObjectParameter("componentes", componentes) :
                new ObjectParameter("componentes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modificar_temp", idParameter, nombreParameter, idpresentacionParameter, precioParameter, componentesParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Modificar_Cliente(Nullable<int> id, string nombre, string apellido, Nullable<int> telefono1, Nullable<int> telefono2, Nullable<int> id_ciudad, string direccion, Nullable<short> caract1, Nullable<short> caract2)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var telefono1Parameter = telefono1.HasValue ?
                new ObjectParameter("telefono1", telefono1) :
                new ObjectParameter("telefono1", typeof(int));
    
            var telefono2Parameter = telefono2.HasValue ?
                new ObjectParameter("telefono2", telefono2) :
                new ObjectParameter("telefono2", typeof(int));
    
            var id_ciudadParameter = id_ciudad.HasValue ?
                new ObjectParameter("id_ciudad", id_ciudad) :
                new ObjectParameter("id_ciudad", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var caract1Parameter = caract1.HasValue ?
                new ObjectParameter("caract1", caract1) :
                new ObjectParameter("caract1", typeof(short));
    
            var caract2Parameter = caract2.HasValue ?
                new ObjectParameter("caract2", caract2) :
                new ObjectParameter("caract2", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Modificar_Cliente", idParameter, nombreParameter, apellidoParameter, telefono1Parameter, telefono2Parameter, id_ciudadParameter, direccionParameter, caract1Parameter, caract2Parameter);
        }
    }
}
