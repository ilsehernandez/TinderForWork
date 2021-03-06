﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TinderForWork.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using TinderForWork.Classes;
    
    public partial class TinderForWorkDBEntities : DbContext
    {
        public TinderForWorkDBEntities()
            : base("name=TinderForWorkDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HabilidadesReqProyecto> HabilidadesReqProyectoes { get; set; }
        public virtual DbSet<HabilidadesUsuario> HabilidadesUsuarios { get; set; }
        public virtual DbSet<HorasServicioDada> HorasServicioDadas { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<PagoProj> PagoProjs { get; set; }
        public virtual DbSet<ProyectoInfo> ProyectoInfoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TarjetasUsuario> TarjetasUsuarios { get; set; }
        public virtual DbSet<UsuarioInfo> UsuarioInfoes { get; set; }
    
        public virtual ObjectResult<BuscaMatch_Result> BuscaMatch(Nullable<int> iDProyecto, string matricula)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscaMatch_Result>("BuscaMatch", iDProyectoParameter, matriculaParameter);
        }
    
        public virtual int InsertAbiilties(string matricula, string habilidad)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            var habilidadParameter = habilidad != null ?
                new ObjectParameter("Habilidad", habilidad) :
                new ObjectParameter("Habilidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertAbiilties", matriculaParameter, habilidadParameter);
        }
    
        public virtual int InsertAbiiltiesForProject(Nullable<int> iDProyecto, string habilidad)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var habilidadParameter = habilidad != null ?
                new ObjectParameter("Habilidad", habilidad) :
                new ObjectParameter("Habilidad", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertAbiiltiesForProject", iDProyectoParameter, habilidadParameter);
        }
    
        public virtual ObjectResult<string> InsertaTarjetas(Nullable<int> iDProyecto, string tarjeta, string matricula)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var tarjetaParameter = tarjeta != null ?
                new ObjectParameter("Tarjeta", tarjeta) :
                new ObjectParameter("Tarjeta", typeof(string));
    
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertaTarjetas", iDProyectoParameter, tarjetaParameter, matriculaParameter);
        }
    
        public virtual int InsertExpirience(string matricula, Nullable<int> proyectoID)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            var proyectoIDParameter = proyectoID.HasValue ?
                new ObjectParameter("ProyectoID", proyectoID) :
                new ObjectParameter("ProyectoID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertExpirience", matriculaParameter, proyectoIDParameter);
        }
    
        public virtual int InsertMatch(string matricula, Nullable<int> iDProyecto, Nullable<int> estadoMatch)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var estadoMatchParameter = estadoMatch.HasValue ?
                new ObjectParameter("EstadoMatch", estadoMatch) :
                new ObjectParameter("EstadoMatch", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMatch", matriculaParameter, iDProyectoParameter, estadoMatchParameter);
        }
    
        public virtual int InsertPayment(string iDProyecto, Nullable<decimal> pago)
        {
            var iDProyectoParameter = iDProyecto != null ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(string));
    
            var pagoParameter = pago.HasValue ?
                new ObjectParameter("Pago", pago) :
                new ObjectParameter("Pago", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPayment", iDProyectoParameter, pagoParameter);
        }
    
        public virtual int InsertProject(Nullable<int> horasTrabajo, string nombreProyecto, string descripcion, string campo, string matricula)
        {
            var horasTrabajoParameter = horasTrabajo.HasValue ?
                new ObjectParameter("HorasTrabajo", horasTrabajo) :
                new ObjectParameter("HorasTrabajo", typeof(int));
    
            var nombreProyectoParameter = nombreProyecto != null ?
                new ObjectParameter("NombreProyecto", nombreProyecto) :
                new ObjectParameter("NombreProyecto", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var campoParameter = campo != null ?
                new ObjectParameter("Campo", campo) :
                new ObjectParameter("Campo", typeof(string));
    
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertProject", horasTrabajoParameter, nombreProyectoParameter, descripcionParameter, campoParameter, matriculaParameter);
        }
    
        public virtual int InsertServiceHours(string iDProyecto, Nullable<int> hours)
        {
            var iDProyectoParameter = iDProyecto != null ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(string));
    
            var hoursParameter = hours.HasValue ?
                new ObjectParameter("Hours", hours) :
                new ObjectParameter("Hours", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertServiceHours", iDProyectoParameter, hoursParameter);
        }
    
        public virtual int InsertUser(string matricula, string nombre, string apellidoP, string apellidoM, string contrasena, string correo, Nullable<int> carrera, string campus, Nullable<bool> statusOcupado, string telefono)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPParameter = apellidoP != null ?
                new ObjectParameter("ApellidoP", apellidoP) :
                new ObjectParameter("ApellidoP", typeof(string));
    
            var apellidoMParameter = apellidoM != null ?
                new ObjectParameter("ApellidoM", apellidoM) :
                new ObjectParameter("ApellidoM", typeof(string));
    
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("Contrasena", contrasena) :
                new ObjectParameter("Contrasena", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var carreraParameter = carrera.HasValue ?
                new ObjectParameter("Carrera", carrera) :
                new ObjectParameter("Carrera", typeof(int));
    
            var campusParameter = campus != null ?
                new ObjectParameter("Campus", campus) :
                new ObjectParameter("Campus", typeof(string));
    
            var statusOcupadoParameter = statusOcupado.HasValue ?
                new ObjectParameter("StatusOcupado", statusOcupado) :
                new ObjectParameter("StatusOcupado", typeof(bool));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUser", matriculaParameter, nombreParameter, apellidoPParameter, apellidoMParameter, contrasenaParameter, correoParameter, carreraParameter, campusParameter, statusOcupadoParameter, telefonoParameter);
        }
    
        public virtual ObjectResult<string> MuestraTarjetas(Nullable<int> iDProyecto)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MuestraTarjetas", iDProyectoParameter);
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
    
        public virtual int UpdateHoras(Nullable<int> iDProyecto, Nullable<int> horas)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var horasParameter = horas.HasValue ?
                new ObjectParameter("horas", horas) :
                new ObjectParameter("horas", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateHoras", iDProyectoParameter, horasParameter);
        }
    
        public virtual int UpdateMatch(Nullable<int> matchID, Nullable<int> newState)
        {
            var matchIDParameter = matchID.HasValue ?
                new ObjectParameter("MatchID", matchID) :
                new ObjectParameter("MatchID", typeof(int));
    
            var newStateParameter = newState.HasValue ?
                new ObjectParameter("newState", newState) :
                new ObjectParameter("newState", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateMatch", matchIDParameter, newStateParameter);
        }
    
        public virtual int UpdatePayment(Nullable<int> iDProyecto, Nullable<decimal> pago)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            var pagoParameter = pago.HasValue ?
                new ObjectParameter("pago", pago) :
                new ObjectParameter("pago", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePayment", iDProyectoParameter, pagoParameter);
        }
    
        public virtual ObjectResult<string> ViewAbilitiesRequired(Nullable<int> iDProyecto)
        {
            var iDProyectoParameter = iDProyecto.HasValue ?
                new ObjectParameter("IDProyecto", iDProyecto) :
                new ObjectParameter("IDProyecto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ViewAbilitiesRequired", iDProyectoParameter);
        }
    
        public virtual ObjectResult<string> ViewAbilitiesUser(string matricula)
        {
            var matriculaParameter = matricula != null ?
                new ObjectParameter("Matricula", matricula) :
                new ObjectParameter("Matricula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ViewAbilitiesUser", matriculaParameter);
        }
    }
}
