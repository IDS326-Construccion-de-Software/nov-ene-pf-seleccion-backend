namespace SistemaAcademico.Modules.Support.Core.Enums
{
    public enum SupportReason
    {
        ScheduleConflict = 0,    // ConflictoDeHorarioEntreAsignaturas
        SectionFull = 1,         // FaltaDeCupoEnSeccion
        InvoluntaryDrop = 2,     // BajaInvoluntariaDeAsignatura
        SubjectNotFound = 3      // NoApareceLaAsignatura
    }
}