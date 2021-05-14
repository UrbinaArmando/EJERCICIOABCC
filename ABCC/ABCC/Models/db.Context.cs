﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABCC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class abcEntities : DbContext
    {
        public abcEntities()
            : base("name=abcEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABCC> ABCC { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Clase> Clase { get; set; }
        public virtual DbSet<Familia> Familia { get; set; }
    
        public virtual int spAlta(Nullable<int> sku, string articulo, string marca, string modelo, Nullable<int> departamento, Nullable<int> clase, string familia, Nullable<int> stock, Nullable<int> cantidad, Nullable<System.DateTime> fecha_Alta, Nullable<System.DateTime> fecha_Baja, string descontinuado)
        {
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            var articuloParameter = articulo != null ?
                new ObjectParameter("Articulo", articulo) :
                new ObjectParameter("Articulo", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var departamentoParameter = departamento.HasValue ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(int));
    
            var claseParameter = clase.HasValue ?
                new ObjectParameter("Clase", clase) :
                new ObjectParameter("Clase", typeof(int));
    
            var familiaParameter = familia != null ?
                new ObjectParameter("Familia", familia) :
                new ObjectParameter("Familia", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var fecha_AltaParameter = fecha_Alta.HasValue ?
                new ObjectParameter("Fecha_Alta", fecha_Alta) :
                new ObjectParameter("Fecha_Alta", typeof(System.DateTime));
    
            var fecha_BajaParameter = fecha_Baja.HasValue ?
                new ObjectParameter("Fecha_Baja", fecha_Baja) :
                new ObjectParameter("Fecha_Baja", typeof(System.DateTime));
    
            var descontinuadoParameter = descontinuado != null ?
                new ObjectParameter("Descontinuado", descontinuado) :
                new ObjectParameter("Descontinuado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAlta", skuParameter, articuloParameter, marcaParameter, modeloParameter, departamentoParameter, claseParameter, familiaParameter, stockParameter, cantidadParameter, fecha_AltaParameter, fecha_BajaParameter, descontinuadoParameter);
        }
    
        public virtual int spBaja(Nullable<int> sku)
        {
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spBaja", skuParameter);
        }
    
        public virtual int spCambio(Nullable<int> sku, string articulo, string marca, string modelo, Nullable<int> departamento, Nullable<int> clase, string familia, Nullable<int> stock, Nullable<int> cantidad, Nullable<System.DateTime> fecha_Alta, Nullable<System.DateTime> fecha_Baja, string descontinuado)
        {
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            var articuloParameter = articulo != null ?
                new ObjectParameter("Articulo", articulo) :
                new ObjectParameter("Articulo", typeof(string));
    
            var marcaParameter = marca != null ?
                new ObjectParameter("Marca", marca) :
                new ObjectParameter("Marca", typeof(string));
    
            var modeloParameter = modelo != null ?
                new ObjectParameter("Modelo", modelo) :
                new ObjectParameter("Modelo", typeof(string));
    
            var departamentoParameter = departamento.HasValue ?
                new ObjectParameter("Departamento", departamento) :
                new ObjectParameter("Departamento", typeof(int));
    
            var claseParameter = clase.HasValue ?
                new ObjectParameter("Clase", clase) :
                new ObjectParameter("Clase", typeof(int));
    
            var familiaParameter = familia != null ?
                new ObjectParameter("Familia", familia) :
                new ObjectParameter("Familia", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var fecha_AltaParameter = fecha_Alta.HasValue ?
                new ObjectParameter("Fecha_Alta", fecha_Alta) :
                new ObjectParameter("Fecha_Alta", typeof(System.DateTime));
    
            var fecha_BajaParameter = fecha_Baja.HasValue ?
                new ObjectParameter("Fecha_Baja", fecha_Baja) :
                new ObjectParameter("Fecha_Baja", typeof(System.DateTime));
    
            var descontinuadoParameter = descontinuado != null ?
                new ObjectParameter("Descontinuado", descontinuado) :
                new ObjectParameter("Descontinuado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCambio", skuParameter, articuloParameter, marcaParameter, modeloParameter, departamentoParameter, claseParameter, familiaParameter, stockParameter, cantidadParameter, fecha_AltaParameter, fecha_BajaParameter, descontinuadoParameter);
        }
    
        public virtual ObjectResult<spConsulta_Result> spConsulta(Nullable<int> sku)
        {
            var skuParameter = sku.HasValue ?
                new ObjectParameter("Sku", sku) :
                new ObjectParameter("Sku", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsulta_Result>("spConsulta", skuParameter);
        }
    }
}
