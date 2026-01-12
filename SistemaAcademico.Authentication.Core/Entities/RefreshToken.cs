using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Entities
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Token { get; set; } = null!;
        public DateTime ExpiraEn { get; set; }
        public bool Revocado { get; set; }
    }
}
