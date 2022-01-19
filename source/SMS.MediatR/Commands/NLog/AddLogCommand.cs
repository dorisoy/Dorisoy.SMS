using MediatR;
using SMS.Data.Dto;
using SMS.Infrastructure.Helper;

namespace SMS.MediatR.Commands
{
    public class AddLogCommand : IRequest<ServiceResponse<NLogDto>>
    {
        public string ErrorMessage { get; set; }
        public string Stack { get; set; }
    }
}
