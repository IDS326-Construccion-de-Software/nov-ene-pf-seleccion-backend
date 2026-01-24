using System.ComponentModel.DataAnnotations;
using SistemaAcademico.Modules.Support.Core.Enums;

namespace SistemaAcademico.Modules.Support.Core.DTOs
{
    public record CreateSupportTicketDto
    {
        [Required(ErrorMessage = "Subject ID is required")]
        public string SubjectId { get; init; }

        [Required(ErrorMessage = "Reason is required")]
        public SupportReason Reason { get; init; }
    }
}