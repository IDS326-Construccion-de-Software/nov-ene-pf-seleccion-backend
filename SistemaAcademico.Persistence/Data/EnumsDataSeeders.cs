namespace SistemaAcademico.Persistence.Data
{
    public enum EstatusSeccion
    {
        Activa,
        Cerrada,
        Cancelada
    }

    public enum ModalidadSeccion
    {
        Presencial,
        Virtual,
        Hibrida
    }

    public enum TipoAsignatura
    {
        Teoría,
        Laboratorio,
        Electiva
    }

    public enum EstatusPrograma
    {
        Inactivo,
        Activo
    }

    public enum EstatusProfesor
    {
        Activo,
        Licencia,
        Inactivo
    }

    public enum PeriodoEstatus
    {
        Planificacion,
        Activo,
        Cerrado
    }

    public enum SeleccionEstatus
    {
        Inscrito,
        Cursando,
        Retirado,
        PendienteNota,
        Procesado
    }

    public enum HistorialEstatus
    {
        Cursando,
        Aprobado,
        Reprobado,
        Retirado
        Convalidado,
        Exonerado
        Seleccionado,
        Preseleccionado
    }

    public enum DiaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    public enum EstatusUsuario
    {
        Activo,
        Inactivo,
        Suspendido
    }
}
