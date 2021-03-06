//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportGen
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Christian_FranciscoEntities : DbContext
    {
        public Christian_FranciscoEntities()
            : base("name=Christian_FranciscoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admAcumulado> admAcumulados { get; set; }
        public virtual DbSet<admAcumuladosTipos> admAcumuladosTipos { get; set; }
        public virtual DbSet<admAgente> admAgentes { get; set; }
        public virtual DbSet<admAlmacene> admAlmacenes { get; set; }
        public virtual DbSet<admAsientosContable> admAsientosContables { get; set; }
        public virtual DbSet<admAsocAcumConcepto> admAsocAcumConceptos { get; set; }
        public virtual DbSet<admAsocCargosAbono> admAsocCargosAbonos { get; set; }
        public virtual DbSet<admBandera> admBanderas { get; set; }
        public virtual DbSet<admBitacora> admBitacoras { get; set; }
        public virtual DbSet<admCapasProducto> admCapasProductoes { get; set; }
        public virtual DbSet<admCaracteristica> admCaracteristicas { get; set; }
        public virtual DbSet<admCaracteristicasValore> admCaracteristicasValores { get; set; }
        public virtual DbSet<admClasificacione> admClasificaciones { get; set; }
        public virtual DbSet<admClasificacionesValore> admClasificacionesValores { get; set; }
        public virtual DbSet<admCliente> admClientes { get; set; }
        public virtual DbSet<admComponentesPaquete> admComponentesPaquetes { get; set; }
        public virtual DbSet<admConcepto> admConceptos { get; set; }
        public virtual DbSet<admConceptosBack> admConceptosBacks { get; set; }
        public virtual DbSet<admConversionesUnidad> admConversionesUnidads { get; set; }
        public virtual DbSet<admCostosHistorico> admCostosHistoricos { get; set; }
        public virtual DbSet<admCuentasBancaria> admCuentasBancarias { get; set; }
        public virtual DbSet<admDatosAddenda> admDatosAddendas { get; set; }
        public virtual DbSet<admDocumento> admDocumentos { get; set; }
        public virtual DbSet<admDocumentosModelo> admDocumentosModeloes { get; set; }
        public virtual DbSet<admDocumentosModelosBack> admDocumentosModelosBacks { get; set; }
        public virtual DbSet<admDomicilio> admDomicilios { get; set; }
        public virtual DbSet<admEjercicio> admEjercicios { get; set; }
        public virtual DbSet<admExistenciaCosto> admExistenciaCostoes { get; set; }
        public virtual DbSet<admFoliosDigitale> admFoliosDigitales { get; set; }
        public virtual DbSet<admMaximosMinimo> admMaximosMinimos { get; set; }
        public virtual DbSet<admMoneda> admMonedas { get; set; }
        public virtual DbSet<admMovimiento> admMovimientos { get; set; }
        public virtual DbSet<admMovimientosCapa> admMovimientosCapas { get; set; }
        public virtual DbSet<admMovimientosContable> admMovimientosContables { get; set; }
        public virtual DbSet<admMovimientosPrepoliza> admMovimientosPrepolizas { get; set; }
        public virtual DbSet<admMovimientosSerie> admMovimientosSeries { get; set; }
        public virtual DbSet<admMovtosBancario> admMovtosBancarios { get; set; }
        public virtual DbSet<admMovtosCEP> admMovtosCEPs { get; set; }
        public virtual DbSet<admMovtosInvFisico> admMovtosInvFisicoes { get; set; }
        public virtual DbSet<admMovtosInvFisicoSerieCa> admMovtosInvFisicoSerieCas { get; set; }
        public virtual DbSet<admNumerosSerie> admNumerosSeries { get; set; }
        public virtual DbSet<admParametro> admParametros { get; set; }
        public virtual DbSet<admParametrosBack> admParametrosBacks { get; set; }
        public virtual DbSet<admPreciosCompra> admPreciosCompras { get; set; }
        public virtual DbSet<admPrepoliza> admPrepolizas { get; set; }
        public virtual DbSet<admProducto> admProductos { get; set; }
        public virtual DbSet<admProductosDetalle> admProductosDetalles { get; set; }
        public virtual DbSet<admProductosFoto> admProductosFotos { get; set; }
        public virtual DbSet<admPromocione> admPromociones { get; set; }
        public virtual DbSet<admProyecto> admProyectos { get; set; }
        public virtual DbSet<admSATSegmento> admSATSegmentos { get; set; }
        public virtual DbSet<admTiposCambio> admTiposCambios { get; set; }
        public virtual DbSet<admUnidadesMedidaPeso> admUnidadesMedidaPesoes { get; set; }
        public virtual DbSet<admVistasCampos> admVistasCampos { get; set; }
        public virtual DbSet<admVistasConsulta> admVistasConsultas { get; set; }
        public virtual DbSet<admVistasPorModulo> admVistasPorModuloes { get; set; }
        public virtual DbSet<admVistasRecurso> admVistasRecursos { get; set; }
        public virtual DbSet<admVistasRelacione> admVistasRelaciones { get; set; }
        public virtual DbSet<admVistasTabla> admVistasTablas { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<VREPGEN> VREPGENs { get; set; }
        public virtual DbSet<production> productions { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<ViewPay> ViewPays { get; set; }
        public virtual DbSet<ViewClin> ViewClins { get; set; }
        public virtual DbSet<deudroe> deudroes { get; set; }
    
        public virtual ObjectResult<spaaa_Result> spaaa()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spaaa_Result>("spaaa");
        }
    
        public virtual ObjectResult<SPPayment_Result> SPPayment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPPayment_Result>("SPPayment");
        }
    }
}
