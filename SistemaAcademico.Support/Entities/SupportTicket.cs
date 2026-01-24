using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaAcademico.Modules.Support.Core.Enums;

namespace SistemaAcademico.Modules.Support.Core.Entities
{
    [Table("Soporte")]
    public class SupportTicket
    {
        [Key]
        [Column("ID_Soporte")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ID_Usuario")]
        [Required]
        public string UserId { get; set; }

        [Column("ID_Asignatura")]
        [Required]
        public string SubjectId { get; set; }

        [Column("motivoSolicitud")]
        [Required]
        public SupportReason Reason { get; set; }

        public SupportTicket() { }
    }
}