using System;
using System.Threading.Tasks;
using SistemaAcademico.Modules.Support.Core.DTOs;
using SistemaAcademico.Modules.Support.Core.Entities;
using SistemaAcademico.Modules.Support.Core.Interfaces;

namespace SistemaAcademico.Modules.Support.Core.Services
{
    public class SupportService : ISupportService
    {
        private readonly ISupportRepository _repository;

        public SupportService(ISupportRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateTicketAsync(string userId, CreateSupportTicketDto dto)
        {
            if (string.IsNullOrEmpty(userId)) throw new ArgumentException("User ID is required");

            var newTicket = new SupportTicket
            {
                UserId = userId,
                SubjectId = dto.SubjectId,
                Reason = dto.Reason
            };

            await _repository.AddAsync(newTicket);
            return newTicket.Id;
        }
    }
}