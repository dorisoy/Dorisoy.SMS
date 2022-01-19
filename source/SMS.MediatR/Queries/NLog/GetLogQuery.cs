using MediatR;
using System;
using SMS.Data.Dto;
using SMS.Infrastructure.Helper;

namespace SMS.MediatR.Queries
{
    public class GetLogQuery : IRequest<ServiceResponse<NLogDto>>
    {
        public Guid Id { get; set; }
    }
}
