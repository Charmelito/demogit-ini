using System;
using System.Collections.Generic;
using Dinamox.Demo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dinamox.Demo.Persistencia.Data;

public partial class SACContext : DbContext
{
    public SACContext()
    {
    }

    public SACContext(DbContextOptions<SACContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AaacommonIndex> AaacommonIndexes { get; set; }

    public virtual DbSet<AcaAcumalarmatipoinc> AcaAcumalarmatipoincs { get; set; }

    public virtual DbSet<AcaAcumcargotipoinc> AcaAcumcargotipoincs { get; set; }

    public virtual DbSet<AcaAlarmanosol> AcaAlarmanosols { get; set; }

    public virtual DbSet<AcaAlarmatipoinc> AcaAlarmatipoincs { get; set; }

    public virtual DbSet<AcaAtencampo> AcaAtencampos { get; set; }

    public virtual DbSet<AcaAtencion> AcaAtencions { get; set; }

    public virtual DbSet<AcaAtendetalle> AcaAtendetalles { get; set; }

    public virtual DbSet<AcaAtendoc> AcaAtendocs { get; set; }

    public virtual DbSet<AcaBuzonatencion> AcaBuzonatencions { get; set; }

    public virtual DbSet<AcaHatencampo> AcaHatencampos { get; set; }

    public virtual DbSet<AcaHatencion> AcaHatencions { get; set; }

    public virtual DbSet<AcaHatendetalle> AcaHatendetalles { get; set; }

    public virtual DbSet<AcaHatendoc> AcaHatendocs { get; set; }

    public virtual DbSet<AcaHincicampo> AcaHincicampos { get; set; }

    public virtual DbSet<AcaHincidencium> AcaHincidencia { get; set; }

    public virtual DbSet<AcaHincidesvio> AcaHincidesvios { get; set; }

    public virtual DbSet<AcaHincidoc> AcaHincidocs { get; set; }

    public virtual DbSet<AcaIncicampo> AcaIncicampos { get; set; }

    public virtual DbSet<AcaIncidencium> AcaIncidencia { get; set; }

    public virtual DbSet<AcaIncidesvio> AcaIncidesvios { get; set; }

    public virtual DbSet<AcaIncidesviofisico> AcaIncidesviofisicos { get; set; }

    public virtual DbSet<AcaIncidoc> AcaIncidocs { get; set; }

    public virtual DbSet<AcaInciventanilla> AcaInciventanillas { get; set; }

    public virtual DbSet<AcaInicidesviofisico> AcaInicidesviofisicos { get; set; }

    public virtual DbSet<AcaMultincidencium> AcaMultincidencia { get; set; }

    public virtual DbSet<AcaObservacione> AcaObservaciones { get; set; }

    public virtual DbSet<AcpCampaniacuest> AcpCampaniacuests { get; set; }

    public virtual DbSet<AcpCampanium> AcpCampania { get; set; }

    public virtual DbSet<AcpCampo> AcpCampos { get; set; }

    public virtual DbSet<AcpCamposBase> AcpCamposBases { get; set; }

    public virtual DbSet<AcpCentroAc> AcpCentroAcs { get; set; }

    public virtual DbSet<AcpCuestionario> AcpCuestionarios { get; set; }

    public virtual DbSet<AcpDatogeneral> AcpDatogenerals { get; set; }

    public virtual DbSet<AcpDiasfest> AcpDiasfests { get; set; }

    public virtual DbSet<AcpErrorcuest> AcpErrorcuests { get; set; }

    public virtual DbSet<AcpExplicacion> AcpExplicacions { get; set; }

    public virtual DbSet<AcpInterlocutor> AcpInterlocutors { get; set; }

    public virtual DbSet<AcpIntertabla> AcpIntertablas { get; set; }

    public virtual DbSet<AcpModoenvio> AcpModoenvios { get; set; }

    public virtual DbSet<AcpNovedad> AcpNovedads { get; set; }

    public virtual DbSet<AcpPreguntum> AcpPregunta { get; set; }

    public virtual DbSet<AcpProceso> AcpProcesos { get; set; }

    public virtual DbSet<AcpProcparam> AcpProcparams { get; set; }

    public virtual DbSet<AcpQyrinternet> AcpQyrinternets { get; set; }

    public virtual DbSet<AcpRespproceso> AcpRespprocesos { get; set; }

    public virtual DbSet<AcpRespuestum> AcpRespuesta { get; set; }

    public virtual DbSet<AcpSector> AcpSectors { get; set; }

    public virtual DbSet<AcpTema> AcpTemas { get; set; }

    public virtual DbSet<AcpTipoatencion> AcpTipoatencions { get; set; }

    public virtual DbSet<AcpTipodocumento> AcpTipodocumentos { get; set; }

    public virtual DbSet<AcpTipoincalarma> AcpTipoincalarmas { get; set; }

    public virtual DbSet<AcpTipoinccampo> AcpTipoinccampos { get; set; }

    public virtual DbSet<AcpTipoinccargo> AcpTipoinccargos { get; set; }

    public virtual DbSet<AcpTipoincidencium> AcpTipoincidencia { get; set; }

    public virtual DbSet<AcpTipoincmodenvio> AcpTipoincmodenvios { get; set; }

    public virtual DbSet<AcpUsusac> AcpUsusacs { get; set; }

    public virtual DbSet<AcrPerfil> AcrPerfils { get; set; }

    public virtual DbSet<AcrPerfilususac> AcrPerfilususacs { get; set; }

    public virtual DbSet<AcrRestradocumento> AcrRestradocumentos { get; set; }

    public virtual DbSet<BdpDataset> BdpDatasets { get; set; }

    public virtual DbSet<BdpTable> BdpTables { get; set; }

    public virtual DbSet<ColAcudiente> ColAcudientes { get; set; }

    public virtual DbSet<ColAgendum> ColAgenda { get; set; }

    public virtual DbSet<ColAsistencium> ColAsistencia { get; set; }

    public virtual DbSet<ColAviso> ColAvisos { get; set; }

    public virtual DbSet<ColComunicado> ColComunicados { get; set; }

    public virtual DbSet<ColEstudiante> ColEstudiantes { get; set; }

    public virtual DbSet<ColEstudianteAcudiente> ColEstudianteAcudientes { get; set; }

    public virtual DbSet<ColEvento> ColEventos { get; set; }

    public virtual DbSet<ColGenero> ColGeneros { get; set; }

    public virtual DbSet<ColGrado> ColGrados { get; set; }

    public virtual DbSet<ColGrupo> ColGrupos { get; set; }

    public virtual DbSet<ColHorario> ColHorarios { get; set; }

    public virtual DbSet<ColMaterium> ColMateria { get; set; }

    public virtual DbSet<ColNotum> ColNota { get; set; }

    public virtual DbSet<ColProfesor> ColProfesors { get; set; }

    public virtual DbSet<ColProfesorMaterium> ColProfesorMateria { get; set; }

    public virtual DbSet<ColSede> ColSedes { get; set; }

    public virtual DbSet<ColUsuario> ColUsuarios { get; set; }

    public virtual DbSet<DbpColumn> DbpColumns { get; set; }

    public virtual DbSet<DbpMasterdetail> DbpMasterdetails { get; set; }

    public virtual DbSet<FluxOldVsNew> FluxOldVsNews { get; set; }

    public virtual DbSet<FluxpObjectType> FluxpObjectTypes { get; set; }

    public virtual DbSet<FluxpObjectTypeChidren> FluxpObjectTypeChidrens { get; set; }

    public virtual DbSet<FluxpProcess> FluxpProcesses { get; set; }

    public virtual DbSet<FluxpProcessFlow> FluxpProcessFlows { get; set; }

    public virtual DbSet<FluxpProcessItem> FluxpProcessItems { get; set; }

    public virtual DbSet<FxpCampoConf> FxpCampoConfs { get; set; }

    public virtual DbSet<FxpGroupingAttr> FxpGroupingAttrs { get; set; }

    public virtual DbSet<FxpObject> FxpObjects { get; set; }

    public virtual DbSet<FxpObjectGroup> FxpObjectGroups { get; set; }

    public virtual DbSet<FxpObjectProp> FxpObjectProps { get; set; }

    public virtual DbSet<FxpProceso> FxpProcesos { get; set; }

    public virtual DbSet<FxpProcesoTipo> FxpProcesoTipos { get; set; }

    public virtual DbSet<FxpProcesoVsParam> FxpProcesoVsParams { get; set; }

    public virtual DbSet<FxpSimularCampo> FxpSimularCampos { get; set; }

    public virtual DbSet<FxpSimularTabla> FxpSimularTablas { get; set; }

    public virtual DbSet<FxpTipoCampo> FxpTipoCampos { get; set; }

    public virtual DbSet<HelperEstructura> HelperEstructuras { get; set; }

    public virtual DbSet<ProMunicipio> ProMunicipios { get; set; }

    public virtual DbSet<ProProveedore> ProProveedores { get; set; }

    public virtual DbSet<ProTipoCompra> ProTipoCompras { get; set; }

    public virtual DbSet<SegFieldPermission> SegFieldPermissions { get; set; }

    public virtual DbSet<SegMenuModule> SegMenuModules { get; set; }

    public virtual DbSet<SegMenuPermission> SegMenuPermissions { get; set; }

    public virtual DbSet<SegRole> SegRoles { get; set; }

    public virtual DbSet<SegRowsPermission> SegRowsPermissions { get; set; }

    public virtual DbSet<SegSystemTable> SegSystemTables { get; set; }

    public virtual DbSet<SegTableField> SegTableFields { get; set; }

    public virtual DbSet<SegTablePermission> SegTablePermissions { get; set; }

    public virtual DbSet<SegTableRow> SegTableRows { get; set; }

    public virtual DbSet<SegTypeQuery> SegTypeQueries { get; set; }

    public virtual DbSet<SegUser> SegUsers { get; set; }

    public virtual DbSet<SegUserRole> SegUserRoles { get; set; }

    public virtual DbSet<Table3> Table3s { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-B8Q86JK\\SQLEXPRESS;Database=SAC;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AaacommonIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AAACOMMON_INDEXES");

            entity.Property(e => e.IndexName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INDEX_NAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<AcaAcumalarmatipoinc>(entity =>
        {
            entity.HasKey(e => e.TipIncidencia)
                .HasName("PK__ACA_ACUM__00E287802D8A4370")
                .IsClustered(false);

            entity.ToTable("ACA_ACUMALARMATIPOINC");

            entity.Property(e => e.TipIncidencia)
                .ValueGeneratedNever()
                .HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.FecPrimera)
                .HasColumnType("datetime")
                .HasColumnName("FEC_PRIMERA");
            entity.Property(e => e.FecUltima)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ULTIMA");
            entity.Property(e => e.NumAcumulado).HasColumnName("NUM_ACUMULADO");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithOne(p => p.AcaAcumalarmatipoinc)
                .HasForeignKey<AcaAcumalarmatipoinc>(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACACAL_ACTINC");
        });

        modelBuilder.Entity<AcaAcumcargotipoinc>(entity =>
        {
            entity.HasKey(e => new { e.TipIncidencia, e.TipInterlocutor, e.CodInterlocutor })
                .HasName("PK__ACA_ACUM__66123ED3FD67D319")
                .IsClustered(false);

            entity.ToTable("ACA_ACUMCARGOTIPOINC");

            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.TipInterlocutor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.CodInterlocutor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_INTERLOCUTOR");
            entity.Property(e => e.CodProducto)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("COD_PRODUCTO");
            entity.Property(e => e.FecPrimera)
                .HasColumnType("datetime")
                .HasColumnName("FEC_PRIMERA");
            entity.Property(e => e.FecUltima)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ULTIMA");
            entity.Property(e => e.NumAcumulado)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_ACUMULADO");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcaAcumcargotipoincs)
                .HasForeignKey(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACACCA_ACTINC");
        });

        modelBuilder.Entity<AcaAlarmanosol>(entity =>
        {
            entity.HasKey(e => e.NumIncidencia)
                .HasName("PK__ACA_ALAR__386E21FE2094513D")
                .IsClustered(false);

            entity.ToTable("ACA_ALARMANOSOL");

            entity.Property(e => e.NumIncidencia)
                .ValueGeneratedNever()
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.IndMostrar).HasColumnName("IND_MOSTRAR");
            entity.Property(e => e.IndReclamo).HasColumnName("IND_RECLAMO");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithOne(p => p.AcaAlarmanosol)
                .HasForeignKey<AcaAlarmanosol>(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACALNS_ACINCI");
        });

        modelBuilder.Entity<AcaAlarmatipoinc>(entity =>
        {
            entity.HasKey(e => new { e.TipIncidencia, e.FecAlarma })
                .HasName("PK__ACA_ALAR__516C82518D1FE1E5")
                .IsClustered(false);

            entity.ToTable("ACA_ALARMATIPOINC");

            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.FecAlarma)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ALARMA");
            entity.Property(e => e.IndMostrar).HasColumnName("IND_MOSTRAR");
        });

        modelBuilder.Entity<AcaAtencampo>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.CodCampo })
                .HasName("PK__ACA_ATEN__7DA7FE23FB5EAD93")
                .IsClustered(false);

            entity.ToTable("ACA_ATENCAMPO");

            entity.Property(e => e.NumAtencion).HasColumnName("NUM_ATENCION");
            entity.Property(e => e.CodCampo).HasColumnName("COD_CAMPO");
            entity.Property(e => e.IndTipo).HasColumnName("IND_TIPO");
            entity.Property(e => e.TipCampo)
                .HasMaxLength(50)
                .HasColumnName("TIP_CAMPO");
            entity.Property(e => e.ValCampo)
                .HasMaxLength(2000)
                .HasColumnName("VAL_CAMPO");

            entity.HasOne(d => d.CodCampoNavigation).WithMany(p => p.AcaAtencampos)
                .HasForeignKey(d => d.CodCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATEC_ACCMPO");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaAtencampos)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATEC_ACATEN");
        });

        modelBuilder.Entity<AcaAtencion>(entity =>
        {
            entity.HasKey(e => e.NumAtencion)
                .HasName("PK__ACA_ATEN__9187396C6CCA78E1")
                .IsClustered(false);

            entity.ToTable("ACA_ATENCION");

            entity.Property(e => e.NumAtencion)
                .ValueGeneratedNever()
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.CodCampania).HasColumnName("COD_CAMPANIA");
            entity.Property(e => e.FecAtencion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ATENCION");
            entity.Property(e => e.IndEnviomail).HasColumnName("IND_ENVIOMAIL");
            entity.Property(e => e.IndSimulado).HasColumnName("IND_SIMULADO");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORA");

            entity.HasOne(d => d.CodCampaniaNavigation).WithMany(p => p.AcaAtencions)
                .HasForeignKey(d => d.CodCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATEN_ACCAMP");

            entity.HasOne(d => d.NomUsuaroraNavigation).WithMany(p => p.AcaAtencions)
                .HasForeignKey(d => d.NomUsuarora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATEN_ACUSSA");
        });

        modelBuilder.Entity<AcaAtendetalle>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.NumOrden })
                .HasName("PK__ACA_ATEN__47D26E28A5FD52E8")
                .IsClustered(false);

            entity.ToTable("ACA_ATENDETALLE");

            entity.Property(e => e.NumAtencion).HasColumnName("NUM_ATENCION");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaAtendetalles)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATED_ACATEN");

            entity.HasOne(d => d.AcpRespuestum).WithMany(p => p.AcaAtendetalles)
                .HasForeignKey(d => new { d.CodCuestionario, d.NumPregunta, d.NumRespuesta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATED_ACRESP");
        });

        modelBuilder.Entity<AcaAtendoc>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.TipDocumento })
                .HasName("PK__ACA_ATEN__209D7E807179C170")
                .IsClustered(false);

            entity.ToTable("ACA_ATENDOC");

            entity.Property(e => e.NumAtencion).HasColumnName("NUM_ATENCION");
            entity.Property(e => e.TipDocumento).HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.CodModoenvio).HasColumnName("COD_MODOENVIO");
            entity.Property(e => e.IndTipo).HasColumnName("IND_TIPO");

            entity.HasOne(d => d.CodModoenvioNavigation).WithMany(p => p.AcaAtendocs)
                .HasForeignKey(d => d.CodModoenvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATDO_ACMOEN");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaAtendocs)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATDO_ACATEN");

            entity.HasOne(d => d.TipDocumentoNavigation).WithMany(p => p.AcaAtendocs)
                .HasForeignKey(d => d.TipDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACATDO_ACTIPD");
        });

        modelBuilder.Entity<AcaBuzonatencion>(entity =>
        {
            entity.HasKey(e => e.NumAtencion)
                .HasName("PK__ACA_BUZO__9187396CE49E4AA7")
                .IsClustered(false);

            entity.ToTable("ACA_BUZONATENCION");

            entity.Property(e => e.NumAtencion)
                .ValueGeneratedNever()
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.CodInterlocutor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_INTERLOCUTOR");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.FecBuzonatencion)
                .HasDefaultValueSql("(getdate())", "DF__ACA_BUZON__FEC_B__02084FDA")
                .HasColumnType("datetime")
                .HasColumnName("FEC_BUZONATENCION");
            entity.Property(e => e.NomUsuarorade)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORADE");
            entity.Property(e => e.NomUsuaroraor)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORAOR");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.TipInterlocutor)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_INTERLOCUTOR");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcaBuzonatencions)
                .HasForeignKey(d => d.CodSector)
                .HasConstraintName("FK_ACBUZA_ACSECT");

            entity.HasOne(d => d.NomUsuaroraorNavigation).WithMany(p => p.AcaBuzonatencions)
                .HasForeignKey(d => d.NomUsuaroraor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBUZA_ACUSSA");

            entity.HasOne(d => d.NumAtencionNavigation).WithOne(p => p.AcaBuzonatencion)
                .HasForeignKey<AcaBuzonatencion>(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACBUZA_ACRESU");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcaBuzonatencions)
                .HasForeignKey(d => d.TipIncidencia)
                .HasConstraintName("FK_ACBUZA_ACTINC");
        });

        modelBuilder.Entity<AcaHatencampo>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.CodCampo })
                .HasName("PK__ACA_HATE__7DA7FE23BEFAAEBA")
                .IsClustered(false);

            entity.ToTable("ACA_HATENCAMPO");

            entity.Property(e => e.NumAtencion)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.CodCampo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CAMPO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.TipCampo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIP_CAMPO");
            entity.Property(e => e.ValCampo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("VAL_CAMPO");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaHatencampos)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHATC_ACHATE");
        });

        modelBuilder.Entity<AcaHatencion>(entity =>
        {
            entity.HasKey(e => e.NumAtencion)
                .HasName("PK__ACA_HATE__9187396C9F3EB1C2")
                .IsClustered(false);

            entity.ToTable("ACA_HATENCION");

            entity.Property(e => e.NumAtencion)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.CodCampania)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("COD_CAMPANIA");
            entity.Property(e => e.FecAtencion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ATENCION");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORA");
        });

        modelBuilder.Entity<AcaHatendetalle>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.NumOrden })
                .HasName("PK__ACA_HATE__47D26E28835CBDCD")
                .IsClustered(false);

            entity.ToTable("ACA_HATENDETALLE");

            entity.Property(e => e.NumAtencion)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaHatendetalles)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHATD_ACHATE");
        });

        modelBuilder.Entity<AcaHatendoc>(entity =>
        {
            entity.HasKey(e => new { e.NumAtencion, e.TipDocumento })
                .HasName("PK__ACA_HATE__209D7E80B3853C93")
                .IsClustered(false);

            entity.ToTable("ACA_HATENDOC");

            entity.Property(e => e.NumAtencion)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.TipDocumento)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.CodModoenvio)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("COD_MODOENVIO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaHatendocs)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHADO_ACHATE");
        });

        modelBuilder.Entity<AcaHincicampo>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.CodCampo, e.IndTipo })
                .HasName("PK__ACA_HINC__FE9F140698C11747")
                .IsClustered(false);

            entity.ToTable("ACA_HINCICAMPO");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.CodCampo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CAMPO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.TipCampo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIP_CAMPO");
            entity.Property(e => e.ValCampo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("VAL_CAMPO");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaHincicampos)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHICA_ACHINC");
        });

        modelBuilder.Entity<AcaHincidencium>(entity =>
        {
            entity.HasKey(e => e.NumIncidencia)
                .HasName("PK__ACA_HINC__386E21FEEBF26726")
                .IsClustered(false);

            entity.ToTable("ACA_HINCIDENCIA");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.CodCentroAc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CENTRO_AC");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodInterlocutor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_INTERLOCUTOR");
            entity.Property(e => e.CodSectordesv)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("COD_SECTORDESV");
            entity.Property(e => e.FecAlarma)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ALARMA");
            entity.Property(e => e.FecComunica)
                .HasColumnType("datetime")
                .HasColumnName("FEC_COMUNICA");
            entity.Property(e => e.FecCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_CREACION");
            entity.Property(e => e.FecEstimada)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ESTIMADA");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())", "DF__ACA_HINCI__FEC_H__0B91BA14")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.FecImpresion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_IMPRESION");
            entity.Property(e => e.FecReal)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REAL");
            entity.Property(e => e.FecRompimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ROMPIMIENTO");
            entity.Property(e => e.IndTratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IND_TRATAMIENTO");
            entity.Property(e => e.NomUsuaroraco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORACO");
            entity.Property(e => e.NomUsuaroracr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORACR");
            entity.Property(e => e.NomUsuarorarom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORAROM");
            entity.Property(e => e.NomUsuaroraso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORASO");
            entity.Property(e => e.NumAtencion)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_ATENCION");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
            entity.Property(e => e.TipIncidencia)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.TipInter)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_INTER");
            entity.Property(e => e.TipInterlocutor).HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.TipSolucion)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("TIP_SOLUCION");

            entity.HasOne(d => d.TipInterlocutorNavigation).WithMany(p => p.AcaHincidencia)
                .HasForeignKey(d => d.TipInterlocutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHINC_ACINTE");
        });

        modelBuilder.Entity<AcaHincidesvio>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.FecEntrada, e.CodSector })
                .HasName("PK__ACA_HINC__463EB10B47F9ED68")
                .IsClustered(false);

            entity.ToTable("ACA_HINCIDESVIO");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.FecEntrada)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ENTRADA");
            entity.Property(e => e.CodSector)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("COD_SECTOR");
            entity.Property(e => e.CodProceso)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("COD_PROCESO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.NomResponsable)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOM_RESPONSABLE");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaHincidesvios)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHIND_ACHINC");
        });

        modelBuilder.Entity<AcaHincidoc>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.TipDocumento, e.IndTipo })
                .HasName("PK__ACA_HINC__A3A594A574A1D377")
                .IsClustered(false);

            entity.ToTable("ACA_HINCIDOC");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.TipDocumento)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.CodModoenvio)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("COD_MODOENVIO");
            entity.Property(e => e.FecHistorico)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FEC_HISTORICO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaHincidocs)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACHIDO_ACHINC");
        });

        modelBuilder.Entity<AcaIncicampo>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.CodCampo, e.IndTipo })
                .HasName("PK__ACA_INCI__FE9F1406532A1FB0")
                .IsClustered(false);

            entity.ToTable("ACA_INCICAMPO");

            entity.Property(e => e.NumIncidencia).HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.CodCampo).HasColumnName("COD_CAMPO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.TipCampo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TIP_CAMPO");
            entity.Property(e => e.ValCampo)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("VAL_CAMPO");

            entity.HasOne(d => d.CodCampoNavigation).WithMany(p => p.AcaIncicampos)
                .HasForeignKey(d => d.CodCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCA_ACCMPO");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaIncicampos)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCA_ACINCI");
        });

        modelBuilder.Entity<AcaIncidencium>(entity =>
        {
            entity.HasKey(e => e.NumIncidencia)
                .HasName("PK__ACA_INCI__386E21FED6AD8A68")
                .IsClustered(false);

            entity.ToTable("ACA_INCIDENCIA");

            entity.Property(e => e.NumIncidencia)
                .ValueGeneratedNever()
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.CodCentroAc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CENTRO_AC");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodEstadoant)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADOANT");
            entity.Property(e => e.CodInterlocutor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_INTERLOCUTOR");
            entity.Property(e => e.CodSectordesv).HasColumnName("COD_SECTORDESV");
            entity.Property(e => e.FecAlarma)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ALARMA");
            entity.Property(e => e.FecComunica)
                .HasColumnType("datetime")
                .HasColumnName("FEC_COMUNICA");
            entity.Property(e => e.FecCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_CREACION");
            entity.Property(e => e.FecEstimada)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ESTIMADA");
            entity.Property(e => e.FecImpresion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_IMPRESION");
            entity.Property(e => e.FecReal)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REAL");
            entity.Property(e => e.FecRompimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ROMPIMIENTO");
            entity.Property(e => e.IndTratamiento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IND_TRATAMIENTO");
            entity.Property(e => e.NomUsuaroraco)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORACO");
            entity.Property(e => e.NomUsuaroracr)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORACR");
            entity.Property(e => e.NomUsuarorarom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORAROM");
            entity.Property(e => e.NomUsuaroraso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORASO");
            entity.Property(e => e.NumAtencion).HasColumnName("NUM_ATENCION");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.TipInter)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_INTER");
            entity.Property(e => e.TipInterlocutor).HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.TipSolucion)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("TIP_SOLUCION");

            entity.HasOne(d => d.CodSectordesvNavigation).WithMany(p => p.AcaIncidencia)
                .HasForeignKey(d => d.CodSectordesv)
                .HasConstraintName("FK_ACINCI_ACSECT");

            entity.HasOne(d => d.NomUsuaroracrNavigation).WithMany(p => p.AcaIncidencia)
                .HasForeignKey(d => d.NomUsuaroracr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCI_ACUSSA");

            entity.HasOne(d => d.NumAtencionNavigation).WithMany(p => p.AcaIncidencia)
                .HasForeignKey(d => d.NumAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCI_ACRESU");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcaIncidencia)
                .HasForeignKey(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCI_ACTINC");

            entity.HasOne(d => d.TipInterlocutorNavigation).WithMany(p => p.AcaIncidencia)
                .HasForeignKey(d => d.TipInterlocutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINCI_ACINTE");
        });

        modelBuilder.Entity<AcaIncidesvio>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.FecEntrada, e.CodSector })
                .HasName("PK__ACA_INCI__463EB10B9ADDFE58")
                .IsClustered(false);

            entity.ToTable("ACA_INCIDESVIO");

            entity.Property(e => e.NumIncidencia).HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.FecEntrada)
                .HasDefaultValueSql("(getdate())", "DF__ACA_INCID__FEC_E__1F98B2C1")
                .HasColumnType("datetime")
                .HasColumnName("FEC_ENTRADA");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.CodProceso)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("COD_PROCESO");
            entity.Property(e => e.NomResponsable)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NOM_RESPONSABLE");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcaIncidesvios)
                .HasForeignKey(d => d.CodSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDE_ACSECT");

            entity.HasOne(d => d.NomUsuaroraNavigation).WithMany(p => p.AcaIncidesvios)
                .HasForeignKey(d => d.NomUsuarora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDE_ACUSSA");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaIncidesvios)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDE_ACINCI");
        });

        modelBuilder.Entity<AcaIncidesviofisico>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACA_INCIDESVIOFISICO");

            entity.Property(e => e.CodProceso)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("COD_PROCESO");
            entity.Property(e => e.FecEntradafis)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ENTRADAFIS");
            entity.Property(e => e.NomUsuarorafisi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORAFISI");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
        });

        modelBuilder.Entity<AcaIncidoc>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.TipDocumento, e.IndTipo })
                .HasName("PK__ACA_INCI__A3A594A599D1A9EB")
                .IsClustered(false);

            entity.ToTable("ACA_INCIDOC");

            entity.Property(e => e.NumIncidencia).HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.TipDocumento).HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.CodModoenvio).HasColumnName("COD_MODOENVIO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodModoenvioNavigation).WithMany(p => p.AcaIncidocs)
                .HasForeignKey(d => d.CodModoenvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDO_ACMOEN");

            entity.HasOne(d => d.NumIncidenciaNavigation).WithMany(p => p.AcaIncidocs)
                .HasForeignKey(d => d.NumIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDO_ACINCI");

            entity.HasOne(d => d.TipDocumentoNavigation).WithMany(p => p.AcaIncidocs)
                .HasForeignKey(d => d.TipDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINDO_ACTIPD");
        });

        modelBuilder.Entity<AcaInciventanilla>(entity =>
        {
            entity.HasKey(e => e.NumInciventanilla)
                .HasName("PK__ACA_INCI__87F658FB51DAF303")
                .IsClustered(false);

            entity.ToTable("ACA_INCIVENTANILLA");

            entity.Property(e => e.NumInciventanilla)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIVENTANILLA");
            entity.Property(e => e.CodAbonado)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("COD_ABONADO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.FecCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_CREACION");
            entity.Property(e => e.NomUsuaroracr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORACR");
            entity.Property(e => e.NumRadicado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUM_RADICADO");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");
            entity.Property(e => e.NumTelefono)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUM_TELEFONO");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
            entity.Property(e => e.TipIncidencia)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.TipTramite)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_TRAMITE");
            entity.Property(e => e.ValReclamado)
                .HasColumnType("numeric(14, 4)")
                .HasColumnName("VAL_RECLAMADO");
        });

        modelBuilder.Entity<AcaInicidesviofisico>(entity =>
        {
            entity.HasKey(e => e.CodProceso)
                .HasName("PK__ACA_INIC__ECB81FBE85A90A9A")
                .IsClustered(false);

            entity.ToTable("ACA_INICIDESVIOFISICO");

            entity.Property(e => e.CodProceso)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("COD_PROCESO");
            entity.Property(e => e.FecEntradafis)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ENTRADAFIS");
            entity.Property(e => e.NomUsuarorafisi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORAFISI");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
        });

        modelBuilder.Entity<AcaMultincidencium>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.FecCreacion })
                .HasName("PK__ACA_MULT__FE4CE3775D91C0C6")
                .IsClustered(false);

            entity.ToTable("ACA_MULTINCIDENCIA");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.FecCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_CREACION");
            entity.Property(e => e.TipIncidencia)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIP_INCIDENCIA");
        });

        modelBuilder.Entity<AcaObservacione>(entity =>
        {
            entity.HasKey(e => new { e.NumIncidencia, e.FecObservacion })
                .HasName("PK__ACA_OBSE__790C9CC68259B7E7")
                .IsClustered(false);

            entity.ToTable("ACA_OBSERVACIONES");

            entity.Property(e => e.NumIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NUM_INCIDENCIA");
            entity.Property(e => e.FecObservacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_OBSERVACION");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodIncisector).HasColumnName("COD_INCISECTOR");
            entity.Property(e => e.CodUsusector).HasColumnName("COD_USUSECTOR");
            entity.Property(e => e.IndIncidencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("IND_INCIDENCIA");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(user_name())", "DF__ACA_OBSER__NOM_U__2B0A656D")
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.ObsDetalle)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("OBS_DETALLE");

            entity.HasOne(d => d.CodIncisectorNavigation).WithMany(p => p.AcaObservacioneCodIncisectorNavigations)
                .HasForeignKey(d => d.CodIncisector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACA_OBSE_INCISECTOR");

            entity.HasOne(d => d.CodUsusectorNavigation).WithMany(p => p.AcaObservacioneCodUsusectorNavigations)
                .HasForeignKey(d => d.CodUsusector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACA_OBSE_SECTOR");
        });

        modelBuilder.Entity<AcpCampaniacuest>(entity =>
        {
            entity.HasKey(e => new { e.CodCampania, e.CodCuestionario })
                .HasName("PK__ACP_CAMP__A2B7058683A0A8C2")
                .IsClustered(false);

            entity.ToTable("ACP_CAMPANIACUEST");

            entity.Property(e => e.CodCampania).HasColumnName("COD_CAMPANIA");
            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodCampaniaNavigation).WithMany(p => p.AcpCampaniacuests)
                .HasForeignKey(d => d.CodCampania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCACU_ACCAMP");

            entity.HasOne(d => d.CodCuestionarioNavigation).WithMany(p => p.AcpCampaniacuests)
                .HasForeignKey(d => d.CodCuestionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCACU_ACCUES");
        });

        modelBuilder.Entity<AcpCampanium>(entity =>
        {
            entity.HasKey(e => e.CodCampania)
                .HasName("PK__ACP_CAMP__F6CCF140C82953F6")
                .IsClustered(false);

            entity.ToTable("ACP_CAMPANIA");

            entity.Property(e => e.CodCampania)
                .ValueGeneratedNever()
                .HasColumnName("COD_CAMPANIA");
            entity.Property(e => e.CodAtencion)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("COD_ATENCION");
            entity.Property(e => e.DesCampania)
                .HasMaxLength(50)
                .HasColumnName("DES_CAMPANIA");
            entity.Property(e => e.IndEnviomail).HasColumnName("IND_ENVIOMAIL");
            entity.Property(e => e.IndHistorico).HasColumnName("IND_HISTORICO");

            entity.HasOne(d => d.CodAtencionNavigation).WithMany(p => p.AcpCampania)
                .HasForeignKey(d => d.CodAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AC_ACCAMP_ACTIPA");
        });

        modelBuilder.Entity<AcpCampo>(entity =>
        {
            entity.HasKey(e => e.CodCampo)
                .HasName("PK__ACP_CAMP__C20C74FEE42BF54A")
                .IsClustered(false);

            entity.ToTable("ACP_CAMPO");

            entity.Property(e => e.CodCampo)
                .HasComment("Identificador del campo ")
                .HasColumnName("COD_CAMPO");
            entity.Property(e => e.IdSimularTabla)
                .HasComment("Origen donde buscara los datos de la lista")
                .HasColumnName("ID_SIMULAR_TABLA");
            entity.Property(e => e.JsnConfig)
                .HasMaxLength(4000)
                .HasComment("Objeto que representa el PropertyAttribute")
                .HasColumnName("JSN_CONFIG");
            entity.Property(e => e.LonCampo)
                .HasComment("Longitud o tamaño a ingresar")
                .HasColumnName("LON_CAMPO");
            entity.Property(e => e.NomCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre a guardar del campo, no puede estar separado por espacios")
                .HasColumnName("NOM_CAMPO");
            entity.Property(e => e.TipCampo)
                .HasComment("Tipo de campo ")
                .HasColumnName("TIP_CAMPO");

            entity.HasOne(d => d.IdSimularTablaNavigation).WithMany(p => p.AcpCampos)
                .HasForeignKey(d => d.IdSimularTabla)
                .HasConstraintName("FK_ACP_CAMPO_FXP_SIMULAR_TABLA");

            entity.HasOne(d => d.TipCampoNavigation).WithMany(p => p.AcpCampos)
                .HasForeignKey(d => d.TipCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACP_CAMPO_FXP_TIPO_CAMPOS");
        });

        modelBuilder.Entity<AcpCamposBase>(entity =>
        {
            entity.HasKey(e => new { e.CodTablaBase, e.CodCampoWhere })
                .HasName("PK__ACP_CAMP__5A04A5B0551A66C6")
                .IsClustered(false);

            entity.ToTable("ACP_CAMPOS_BASE");

            entity.Property(e => e.CodTablaBase)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COD_TABLA_BASE");
            entity.Property(e => e.CodCampoWhere)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_CAMPO_WHERE");
            entity.Property(e => e.DesCampoWhere)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_CAMPO_WHERE");
        });

        modelBuilder.Entity<AcpCentroAc>(entity =>
        {
            entity.HasKey(e => e.CodCentroAc)
                .HasName("PK__ACP_CENT__9A10573FED3C6EA3")
                .IsClustered(false);

            entity.ToTable("ACP_CENTRO_AC");

            entity.Property(e => e.CodCentroAc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CENTRO_AC");
            entity.Property(e => e.DesCentroAc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DES_CENTRO_AC");
            entity.Property(e => e.DirCentroAc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DIR_CENTRO_AC");
        });

        modelBuilder.Entity<AcpCuestionario>(entity =>
        {
            entity.HasKey(e => e.CodCuestionario)
                .HasName("PK__ACP_CUES__47BF4C654120C64F")
                .IsClustered(false);

            entity.ToTable("ACP_CUESTIONARIO");

            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.DesCuestionario)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DES_CUESTIONARIO");
            entity.Property(e => e.FecCreacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_CREACION");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARORA");
        });

        modelBuilder.Entity<AcpDatogeneral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACP_DATOGENERAL");

            entity.Property(e => e.CodCampinternet)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("COD_CAMPINTERNET");
            entity.Property(e => e.CodConcepto)
                .HasComment("Código del concepto")
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_CONCEPTO");
            entity.Property(e => e.CodReportRuptura)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("COD_REPORT_RUPTURA");
            entity.Property(e => e.NomEmpresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Nombre de la empresa")
                .HasColumnName("NOM_EMPRESA");
            entity.Property(e => e.NomNemoempresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_NEMOEMPRESA");
            entity.Property(e => e.NomUsuarorapropt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Usuario dueño de las tablas")
                .HasColumnName("NOM_USUARORAPROPT");
            entity.Property(e => e.NomUsujefeac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUJEFEAC");
            entity.Property(e => e.NumCertiso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NUM_CERTISO");
            entity.Property(e => e.NumDiaromp)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_DIAROMP");
            entity.Property(e => e.NumHoraromp)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_HORAROMP");
            entity.Property(e => e.NumIdentifica)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUM_IDENTIFICA");
            entity.Property(e => e.NumIdentificanuir)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUM_IDENTIFICANUIR");
            entity.Property(e => e.NumMinutoalarma)
                .HasComment("Numero del minuto de la alarma")
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_MINUTOALARMA");
            entity.Property(e => e.Pathreports)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PATHREPORTS");

            entity.HasOne(d => d.CodReportRupturaNavigation).WithMany()
                .HasForeignKey(d => d.CodReportRuptura)
                .HasConstraintName("FK_ACDAGE_ACPROC");
        });

        modelBuilder.Entity<AcpDiasfest>(entity =>
        {
            entity.HasKey(e => e.FecDiafest)
                .HasName("PK__ACP_DIAS__E6A149EACA5D776C")
                .IsClustered(false);

            entity.ToTable("ACP_DIASFEST", tb => tb.HasComment("Manejo de los días Festivos"));

            entity.Property(e => e.FecDiafest)
                .HasComment("Dia festivo, en formato fecha")
                .HasColumnName("FEC_DIAFEST");
            entity.Property(e => e.DesDiafest)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Descripción del día festivo")
                .HasColumnName("DES_DIAFEST");
        });

        modelBuilder.Entity<AcpErrorcuest>(entity =>
        {
            entity.HasKey(e => new { e.CodCuestionario, e.NumPregunta, e.NumRespuesta })
                .HasName("PK__ACP_ERRO__19E0A7D2C6945E45")
                .IsClustered(false);

            entity.ToTable("ACP_ERRORCUEST");

            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");
        });

        modelBuilder.Entity<AcpExplicacion>(entity =>
        {
            entity.HasKey(e => e.CodExplicacion)
                .HasName("PK__ACP_EXPL__418079CFB6BACACA")
                .IsClustered(false);

            entity.ToTable("ACP_EXPLICACION");

            entity.Property(e => e.CodExplicacion)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_EXPLICACION");
            entity.Property(e => e.DesExplicacion)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DES_EXPLICACION");
            entity.Property(e => e.ObsExplicacion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_EXPLICACION");
        });

        modelBuilder.Entity<AcpInterlocutor>(entity =>
        {
            entity.HasKey(e => e.TipInterlocutor)
                .HasName("PK__ACP_INTE__2B37FE9656F2EDA1")
                .IsClustered(false);

            entity.ToTable("ACP_INTERLOCUTOR");

            entity.Property(e => e.TipInterlocutor)
                .ValueGeneratedNever()
                .HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.DesInterlocutor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DES_INTERLOCUTOR");
        });

        modelBuilder.Entity<AcpIntertabla>(entity =>
        {
            entity.HasKey(e => new { e.TipInterlocutor, e.NomTabla })
                .HasName("PK__ACP_INTE__1B108964761121C3")
                .IsClustered(false);

            entity.ToTable("ACP_INTERTABLA");

            entity.Property(e => e.TipInterlocutor).HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.NomTabla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_TABLA");

            entity.HasOne(d => d.TipInterlocutorNavigation).WithMany(p => p.AcpIntertablas)
                .HasForeignKey(d => d.TipInterlocutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACINTA_ACINTE");
        });

        modelBuilder.Entity<AcpModoenvio>(entity =>
        {
            entity.HasKey(e => e.CodModoenvio)
                .HasName("PK__ACP_MODO__00FFB3AFAE5A2E74")
                .IsClustered(false);

            entity.ToTable("ACP_MODOENVIO");

            entity.Property(e => e.CodModoenvio)
                .ValueGeneratedNever()
                .HasColumnName("COD_MODOENVIO");
            entity.Property(e => e.DesModoenvio)
                .HasMaxLength(50)
                .HasColumnName("DES_MODOENVIO");
        });

        modelBuilder.Entity<AcpNovedad>(entity =>
        {
            entity.HasKey(e => e.CodNovedad)
                .HasName("PK__ACP_NOVE__270CBC350E23768F")
                .IsClustered(false);

            entity.ToTable("ACP_NOVEDAD");

            entity.Property(e => e.CodNovedad)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_NOVEDAD");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.DesNovedad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_NOVEDAD");
            entity.Property(e => e.FecFinal)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FINAL");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
            entity.Property(e => e.ObsNovedad)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("OBS_NOVEDAD");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcpNovedads)
                .HasForeignKey(d => d.CodSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACNOVE_ACSECT");
        });

        modelBuilder.Entity<AcpPreguntum>(entity =>
        {
            entity.HasKey(e => new { e.CodCuestionario, e.NumPregunta })
                .HasName("PK__ACP_PREG__98923EA0FA383FA3")
                .IsClustered(false);

            entity.ToTable("ACP_PREGUNTA");

            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.CodExplicacion)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_EXPLICACION");
            entity.Property(e => e.DesPregunta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PREGUNTA");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodCuestionarioNavigation).WithMany(p => p.AcpPregunta)
                .HasForeignKey(d => d.CodCuestionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPREG_ACCUES");

            entity.HasOne(d => d.CodExplicacionNavigation).WithMany(p => p.AcpPregunta)
                .HasForeignKey(d => d.CodExplicacion)
                .HasConstraintName("FK_ACPREG_ACEXPL");
        });

        modelBuilder.Entity<AcpProceso>(entity =>
        {
            entity.HasKey(e => e.CodProcsac)
                .HasName("PK__ACP_PROC__8C84E6F9F7BD11D0")
                .IsClustered(false);

            entity.ToTable("ACP_PROCESO");

            entity.Property(e => e.CodProcsac)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("COD_PROCSAC");
            entity.Property(e => e.CodProceso)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("COD_PROCESO");
            entity.Property(e => e.CodPrograma)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("COD_PROGRAMA");
            entity.Property(e => e.DesProcsac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_PROCSAC");
            entity.Property(e => e.NomFichero)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOM_FICHERO");
            entity.Property(e => e.NumSubversion).HasColumnName("NUM_SUBVERSION");
            entity.Property(e => e.NumVersion).HasColumnName("NUM_VERSION");
            entity.Property(e => e.TipInterlocutor).HasColumnName("TIP_INTERLOCUTOR");
            entity.Property(e => e.TipProceso).HasColumnName("TIP_PROCESO");

            entity.HasOne(d => d.TipInterlocutorNavigation).WithMany(p => p.AcpProcesos)
                .HasForeignKey(d => d.TipInterlocutor)
                .HasConstraintName("FK_ACPROC_ACINTE");
        });

        modelBuilder.Entity<AcpProcparam>(entity =>
        {
            entity.HasKey(e => new { e.CodProcsac, e.CodCampo })
                .HasName("PK__ACP_PROC__60A421B6F916D09C")
                .IsClustered(false);

            entity.ToTable("ACP_PROCPARAM");

            entity.Property(e => e.CodProcsac)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("COD_PROCSAC");
            entity.Property(e => e.CodCampo).HasColumnName("COD_CAMPO");
            entity.Property(e => e.IndTipoparam)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPOPARAM");
            entity.Property(e => e.NomTabcampo)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("NOM_TABCAMPO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodCampoNavigation).WithMany(p => p.AcpProcparams)
                .HasForeignKey(d => d.CodCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPROP_ACCMPO");

            entity.HasOne(d => d.CodProcsacNavigation).WithMany(p => p.AcpProcparams)
                .HasForeignKey(d => d.CodProcsac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPROP_ACPROC");
        });

        modelBuilder.Entity<AcpQyrinternet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACP_QYRINTERNET");

            entity.Property(e => e.ApelQuejoso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APEL_QUEJOSO");
            entity.Property(e => e.DirQuejoso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIR_QUEJOSO");
            entity.Property(e => e.EmailQuejoso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_QUEJOSO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.NomQuejoso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_QUEJOSO");
            entity.Property(e => e.NroIncidencia)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("NRO_INCIDENCIA");
            entity.Property(e => e.NroRadportal)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NRO_RADPORTAL");
            entity.Property(e => e.NumIdentificacion)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("NUM_IDENTIFICACION");
            entity.Property(e => e.NumTelefono)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("NUM_TELEFONO");
            entity.Property(e => e.ObsComentario)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("OBS_COMENTARIO");
            entity.Property(e => e.TelQuejoso)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("TEL_QUEJOSO");
            entity.Property(e => e.TipIdentificacion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("TIP_IDENTIFICACION");
            entity.Property(e => e.TipIncidencia)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("TIP_INCIDENCIA");
        });

        modelBuilder.Entity<AcpRespproceso>(entity =>
        {
            entity.HasKey(e => new { e.CodCuestionario, e.NumPregunta, e.NumRespuesta, e.NumOrden })
                .HasName("PK__ACP_RESP__5D36F285190E836E")
                .IsClustered(false);

            entity.ToTable("ACP_RESPPROCESO");

            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.CodProcsac)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("COD_PROCSAC");

            entity.HasOne(d => d.CodProcsacNavigation).WithMany(p => p.AcpRespprocesos)
                .HasForeignKey(d => d.CodProcsac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACREPR_ACPROC");

            entity.HasOne(d => d.AcpRespuestum).WithMany(p => p.AcpRespprocesos)
                .HasForeignKey(d => new { d.CodCuestionario, d.NumPregunta, d.NumRespuesta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACREPR_ACRESP");
        });

        modelBuilder.Entity<AcpRespuestum>(entity =>
        {
            entity.HasKey(e => new { e.CodCuestionario, e.NumPregunta, e.NumRespuesta })
                .HasName("PK__ACP_RESP__19E0A7D240D228AE")
                .IsClustered(false);

            entity.ToTable("ACP_RESPUESTA");

            entity.Property(e => e.CodCuestionario)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTIONARIO");
            entity.Property(e => e.NumPregunta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGUNTA");
            entity.Property(e => e.NumRespuesta)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_RESPUESTA");
            entity.Property(e => e.CodCuestasociado)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_CUESTASOCIADO");
            entity.Property(e => e.CodExplicacion)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_EXPLICACION");
            entity.Property(e => e.DesRespuesta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_RESPUESTA");
            entity.Property(e => e.IndFinal)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_FINAL");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");
            entity.Property(e => e.NumPregasociada)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("NUM_PREGASOCIADA");
            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");

            entity.HasOne(d => d.CodExplicacionNavigation).WithMany(p => p.AcpRespuesta)
                .HasForeignKey(d => d.CodExplicacion)
                .HasConstraintName("FK_ACRESP_ACEXPL");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcpRespuesta)
                .HasForeignKey(d => d.TipIncidencia)
                .HasConstraintName("FK_ACRESP_ACTINC");

            entity.HasOne(d => d.AcpPreguntum).WithMany(p => p.AcpRespuestumAcpPregunta)
                .HasForeignKey(d => new { d.CodCuestasociado, d.NumPregasociada })
                .HasConstraintName("FK_ACRESP_ACPREG2");

            entity.HasOne(d => d.AcpPreguntumNavigation).WithMany(p => p.AcpRespuestumAcpPreguntumNavigations)
                .HasForeignKey(d => new { d.CodCuestionario, d.NumPregunta })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRESP_ACPREG1");
        });

        modelBuilder.Entity<AcpSector>(entity =>
        {
            entity.HasKey(e => e.CodSector)
                .HasName("PK__ACP_SECT__5E3060ACFA4728FA")
                .IsClustered(false);

            entity.ToTable("ACP_SECTOR");

            entity.Property(e => e.CodSector)
                .ValueGeneratedNever()
                .HasColumnName("COD_SECTOR");
            entity.Property(e => e.CodOficina)
                .HasMaxLength(50)
                .HasColumnName("COD_OFICINA");
            entity.Property(e => e.DesSector)
                .HasMaxLength(60)
                .HasColumnName("DES_SECTOR");
            entity.Property(e => e.IndCanal).HasColumnName("IND_CANAL");
            entity.Property(e => e.NomResponsable)
                .HasMaxLength(60)
                .HasColumnName("NOM_RESPONSABLE");
        });

        modelBuilder.Entity<AcpTema>(entity =>
        {
            entity.HasKey(e => e.CodTema)
                .HasName("PK__ACP_TEMA__3D0AB255C3C49B59")
                .IsClustered(false);

            entity.ToTable("ACP_TEMA");

            entity.Property(e => e.CodTema)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_TEMA");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.DesTema)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DES_TEMA");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcpTemas)
                .HasForeignKey(d => d.CodSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTEMA_ACSECT");
        });

        modelBuilder.Entity<AcpTipoatencion>(entity =>
        {
            entity.HasKey(e => e.CodAtencion)
                .HasName("PK__ACP_TIPO__E27E57A566B34258")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOATENCION");

            entity.Property(e => e.CodAtencion)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("COD_ATENCION");
            entity.Property(e => e.DesAtencion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DES_ATENCION");
        });

        modelBuilder.Entity<AcpTipodocumento>(entity =>
        {
            entity.HasKey(e => e.TipDocumento)
                .HasName("PK__ACP_TIPO__11A47ECBC2368AD9")
                .IsClustered(false);

            entity.ToTable("ACP_TIPODOCUMENTO");

            entity.Property(e => e.TipDocumento)
                .ValueGeneratedNever()
                .HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.CodProcsac)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("COD_PROCSAC");
            entity.Property(e => e.DesDocumento)
                .HasMaxLength(50)
                .HasColumnName("DES_DOCUMENTO");

            entity.HasOne(d => d.CodProcsacNavigation).WithMany(p => p.AcpTipodocumentos)
                .HasForeignKey(d => d.CodProcsac)
                .HasConstraintName("FK_ACTIPD_ACPROC");
        });

        modelBuilder.Entity<AcpTipoincalarma>(entity =>
        {
            entity.HasKey(e => e.TipIncidencia)
                .HasName("PK__ACP_TIPO__00E28780D430BB94")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOINCALARMA");

            entity.Property(e => e.TipIncidencia)
                .ValueGeneratedNever()
                .HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.DesMensaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_MENSAJE");
            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.NumDias)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_DIAS");
            entity.Property(e => e.NumMaxaltinc)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_MAXALTINC");

            entity.HasOne(d => d.NomUsuaroraNavigation).WithMany(p => p.AcpTipoincalarmas)
                .HasForeignKey(d => d.NomUsuarora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIAL_ACUSSA");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithOne(p => p.AcpTipoincalarma)
                .HasForeignKey<AcpTipoincalarma>(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIAL_ACTINC");
        });

        modelBuilder.Entity<AcpTipoinccampo>(entity =>
        {
            entity.HasKey(e => new { e.TipIncidencia, e.CodCampo, e.IndTipo })
                .HasName("PK__ACP_TIPO__C613B278D50ECB5A")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOINCCAMPO");

            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.CodCampo).HasColumnName("COD_CAMPO");
            entity.Property(e => e.IndTipo)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_TIPO");
            entity.Property(e => e.NumOrden)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodCampoNavigation).WithMany(p => p.AcpTipoinccampos)
                .HasForeignKey(d => d.CodCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTICM_ACCMPO");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcpTipoinccampos)
                .HasForeignKey(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTICM_ACTINC");
        });

        modelBuilder.Entity<AcpTipoinccargo>(entity =>
        {
            entity.HasKey(e => new { e.TipIncidencia, e.CodCalclien })
                .HasName("PK__ACP_TIPO__FC5AA1CD40014196")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOINCCARGO");

            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.CodCalclien)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("COD_CALCLIEN");
            entity.Property(e => e.CodConcepto)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_CONCEPTO");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("COD_MONEDA");
            entity.Property(e => e.CodProducto)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("COD_PRODUCTO");
            entity.Property(e => e.ImpCargo)
                .HasColumnType("numeric(12, 4)")
                .HasColumnName("IMP_CARGO");
            entity.Property(e => e.NumDias)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_DIAS");
            entity.Property(e => e.NumMaxaltinc)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_MAXALTINC");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcpTipoinccargos)
                .HasForeignKey(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTICR_ACTINC");
        });

        modelBuilder.Entity<AcpTipoincidencium>(entity =>
        {
            entity.HasKey(e => e.TipIncidencia)
                .HasName("PK__ACP_TIPO__00E28780AD6105BE")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOINCIDENCIA");

            entity.Property(e => e.TipIncidencia)
                .ValueGeneratedNever()
                .HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.CodCausalSspd)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("COD_CAUSAL_SSPD");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.CodTema)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_TEMA");
            entity.Property(e => e.DesIncidencia)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DES_INCIDENCIA");
            entity.Property(e => e.HorAlarma)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("HOR_ALARMA");
            entity.Property(e => e.HorSolucion)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("HOR_SOLUCION");
            entity.Property(e => e.IndComunica).HasColumnName("IND_COMUNICA");
            entity.Property(e => e.IndDesviorapido).HasColumnName("IND_DESVIORAPIDO");
            entity.Property(e => e.IndSuspendible).HasColumnName("IND_SUSPENDIBLE");
            entity.Property(e => e.IndTipincid).HasColumnName("IND_TIPINCID");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcpTipoincidencia)
                .HasForeignKey(d => d.CodSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTINC_ACSECT");

            entity.HasOne(d => d.CodTemaNavigation).WithMany(p => p.AcpTipoincidencia)
                .HasForeignKey(d => d.CodTema)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTINC_ACTEMA");
        });

        modelBuilder.Entity<AcpTipoincmodenvio>(entity =>
        {
            entity.HasKey(e => new { e.TipDocumento, e.TipIncidencia, e.IndTipo })
                .HasName("PK__ACP_TIPO__3B7BA404DC4F7327")
                .IsClustered(false);

            entity.ToTable("ACP_TIPOINCMODENVIO");

            entity.Property(e => e.TipDocumento).HasColumnName("TIP_DOCUMENTO");
            entity.Property(e => e.TipIncidencia).HasColumnName("TIP_INCIDENCIA");
            entity.Property(e => e.IndTipo).HasColumnName("IND_TIPO");
            entity.Property(e => e.CodModoenvio).HasColumnName("COD_MODOENVIO");

            entity.HasOne(d => d.CodModoenvioNavigation).WithMany(p => p.AcpTipoincmodenvios)
                .HasForeignKey(d => d.CodModoenvio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIME_ACMOEN");

            entity.HasOne(d => d.TipDocumentoNavigation).WithMany(p => p.AcpTipoincmodenvios)
                .HasForeignKey(d => d.TipDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIME_ACTIPD");

            entity.HasOne(d => d.TipIncidenciaNavigation).WithMany(p => p.AcpTipoincmodenvios)
                .HasForeignKey(d => d.TipIncidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACTIME_ACTINC");
        });

        modelBuilder.Entity<AcpUsusac>(entity =>
        {
            entity.HasKey(e => e.NomUsuarora)
                .HasName("PK__ACP_USUS__B27883609D817975")
                .IsClustered(false);

            entity.ToTable("ACP_USUSAC");

            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.CodCampania).HasColumnName("COD_CAMPANIA");
            entity.Property(e => e.CodCentroAc)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("COD_CENTRO_AC");
            entity.Property(e => e.CodSector).HasColumnName("COD_SECTOR");
            entity.Property(e => e.IndConectado)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_CONECTADO");
            entity.Property(e => e.IndEnaumail)
                .HasDefaultValue(0m, "DF__ACP_USUSA__IND_E__662B2B3B")
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("IND_ENAUMAIL");
            entity.Property(e => e.NomUsuaradmin)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARADMIN");

            entity.HasOne(d => d.CodCampaniaNavigation).WithMany(p => p.AcpUsusacs)
                .HasForeignKey(d => d.CodCampania)
                .HasConstraintName("FK_ACUSSA_ACCAMP");

            entity.HasOne(d => d.CodSectorNavigation).WithMany(p => p.AcpUsusacs)
                .HasForeignKey(d => d.CodSector)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACUSSA_ACSECT");
        });

        modelBuilder.Entity<AcrPerfil>(entity =>
        {
            entity.HasKey(e => e.CodPerfil)
                .HasName("PK__ACR_PERF__EA0A92FA53AF1B15")
                .IsClustered(false);

            entity.ToTable("ACR_PERFIL");

            entity.Property(e => e.CodPerfil)
                .ValueGeneratedNever()
                .HasComment("Identificador del perfil")
                .HasColumnName("COD_PERFIL");
            entity.Property(e => e.DesPerfil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Descripción del perfil")
                .HasColumnName("DES_PERFIL");
            entity.Property(e => e.IndFijo)
                .HasComment("Indicador de Fijo")
                .HasDefaultValue(true, "DF__ACR_PERFI__IND_F__14270015")
                .HasColumnName("IND_FIJO");
            entity.Property(e => e.TipPerfil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TIP_PERFIL");

            entity.HasMany(d => d.CodCampania).WithMany(p => p.CodPerfils)
                .UsingEntity<Dictionary<string, object>>(
                    "AcrRestracampanium",
                    r => r.HasOne<AcpCampanium>().WithMany()
                        .HasForeignKey("CodCampania")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ACRACA_ACCAMP"),
                    l => l.HasOne<AcrPerfil>().WithMany()
                        .HasForeignKey("CodPerfil")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ACRACA_ACPERF"),
                    j =>
                    {
                        j.HasKey("CodPerfil", "CodCampania")
                            .HasName("PK__ACR_REST__E5665DEE490EECE7")
                            .IsClustered(false);
                        j.ToTable("ACR_RESTRACAMPANIA");
                        j.IndexerProperty<int>("CodPerfil").HasColumnName("COD_PERFIL");
                        j.IndexerProperty<short>("CodCampania").HasColumnName("COD_CAMPANIA");
                    });

            entity.HasMany(d => d.TipIncidencia).WithMany(p => p.CodPerfils)
                .UsingEntity<Dictionary<string, object>>(
                    "AcrRestratipincid",
                    r => r.HasOne<AcpTipoincidencium>().WithMany()
                        .HasForeignKey("TipIncidencia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ACRATI_ACTINC"),
                    l => l.HasOne<AcrPerfil>().WithMany()
                        .HasForeignKey("CodPerfil")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ACRATI_ACPERF"),
                    j =>
                    {
                        j.HasKey("CodPerfil", "TipIncidencia")
                            .HasName("PK__ACR_REST__EA04BA826D7123CB")
                            .IsClustered(false);
                        j.ToTable("ACR_RESTRATIPINCID");
                        j.IndexerProperty<int>("CodPerfil").HasColumnName("COD_PERFIL");
                        j.IndexerProperty<int>("TipIncidencia").HasColumnName("TIP_INCIDENCIA");
                    });
        });

        modelBuilder.Entity<AcrPerfilususac>(entity =>
        {
            entity.HasKey(e => e.NomUsuarora)
                .HasName("PK__ACR_PERF__B2788360AD4B8B70")
                .IsClustered(false);

            entity.ToTable("ACR_PERFILUSUSAC");

            entity.Property(e => e.NomUsuarora)
                .HasMaxLength(50)
                .HasColumnName("NOM_USUARORA");
            entity.Property(e => e.CodPerfilcamp).HasColumnName("COD_PERFILCAMP");
            entity.Property(e => e.CodPerfiltinc).HasColumnName("COD_PERFILTINC");

            entity.HasOne(d => d.CodPerfilcampNavigation).WithMany(p => p.AcrPerfilususacCodPerfilcampNavigations)
                .HasForeignKey(d => d.CodPerfilcamp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPEUS_ACPERF1");

            entity.HasOne(d => d.CodPerfiltincNavigation).WithMany(p => p.AcrPerfilususacCodPerfiltincNavigations)
                .HasForeignKey(d => d.CodPerfiltinc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPEUS_ACPERF3");

            entity.HasOne(d => d.NomUsuaroraNavigation).WithOne(p => p.AcrPerfilususac)
                .HasForeignKey<AcrPerfilususac>(d => d.NomUsuarora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACPEUS_ACUSSA");
        });

        modelBuilder.Entity<AcrRestradocumento>(entity =>
        {
            entity.HasKey(e => new { e.CodPerfil, e.CodDocmaestro })
                .HasName("PK__ACR_REST__F9B640BFC637CE4C")
                .IsClustered(false);

            entity.ToTable("ACR_RESTRADOCUMENTO");

            entity.Property(e => e.CodPerfil).HasColumnName("COD_PERFIL");
            entity.Property(e => e.CodDocmaestro)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DOCMAESTRO");

            entity.HasOne(d => d.CodPerfilNavigation).WithMany(p => p.AcrRestradocumentos)
                .HasForeignKey(d => d.CodPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACRADO_ACPERF");
        });

        modelBuilder.Entity<BdpDataset>(entity =>
        {
            entity.HasKey(e => e.IdDataset);

            entity.ToTable("BDP_DATASET");

            entity.Property(e => e.IdDataset)
                .ValueGeneratedNever()
                .HasColumnName("ID_DATASET");
            entity.Property(e => e.DesDataset)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DES_DATASET");
            entity.Property(e => e.NomDataset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_DATASET");
        });

        modelBuilder.Entity<BdpTable>(entity =>
        {
            entity.HasKey(e => e.IdTable);

            entity.ToTable("BDP_TABLE");

            entity.Property(e => e.IdTable)
                .ValueGeneratedNever()
                .HasColumnName("ID_TABLE");
            entity.Property(e => e.DesTable)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DES_TABLE");
            entity.Property(e => e.IdDataset).HasColumnName("ID_DATASET");
            entity.Property(e => e.NomTable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_TABLE");

            entity.HasOne(d => d.IdDatasetNavigation).WithMany(p => p.BdpTables)
                .HasForeignKey(d => d.IdDataset)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BDP_TABLE_BDP_DATASET");
        });

        modelBuilder.Entity<ColAcudiente>(entity =>
        {
            entity.HasKey(e => e.IdAcudiente).HasName("PK__Col_Acud__7A8976E7AD62B2E6");

            entity.ToTable("Col_Acudiente");

            entity.HasIndex(e => e.NumeroDocumento, "UQ__Col_Acud__A4202588CD54094D").IsUnique();

            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parentesco)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColAgendum>(entity =>
        {
            entity.HasKey(e => e.IdAgenda).HasName("PK__Col_Agen__FACC499E230B7FF6");

            entity.ToTable("Col_Agenda");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.TipoActividad)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.ColAgenda)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Agend__IdPro__5E3FF0B0");
        });

        modelBuilder.Entity<ColAsistencium>(entity =>
        {
            entity.HasKey(e => e.IdAsistencia).HasName("PK__Col_Asis__3956DEE6257741A5");

            entity.ToTable("Col_Asistencia");

            entity.Property(e => e.EstadoAsistencia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.ColAsistencia)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Asist__IdEst__457442E6");

            entity.HasOne(d => d.IdProfesorMateriaNavigation).WithMany(p => p.ColAsistencia)
                .HasForeignKey(d => d.IdProfesorMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Asist__IdPro__4668671F");
        });

        modelBuilder.Entity<ColAviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso).HasName("PK__Col_Avis__5CBDD9A7500C45B5");

            entity.ToTable("Col_Aviso");

            entity.Property(e => e.Destinatario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Todos");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Prioridad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Normal");
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColComunicado>(entity =>
        {
            entity.HasKey(e => e.IdComunicado).HasName("PK__Col_Comu__5403C65790F17303");

            entity.ToTable("Col_Comunicado");

            entity.Property(e => e.Contenido)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Activo");
            entity.Property(e => e.FechaPublicacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TipoComunicado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.ColComunicados)
                .HasForeignKey(d => d.IdEstudiante)
                .HasConstraintName("FK__Col_Comun__IdEst__54B68676");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.ColComunicados)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK__Col_Comun__IdGru__53C2623D");
        });

        modelBuilder.Entity<ColEstudiante>(entity =>
        {
            entity.HasKey(e => e.IdEstudiante).HasName("PK__Col_Estu__B5007C2485B201AB");

            entity.ToTable("Col_Estudiante");

            entity.HasIndex(e => e.NumeroDocumento, "UQ__Col_Estu__A42025888943F8CF").IsUnique();

            entity.HasIndex(e => e.CodigoEstudiante, "UQ__Col_Estu__C0968301CC1F3804").IsUnique();

            entity.Property(e => e.CodigoEstudiante)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true, "DF__Col_Estud__Estad__2AC04CAA");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.ColEstudiantes)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Col_Estudiante_Col_Genero");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.ColEstudiantes)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK__Col_Estud__IdGru__2BB470E3");

            entity.HasOne(d => d.IdSedeNavigation).WithMany(p => p.ColEstudiantes)
                .HasForeignKey(d => d.IdSede)
                .HasConstraintName("FK_Col_Estudiante_Col_Sede");
        });

        modelBuilder.Entity<ColEstudianteAcudiente>(entity =>
        {
            entity.HasKey(e => e.IdEstudianteAcudiente).HasName("PK__Col_Estu__524ACDEF23A2CE12");

            entity.ToTable("Col_EstudianteAcudiente");

            entity.Property(e => e.EsPrincipal).HasDefaultValue(true);

            entity.HasOne(d => d.IdAcudienteNavigation).WithMany(p => p.ColEstudianteAcudientes)
                .HasForeignKey(d => d.IdAcudiente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Estud__IdAcu__3449B6E4");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.ColEstudianteAcudientes)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Estud__IdEst__335592AB");
        });

        modelBuilder.Entity<ColEvento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Col_Even__034EFC04A3B280DF");

            entity.ToTable("Col_Evento");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Activo");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Titulo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.ColEventos)
                .HasForeignKey(d => d.IdGrupo)
                .HasConstraintName("FK__Col_Event__IdGru__4EFDAD20");
        });

        modelBuilder.Entity<ColGenero>(entity =>
        {
            entity.HasKey(e => e.IdGenero);

            entity.ToTable("Col_Genero");

            entity.Property(e => e.IdGenero).ValueGeneratedNever();
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColGrado>(entity =>
        {
            entity.HasKey(e => e.IdGrado).HasName("PK__Col_Grad__393DFCB85C0D9D1D");

            entity.ToTable("Col_Grado");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nivel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColGrupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo).HasName("PK__Col_Grup__303F6FD9648AAA6E");

            entity.ToTable("Col_Grupo");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdGradoNavigation).WithMany(p => p.ColGrupos)
                .HasForeignKey(d => d.IdGrado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Grupo__IdGra__25FB978D");
        });

        modelBuilder.Entity<ColHorario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK__Col_Hora__1539229B505648C6");

            entity.ToTable("Col_Horario");

            entity.Property(e => e.Salon)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProfesorMateriaNavigation).WithMany(p => p.ColHorarios)
                .HasForeignKey(d => d.IdProfesorMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Horar__IdPro__4297D63B");
        });

        modelBuilder.Entity<ColMaterium>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__Col_Mate__EC174670721D76DA");

            entity.ToTable("Col_Materia");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColNotum>(entity =>
        {
            entity.HasKey(e => e.IdNota).HasName("PK__Col_Nota__4B2ACFF2FCB1A5E6");

            entity.ToTable("Col_Nota");

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ponderacion).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TipoEvaluacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.ColNota)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Nota__IdEstu__4A38F803");

            entity.HasOne(d => d.IdProfesorMateriaNavigation).WithMany(p => p.ColNota)
                .HasForeignKey(d => d.IdProfesorMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Nota__IdProf__4B2D1C3C");
        });

        modelBuilder.Entity<ColProfesor>(entity =>
        {
            entity.HasKey(e => e.IdProfesor).HasName("PK__Col_Prof__C377C3A10183928E");

            entity.ToTable("Col_Profesor");

            entity.HasIndex(e => e.NumeroDocumento, "UQ__Col_Prof__A4202588E15C49D1").IsUnique();

            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColProfesorMaterium>(entity =>
        {
            entity.HasKey(e => e.IdProfesorMateria).HasName("PK__Col_Prof__D3C3A296A958859C");

            entity.ToTable("Col_ProfesorMateria");

            entity.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.ColProfesorMateria)
                .HasForeignKey(d => d.IdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Profe__IdGru__3FBB6990");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.ColProfesorMateria)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Profe__IdMat__3EC74557");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.ColProfesorMateria)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Col_Profe__IdPro__3DD3211E");
        });

        modelBuilder.Entity<ColSede>(entity =>
        {
            entity.HasKey(e => e.IdSede).HasName("PK__Col_Sede__A7780DFFC6F4C93F");

            entity.ToTable("Col_Sede");

            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ColUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Col_Usua__5B65BF97A12A1231");

            entity.ToTable("Col_Usuario");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Col_Usua__6B0F5AE06A795345").IsUnique();

            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true, "DF__Col_Usuar__Estad__62108194");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())", "DF__Col_Usuar__Fecha__6304A5CD")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAcudienteNavigation).WithMany(p => p.ColUsuarios)
                .HasForeignKey(d => d.IdAcudiente)
                .HasConstraintName("FK__Col_Usuar__IdAcu__64ECEE3F");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.ColUsuarios)
                .HasForeignKey(d => d.IdEstudiante)
                .HasConstraintName("FK_Col_Usuario_Col_Estudiante");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.ColUsuarios)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__Col_Usuar__IdPro__63F8CA06");
        });

        modelBuilder.Entity<DbpColumn>(entity =>
        {
            entity.HasKey(e => e.IdColumn);

            entity.ToTable("DBP_COLUMN");

            entity.Property(e => e.IdColumn)
                .ValueGeneratedNever()
                .HasColumnName("ID_COLUMN");
            entity.Property(e => e.DesColumn)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DES_COLUMN");
            entity.Property(e => e.IdSimularTabla)
                .HasComment("Origen donde buscara los datos de la lista")
                .HasColumnName("ID_SIMULAR_TABLA");
            entity.Property(e => e.IdTable).HasColumnName("ID_TABLE");
            entity.Property(e => e.JsnConfig)
                .HasMaxLength(4000)
                .HasComment("Objeto que representa el PropertyAttribute")
                .HasColumnName("JSN_CONFIG");
            entity.Property(e => e.NomColumn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_COLUMN");
            entity.Property(e => e.TipColumn)
                .HasComment("Tipo de campo ")
                .HasColumnName("TIP_COLUMN");

            entity.HasOne(d => d.IdSimularTablaNavigation).WithMany(p => p.DbpColumns)
                .HasForeignKey(d => d.IdSimularTabla)
                .HasConstraintName("FK_DBP_COLUMN_FXP_SIMULAR_TABLA");

            entity.HasOne(d => d.IdTableNavigation).WithMany(p => p.DbpColumns)
                .HasForeignKey(d => d.IdTable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBP_COLUMN_BDP_TABLE");

            entity.HasOne(d => d.TipColumnNavigation).WithMany(p => p.DbpColumns)
                .HasForeignKey(d => d.TipColumn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBP_COLUMN_FXP_TIPO_CAMPOS");
        });

        modelBuilder.Entity<DbpMasterdetail>(entity =>
        {
            entity.HasKey(e => new { e.IdTablemaster, e.IdTabledetail });

            entity.ToTable("DBP_MASTERDETAIL");

            entity.Property(e => e.IdTablemaster).HasColumnName("ID_TABLEMASTER");
            entity.Property(e => e.IdTabledetail).HasColumnName("ID_TABLEDETAIL");
            entity.Property(e => e.NomMasterdetail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_MASTERDETAIL");

            entity.HasOne(d => d.IdTabledetailNavigation).WithMany(p => p.DbpMasterdetailIdTabledetailNavigations)
                .HasForeignKey(d => d.IdTabledetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBP_MASTERDETAIL_BDP_TABLE1");

            entity.HasOne(d => d.IdTablemasterNavigation).WithMany(p => p.DbpMasterdetailIdTablemasterNavigations)
                .HasForeignKey(d => d.IdTablemaster)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DBP_MASTERDETAIL_BDP_TABLE");
        });

        modelBuilder.Entity<FluxOldVsNew>(entity =>
        {
            entity.ToTable("FLUX_OLD_VS_NEW");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FluxNew)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLUX_NEW");
            entity.Property(e => e.FluxOld)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FLUX_OLD");
        });

        modelBuilder.Entity<FluxpObjectType>(entity =>
        {
            entity.HasKey(e => e.IdObjectType);

            entity.ToTable("FLUXP_OBJECT_TYPE", tb => tb.HasComment("Tipo de objeto del flujo"));

            entity.Property(e => e.IdObjectType)
                .ValueGeneratedNever()
                .HasComment("identificador único del tipo de objeto del flujo")
                .HasColumnName("ID_OBJECT_TYPE");
            entity.Property(e => e.DesObjectType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripción del tipo de objeto del flujo")
                .HasColumnName("DES_OBJECT_TYPE");
            entity.Property(e => e.Help)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("Ayuda para el tipo de objeto")
                .HasColumnName("HELP");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Icono a presentar para el tipo de objeto")
                .HasColumnName("ICON");
            entity.Property(e => e.NomObjectType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del tipo de objeto del flujo")
                .HasColumnName("NOM_OBJECT_TYPE");
        });

        modelBuilder.Entity<FluxpObjectTypeChidren>(entity =>
        {
            entity.HasKey(e => e.IdObjectTypeChildren);

            entity.ToTable("FLUXP_OBJECT_TYPE_CHIDREN");

            entity.Property(e => e.IdObjectTypeChildren)
                .ValueGeneratedNever()
                .HasComment("Indicador del sub-tipo de objeto del flujo")
                .HasColumnName("ID_OBJECT_TYPE_CHILDREN");
            entity.Property(e => e.DesObjectTypeChildren)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripción del sub-tipo de objeto del flujo")
                .HasColumnName("DES_OBJECT_TYPE_CHILDREN");
            entity.Property(e => e.Help)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HELP");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Icono")
                .HasColumnName("ICON");
            entity.Property(e => e.IdObjectType)
                .HasComment("identificador del tipo de objeto del flujo")
                .HasColumnName("ID_OBJECT_TYPE");
            entity.Property(e => e.IndEnd)
                .HasComment("Indicador de si es final del flujo")
                .HasColumnName("IND_END");
            entity.Property(e => e.NomObjectTypeChildren)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del sub-tipo de objeto del flujo")
                .HasColumnName("NOM_OBJECT_TYPE_CHILDREN");

            entity.HasOne(d => d.IdObjectTypeNavigation).WithMany(p => p.FluxpObjectTypeChidrens)
                .HasForeignKey(d => d.IdObjectType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FLUXP_OBJECT_TYPE_CHIDREN_FLUXP_OBJECT_TYPE");
        });

        modelBuilder.Entity<FluxpProcess>(entity =>
        {
            entity.HasKey(e => e.IdProcess);

            entity.ToTable("FLUXP_PROCESS");

            entity.Property(e => e.IdProcess)
                .ValueGeneratedNever()
                .HasComment("Identificador del proceso")
                .HasColumnName("ID_PROCESS");
            entity.Property(e => e.DesProcess)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripción del proceso")
                .HasColumnName("DES_PROCESS");
            entity.Property(e => e.NomProcess)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del proceso")
                .HasColumnName("NOM_PROCESS");
        });

        modelBuilder.Entity<FluxpProcessFlow>(entity =>
        {
            entity.HasKey(e => new { e.IdProcess, e.IdProcessItem, e.IdProcessItemNext });

            entity.ToTable("FLUXP_PROCESS_FLOW");

            entity.Property(e => e.IdProcess)
                .HasComment("Identificador del proceso")
                .HasDefaultValue(1, "DF_FLUXP_FLOW_IDProceso")
                .HasColumnName("ID_PROCESS");
            entity.Property(e => e.IdProcessItem)
                .HasComment("Identificador del item del proceso")
                .HasColumnName("ID_PROCESS_ITEM");
            entity.Property(e => e.IdProcessItemNext)
                .HasComment("Identificador del item del proceso siguiente")
                .HasColumnName("ID_PROCESS_ITEM_NEXT");
            entity.Property(e => e.IndActivated)
                .HasComment("Indicador de activado")
                .HasDefaultValue(true, "DF_FLUXP_FLOW_PROCESS_SWActivo")
                .HasColumnName("IND_ACTIVATED");

            entity.HasOne(d => d.IdProcessNavigation).WithMany(p => p.FluxpProcessFlows)
                .HasForeignKey(d => d.IdProcess)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FLUXP_PROCESS_FLOW_FLUXP_PROCESS");

            entity.HasOne(d => d.IdProcessItemNavigation).WithMany(p => p.FluxpProcessFlowIdProcessItemNavigations)
                .HasForeignKey(d => d.IdProcessItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FLUXP_PROCESS_FLOW_FLUXP_PROCESS_ITEM");

            entity.HasOne(d => d.IdProcessItemNextNavigation).WithMany(p => p.FluxpProcessFlowIdProcessItemNextNavigations)
                .HasForeignKey(d => d.IdProcessItemNext)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FLUXP_PROCESS_FLOW_FLUXP_PROCESS_ITEM1");
        });

        modelBuilder.Entity<FluxpProcessItem>(entity =>
        {
            entity.HasKey(e => e.IdProcessItem);

            entity.ToTable("FLUXP_PROCESS_ITEM");

            entity.Property(e => e.IdProcessItem)
                .ValueGeneratedNever()
                .HasComment("Identificador del item del proceso")
                .HasColumnName("ID_PROCESS_ITEM");
            entity.Property(e => e.DesProcessItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Descripción del item del proceso")
                .HasColumnName("DES_PROCESS_ITEM");
            entity.Property(e => e.IdObjectTypeChildren)
                .HasComment("Indicador del sub-tipo de objeto del flujo")
                .HasColumnName("ID_OBJECT_TYPE_CHILDREN");
            entity.Property(e => e.IndOptionalExit)
                .HasComment("Indicador de si sus salidas son opcionales")
                .HasDefaultValue(true, "DF_FLUXP_FLOW_PROCESS_ITEM_SalidaOpcional")
                .HasColumnName("IND_OPTIONAL_EXIT");
            entity.Property(e => e.NomProcessItem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del item del proceso")
                .HasColumnName("NOM_PROCESS_ITEM");

            entity.HasOne(d => d.IdObjectTypeChildrenNavigation).WithMany(p => p.FluxpProcessItems)
                .HasForeignKey(d => d.IdObjectTypeChildren)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FLUXP_PROCESS_ITEM_FLUXP_OBJECT_TYPE_CHIDREN");
        });

        modelBuilder.Entity<FxpCampoConf>(entity =>
        {
            entity.HasKey(e => e.IdCampoConf);

            entity.ToTable("FXP_CAMPO_CONF");

            entity.Property(e => e.IdCampoConf)
                .ValueGeneratedNever()
                .HasComment("Identificador del campo de configuración")
                .HasColumnName("ID_CAMPO_CONF");
            entity.Property(e => e.DesProperty)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripcion de para que sirve la propiedad")
                .HasColumnName("DES_PROPERTY");
            entity.Property(e => e.IdCampoConfGrupo).HasColumnName("ID_CAMPO_CONF_GRUPO");
            entity.Property(e => e.IdCampoConfPadre)
                .HasComment("Identificador del campo de configuración")
                .HasColumnName("ID_CAMPO_CONF_PADRE");
            entity.Property(e => e.IdObject).HasColumnName("ID_OBJECT");
            entity.Property(e => e.NomProperty)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la propiedad interno")
                .HasColumnName("NOM_PROPERTY");
            entity.Property(e => e.NomPropertyDisplay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la propiedad para mostrar al usuario")
                .HasColumnName("NOM_PROPERTY_DISPLAY");
            entity.Property(e => e.TipCampo)
                .HasComment("Identificador del tipo de campo para el configurar")
                .HasColumnName("TIP_CAMPO");

            entity.HasOne(d => d.IdCampoConfPadreNavigation).WithMany(p => p.InverseIdCampoConfPadreNavigation)
                .HasForeignKey(d => d.IdCampoConfPadre)
                .HasConstraintName("FK_FXP_CAMPO_CONF_FXP_CAMPO_CONF");

            entity.HasOne(d => d.TipCampoNavigation).WithMany(p => p.FxpCampoConfs)
                .HasForeignKey(d => d.TipCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_CAMPO_CONF_FXP_TIPO_CAMPOS");
        });

        modelBuilder.Entity<FxpGroupingAttr>(entity =>
        {
            entity.HasKey(e => e.IdGrouping);

            entity.ToTable("FXP_GROUPING_ATTR");

            entity.Property(e => e.IdGrouping)
                .ValueGeneratedNever()
                .HasComment("Identificador del grupo")
                .HasColumnName("ID_GROUPING");
            entity.Property(e => e.JsnConfig)
                .HasMaxLength(4000)
                .HasComment("Objeto que representa el GropingAttribute")
                .HasColumnName("JSN_CONFIG");
            entity.Property(e => e.NomGrouping)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del grupo")
                .HasColumnName("NOM_GROUPING");
        });

        modelBuilder.Entity<FxpObject>(entity =>
        {
            entity.HasKey(e => e.IdObject);

            entity.ToTable("FXP_OBJECTS");

            entity.Property(e => e.IdObject).HasColumnName("ID_OBJECT");
            entity.Property(e => e.DescObject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESC_OBJECT");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ICON");
            entity.Property(e => e.NomObject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_OBJECT");
        });

        modelBuilder.Entity<FxpObjectGroup>(entity =>
        {
            entity.HasKey(e => e.IdGroup);

            entity.ToTable("FXP_OBJECT_GROUP");

            entity.Property(e => e.IdGroup)
                .ValueGeneratedNever()
                .HasColumnName("ID_GROUP");
            entity.Property(e => e.DesGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_GROUP");
            entity.Property(e => e.Display)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISPLAY");
            entity.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ICON");
            entity.Property(e => e.IdGroupParent).HasColumnName("ID_GROUP_PARENT");
            entity.Property(e => e.NomGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_GROUP");
        });

        modelBuilder.Entity<FxpObjectProp>(entity =>
        {
            entity.HasKey(e => e.IdProperty);

            entity.ToTable("FXP_OBJECT_PROPS");

            entity.Property(e => e.IdProperty).HasColumnName("ID_PROPERTY");
            entity.Property(e => e.DesProperty)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DES_PROPERTY");
            entity.Property(e => e.IdGroup).HasColumnName("ID_GROUP");
            entity.Property(e => e.IdObject).HasColumnName("ID_OBJECT");
            entity.Property(e => e.IdPropertyParent)
                .HasComment("Identificador del campo de configuración")
                .HasColumnName("ID_PROPERTY_PARENT");
            entity.Property(e => e.NomProperty)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOM_PROPERTY");
            entity.Property(e => e.NomPropertyDisplay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOM_PROPERTY_DISPLAY");
            entity.Property(e => e.TipCampo)
                .HasComment("Identificador del tipo de campo para el configurar")
                .HasColumnName("TIP_CAMPO");

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.FxpObjectProps)
                .HasForeignKey(d => d.IdGroup)
                .HasConstraintName("FK_FXP_OBJECT_PROPS_FXP_OBJECT_GROUP");

            entity.HasOne(d => d.IdObjectNavigation).WithMany(p => p.FxpObjectProps)
                .HasForeignKey(d => d.IdObject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_OBJECT_PROPS_FXP_OBJECTS");

            entity.HasOne(d => d.IdPropertyParentNavigation).WithMany(p => p.InverseIdPropertyParentNavigation)
                .HasForeignKey(d => d.IdPropertyParent)
                .HasConstraintName("FK_FXP_OBJECT_PROPS_FXP_OBJECT_PROPS");

            entity.HasOne(d => d.TipCampoNavigation).WithMany(p => p.FxpObjectProps)
                .HasForeignKey(d => d.TipCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_OBJECT_PROPS_FXP_TIPO_CAMPOS");
        });

        modelBuilder.Entity<FxpProceso>(entity =>
        {
            entity.HasKey(e => e.IdProceso);

            entity.ToTable("FXP_PROCESO");

            entity.Property(e => e.IdProceso)
                .ValueGeneratedNever()
                .HasComment("Indicador unico del proceso")
                .HasColumnName("ID_PROCESO");
            entity.Property(e => e.DesProceso)
                .HasMaxLength(200)
                .HasComment("Descripción del proceso")
                .HasColumnName("DES_PROCESO");
            entity.Property(e => e.IdProcesoTipo)
                .HasComment("Indicador unico del tipo de proceso")
                .HasColumnName("ID_PROCESO_TIPO");
            entity.Property(e => e.NomProceso)
                .HasMaxLength(50)
                .HasComment("Nombre del proceso")
                .HasColumnName("NOM_PROCESO");

            entity.HasOne(d => d.IdProcesoTipoNavigation).WithMany(p => p.FxpProcesos)
                .HasForeignKey(d => d.IdProcesoTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_PROCESO_FXP_PROCESO_TIPO");
        });

        modelBuilder.Entity<FxpProcesoTipo>(entity =>
        {
            entity.HasKey(e => e.IdProcesoTipo);

            entity.ToTable("FXP_PROCESO_TIPO", tb => tb.HasComment("Tipo de Proceso Form, Services, ejecutable, Procedimientos almacenados, etc"));

            entity.Property(e => e.IdProcesoTipo)
                .HasComment("Indicador unico del tipo de proceso")
                .HasColumnName("ID_PROCESO_TIPO");
            entity.Property(e => e.DesProcesoTipo)
                .HasMaxLength(200)
                .HasComment("Descripción del tipo de proceso")
                .HasColumnName("DES_PROCESO_TIPO");
            entity.Property(e => e.NomProcesoTipo)
                .HasMaxLength(50)
                .HasComment("Nombre del tipo de proceso")
                .HasColumnName("NOM_PROCESO_TIPO");
        });

        modelBuilder.Entity<FxpProcesoVsParam>(entity =>
        {
            entity.HasKey(e => new { e.IdProceso, e.CodCampo });

            entity.ToTable("FXP_PROCESO_VS_PARAMS", tb => tb.HasComment("Parametros para un proceso (Proceso vs campos)"));

            entity.Property(e => e.IdProceso)
                .HasComment("Indicador unico del proceso")
                .HasColumnName("ID_PROCESO");
            entity.Property(e => e.CodCampo)
                .HasComment("Identificador del campo ")
                .HasColumnName("COD_CAMPO");
            entity.Property(e => e.IdGrouping)
                .HasComment("Identificador del grupo")
                .HasColumnName("ID_GROUPING");
            entity.Property(e => e.NumOrden)
                .HasComment("Numero de item en la secuencia para mostrar o procesar")
                .HasColumnName("NUM_ORDEN");

            entity.HasOne(d => d.CodCampoNavigation).WithMany(p => p.FxpProcesoVsParams)
                .HasForeignKey(d => d.CodCampo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_PROCESO_VS_PARAMS_ACP_CAMPO");

            entity.HasOne(d => d.IdGroupingNavigation).WithMany(p => p.FxpProcesoVsParams)
                .HasForeignKey(d => d.IdGrouping)
                .HasConstraintName("FK_FXP_PROCESO_VS_PARAMS_FXP_GROUPING_ATTR");

            entity.HasOne(d => d.IdProcesoNavigation).WithMany(p => p.FxpProcesoVsParams)
                .HasForeignKey(d => d.IdProceso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_PROCESO_VS_PARAMS_FXP_PROCESO");
        });

        modelBuilder.Entity<FxpSimularCampo>(entity =>
        {
            entity.HasKey(e => e.IdSimularCampo).HasName("PK_FXP_CAMPOS_SIMULADOS");

            entity.ToTable("FXP_SIMULAR_CAMPOS");

            entity.Property(e => e.IdSimularCampo)
                .HasComment("Id del campo")
                .HasColumnName("ID_SIMULAR_CAMPO");
            entity.Property(e => e.IdSimularTabla)
                .HasComment("Id de la tabla simulada")
                .HasColumnName("ID_SIMULAR_TABLA");
            entity.Property(e => e.ValDescampo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Valor que respresenta la descripción del campo")
                .HasColumnName("VAL_DESCAMPO");
            entity.Property(e => e.ValIdcampo)
                .HasComment("Valor que respresenta el id del campo")
                .HasColumnName("VAL_IDCAMPO");

            entity.HasOne(d => d.IdSimularTablaNavigation).WithMany(p => p.FxpSimularCampos)
                .HasForeignKey(d => d.IdSimularTabla)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FXP_SIMULAR_CAMPOS_FXP_SIMULAR_TABLA");
        });

        modelBuilder.Entity<FxpSimularTabla>(entity =>
        {
            entity.HasKey(e => e.IdSimularTabla).HasName("PK_FXP_TABLA_SIMULADA");

            entity.ToTable("FXP_SIMULAR_TABLA", tb => tb.HasComment("Tabla para simular tablas para las listas"));

            entity.Property(e => e.IdSimularTabla)
                .HasComment("Id de la tabla simulada")
                .HasColumnName("ID_SIMULAR_TABLA");
            entity.Property(e => e.DesSimularTabla)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripción de la tabla simulada")
                .HasColumnName("DES_SIMULAR_TABLA");
            entity.Property(e => e.IndTablaEsReal)
                .HasComment("Indicador de que la tabla es real en BD")
                .HasColumnName("IND_TABLA_ES_REAL");
            entity.Property(e => e.NomCampoDesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("Nombre del campo que representa la descripción")
                .HasColumnName("NOM_CAMPO_DESC");
            entity.Property(e => e.NomCampoId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Nombre del campo que representa el ID")
                .HasColumnName("NOM_CAMPO_ID");
            entity.Property(e => e.NomSimularTabla)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("Nombre para la tabla simulada")
                .HasColumnName("NOM_SIMULAR_TABLA");
        });

        modelBuilder.Entity<FxpTipoCampo>(entity =>
        {
            entity.HasKey(e => e.TipCampo);

            entity.ToTable("FXP_TIPO_CAMPOS");

            entity.Property(e => e.TipCampo)
                .ValueGeneratedNever()
                .HasComment("Tipo de campo")
                .HasColumnName("TIP_CAMPO");
            entity.Property(e => e.DesTipoCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("_")
                .HasColumnName("DES_TIPO_CAMPO");
            entity.Property(e => e.NomTipCampo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre que representa el tipo de campo")
                .HasColumnName("NOM_TIP_CAMPO");
            entity.Property(e => e.TipCampoCsharp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del asssembly del tipo de campo")
                .HasColumnName("TIP_CAMPO_CSHARP");
        });

        modelBuilder.Entity<HelperEstructura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HELPER_ESTRUCTURA");

            entity.ToTable("_HELPER_ESTRUCTURA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasComment("descripción de ayuda")
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.IndEliminar)
                .HasComment("inidicador de eliminar la tabla")
                .HasColumnName("IND_ELIMINAR");
            entity.Property(e => e.IndNuevo)
                .HasComment("Indicador que esta tabla es nueva")
                .HasColumnName("IND_NUEVO");
            entity.Property(e => e.NewTableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la tabla que la reemplazo")
                .HasColumnName("NEW_TABLE_NAME");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la tabla")
                .HasColumnName("TABLE_NAME");
        });

        modelBuilder.Entity<ProMunicipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio);

            entity.ToTable("Pro_Municipios");

            entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");
            entity.Property(e => e.Municipio).HasMaxLength(50);
        });

        modelBuilder.Entity<ProProveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor)
                .HasName("aaaaaTbl_Proveedores2_PK")
                .IsClustered(false);

            entity.ToTable("Pro_Proveedores");

            entity.Property(e => e.IdProveedor).HasColumnName("Id_Proveedor");
            entity.Property(e => e.Celular).HasMaxLength(12);
            entity.Property(e => e.DctoGeneral).HasColumnName("Dcto_General");
            entity.Property(e => e.DctoProntoPago).HasColumnName("Dcto_ProntoPago");
            entity.Property(e => e.DiasLimiteDeuda).HasColumnName("Dias_Limite_Deuda");
            entity.Property(e => e.DiasRespuesta).HasColumnName("Dias_Respuesta");
            entity.Property(e => e.DirNotificacion)
                .HasMaxLength(250)
                .HasColumnName("Dir_Notificacion");
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FecAlta)
                .HasColumnType("datetime")
                .HasColumnName("Fec_Alta");
            entity.Property(e => e.FecBloqueo)
                .HasColumnType("datetime")
                .HasColumnName("Fec_Bloqueo");
            entity.Property(e => e.FecVinculacion)
                .HasColumnType("datetime")
                .HasColumnName("Fec_Vinculacion");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(50)
                .HasColumnName("Forma_Pago");
            entity.Property(e => e.IdEstado).HasColumnName("Id_Estado");
            entity.Property(e => e.IdMunicipio).HasColumnName("Id_Municipio");
            entity.Property(e => e.IdTipoActividad).HasColumnName("Id_TipoActividad");
            entity.Property(e => e.IdUsrAlta).HasColumnName("Id_Usr_Alta");
            entity.Property(e => e.Logo).HasMaxLength(50);
            entity.Property(e => e.MontoLimiteDeuda).HasColumnName("Monto_Limite_Deuda");
            entity.Property(e => e.MotivoBloqueo)
                .HasMaxLength(30)
                .HasColumnName("Motivo_Bloqueo");
            entity.Property(e => e.Proveedor).HasMaxLength(50);
            entity.Property(e => e.RegimenIva)
                .HasMaxLength(2)
                .HasColumnName("Regimen_Iva");
            entity.Property(e => e.Representante).HasMaxLength(50);
            entity.Property(e => e.SwBloqueo).HasColumnName("Sw_Bloqueo");
            entity.Property(e => e.Telefono).HasMaxLength(12);
            entity.Property(e => e.TipoCompra).HasColumnName("Tipo_Compra");
            entity.Property(e => e.Www).HasMaxLength(100);

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.ProProveedores)
                .HasForeignKey(d => d.IdMunicipio)
                .HasConstraintName("FK_Pro_Proveedores_Pro_Municipios");

            entity.HasOne(d => d.TipoCompraNavigation).WithMany(p => p.ProProveedores)
                .HasForeignKey(d => d.TipoCompra)
                .HasConstraintName("FK_Pro_Proveedores_Pro_TipoCompra");
        });

        modelBuilder.Entity<ProTipoCompra>(entity =>
        {
            entity.HasKey(e => e.IdTipoCompra);

            entity.ToTable("Pro_TipoCompra");

            entity.Property(e => e.IdTipoCompra).HasColumnName("ID_TipoCompra");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegFieldPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_Fiel__3214EC071350B488");

            entity.ToTable("SEG_FieldPermissions");

            entity.HasIndex(e => new { e.RoleId, e.TableFieldId }, "UQ__SEG_Fiel__4377CC1C5FD7221B").IsUnique();

            entity.Property(e => e.Id).HasComment("Id permisos sobre el campo de la tabla");
            entity.Property(e => e.CanCreate).HasComment("Indicador de si puede Crear datos a la propiedad");
            entity.Property(e => e.CanEdit).HasComment("Indicador de si puede Editar la propiedad");
            entity.Property(e => e.CanView)
                .HasComment("Indicador de si puede Visualizar la propiedad")
                .HasDefaultValue(true, "DF__SEG_Field__CanVi__490FC9A0");
            entity.Property(e => e.CreatedAt)
                .HasComment("Fecha de creación")
                .HasDefaultValueSql("(getdate())", "DF__SEG_Field__Creat__4AF81212");
            entity.Property(e => e.RoleId).HasComment("Id único de la regla");
            entity.Property(e => e.TableFieldId).HasComment("Id de la tabla campo");

            entity.HasOne(d => d.Role).WithMany(p => p.SegFieldPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__SEG_Field__RoleI__4BEC364B");

            entity.HasOne(d => d.TableField).WithMany(p => p.SegFieldPermissions)
                .HasForeignKey(d => d.TableFieldId)
                .HasConstraintName("FK__SEG_Field__Table__4CE05A84");
        });

        modelBuilder.Entity<SegMenuModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_Menu__3214EC07CBBC052D");

            entity.ToTable("SEG_MenuModules");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Route).HasMaxLength(255);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__SEG_MenuM__Paren__25C68D63");
        });

        modelBuilder.Entity<SegMenuPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuPerm__3214EC073E95C7CD");

            entity.ToTable("SEG_MenuPermissions");

            entity.HasIndex(e => new { e.RoleId, e.MenuModuleId }, "UQ__MenuPerm__9959752090441797").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MenuModule).WithMany(p => p.SegMenuPermissions)
                .HasForeignKey(d => d.MenuModuleId)
                .HasConstraintName("FK__MenuPermi__MenuM__30441BD6");

            entity.HasOne(d => d.Role).WithMany(p => p.SegMenuPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__MenuPermi__RoleI__2F4FF79D");
        });

        modelBuilder.Entity<SegRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_Role__3214EC07651B3BE5");

            entity.ToTable("SEG_Roles");

            entity.HasIndex(e => e.Name, "UQ__SEG_Role__737584F69A238DB8").IsUnique();

            entity.Property(e => e.Id).HasComment("Id único de la regla");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("Descripción de para que es la regla");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Indicador de si esta activa");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("Nombre de la regla");
        });

        modelBuilder.Entity<SegRowsPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Seg_RowsPremissions");

            entity.ToTable("SEG_RowsPermissions");

            entity.Property(e => e.Id).HasComment("Id permisos sobre que filas mostrar de la tabla");
            entity.Property(e => e.RoleId).HasComment("Id único de la regla");
            entity.Property(e => e.TableRowId).HasComment("Identificador único de la tabla");
            entity.Property(e => e.TypeQueryId).HasComment("Tipo de query, se refiere a los objetos diseñados para generar las consultas");

            entity.HasOne(d => d.Role).WithMany(p => p.SegRowsPermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_RowsPermissions_SEG_Roles");

            entity.HasOne(d => d.TableRow).WithMany(p => p.SegRowsPermissions)
                .HasForeignKey(d => d.TableRowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_RowsPermissions_SEG_TableRows");
        });

        modelBuilder.Entity<SegSystemTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_Syst__3214EC07C92A0C3E");

            entity.ToTable("SEG_SystemTables");

            entity.HasIndex(e => e.TableName, "UQ__SEG_Syst__733652EE129A5B30").IsUnique();

            entity.Property(e => e.Id).HasComment("Identificador único de la tabla");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasComment("Descripción de para que es la tabla");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Indicador de si esta activa");
            entity.Property(e => e.TableName)
                .HasMaxLength(100)
                .HasComment("Nombre de la tabla de la Base de Datos");
        });

        modelBuilder.Entity<SegTableField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_Tabl__3214EC07DC9AC8DB");

            entity.ToTable("SEG_TableFields", tb => tb.HasComment("Tablas del sistema"));

            entity.HasIndex(e => new { e.TableId, e.FieldName }, "UQ__SEG_Tabl__17D7719579982502").IsUnique();

            entity.Property(e => e.Id).HasComment("Identificador único del campo");
            entity.Property(e => e.CreatedAt)
                .HasComment("Fecha de creación")
                .HasDefaultValueSql("(getdate())", "DF__SEG_Table__Creat__444B1483");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .HasComment("Tipo de datos");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .HasComment("Nombre descriptivo del campo");
            entity.Property(e => e.FieldName)
                .HasMaxLength(100)
                .HasComment("Nombre del campo de la tabla");
            entity.Property(e => e.IsActive)
                .HasComment("Indicador de si esta activa")
                .HasDefaultValue(true, "DF__SEG_Table__IsAct__4356F04A");
            entity.Property(e => e.IsDefaultDb)
                .HasComment("Indicador de que el campo es por defecto de la Base de datos y no se debe tener encuenta en la inserción")
                .HasColumnName("IsDefaultDB");
            entity.Property(e => e.TableId).HasComment("Identificador único de la tabla");

            entity.HasOne(d => d.Table).WithMany(p => p.SegTableFields)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("FK__SEG_Table__Table__453F38BC");
        });

        modelBuilder.Entity<SegTablePermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TablePer__3214EC0738F18F7D");

            entity.ToTable("SEG_TablePermissions");

            entity.HasIndex(e => new { e.RoleId, e.TableId }, "UQ__TablePer__7D2F3E05F047CEA2").IsUnique();

            entity.Property(e => e.CanCreate).HasComment("Indicador de si puede Crear registros en la tabla");
            entity.Property(e => e.CanDelete).HasComment("Indicador de si puede Eliminar registros de la tabla");
            entity.Property(e => e.CanEdit).HasComment("Indicador de si puede Editar la tabla");
            entity.Property(e => e.CanExport).HasComment("Indicador de si puede Exportar información de la tabla");
            entity.Property(e => e.CanView).HasComment("Indicador de si puede Visualizar la tabla");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.RoleId).HasComment("Id único de la regla");
            entity.Property(e => e.TableId).HasComment("Identificador único de la tabla");

            entity.HasOne(d => d.Role).WithMany(p => p.SegTablePermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__TablePerm__RoleI__3E923B2D");

            entity.HasOne(d => d.Table).WithMany(p => p.SegTablePermissions)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("FK__TablePerm__Table__3F865F66");
        });

        modelBuilder.Entity<SegTableRow>(entity =>
        {
            entity.ToTable("SEG_TableRows");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Identificador único del campo");
            entity.Property(e => e.Query).IsUnicode(false);
            entity.Property(e => e.TableId).HasComment("Identificador único de la tabla");
            entity.Property(e => e.TypeQueryId).HasComment("Tipo de query, se refiere a los objetos diseñados para generar las consultas");

            entity.HasOne(d => d.Table).WithMany(p => p.SegTableRows)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_TableRows_SEG_SystemTables");

            entity.HasOne(d => d.TypeQuery).WithMany(p => p.SegTableRows)
                .HasForeignKey(d => d.TypeQueryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SEG_TableRows_SEG_TypeQuery");
        });

        modelBuilder.Entity<SegTypeQuery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Seg_TypeQuery");

            entity.ToTable("SEG_TypeQuery");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TypeQueryName).HasMaxLength(50);
        });

        modelBuilder.Entity<SegUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SEG_User__3214EC077AAA7E61");

            entity.ToTable("SEG_Users", tb => tb.HasComment("Tabla para el manejo de los usuarios"));

            entity.HasIndex(e => e.Username, "UQ__SEG_User__536C85E47F6B2D63").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__SEG_User__A9D105344D3EAFE9").IsUnique();

            entity.Property(e => e.Id).HasComment("Indicador unico del usuario");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasComment("Correo electronico");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasComment("Indicador de activo");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasComment("Clave");
            entity.Property(e => e.UpdatedAt).HasComment("Fecha de actualización");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasComment("Nombre del usuario");
        });

        modelBuilder.Entity<SegUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC077DFF807C");

            entity.ToTable("SEG_UserRoles");

            entity.HasIndex(e => new { e.UserId, e.RoleId }, "UQ__UserRole__AF2760AC91F3D006").IsUnique();

            entity.Property(e => e.Id).HasComment("Indicador unico del Usuario y la regla");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación");
            entity.Property(e => e.RoleId).HasComment("Id único de la regla");
            entity.Property(e => e.UserId).HasComment("Indicador unico del usuario");

            entity.HasOne(d => d.Role).WithMany(p => p.SegUserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__UserRoles__RoleI__200DB40D");

            entity.HasOne(d => d.User).WithMany(p => p.SegUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserRoles__UserI__1F198FD4");
        });

        modelBuilder.Entity<Table3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table3");

            entity.Property(e => e.IditemProceso).HasColumnName("IDItemProceso");
            entity.Property(e => e.IditemProcesoSig)
                .HasComment("Identificador de la actividad")
                .HasColumnName("IDItemProcesoSig");
            entity.Property(e => e.Idproceso)
                .HasComment("Identificador del proceso")
                .HasDefaultValue(1, "DF_Table3_IDProceso")
                .HasColumnName("IDProceso");
            entity.Property(e => e.Swactivo)
                .HasDefaultValue(true, "DF_Table3_SWActivo")
                .HasColumnName("SWActivo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
