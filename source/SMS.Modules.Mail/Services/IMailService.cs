using System.Collections.Generic;
using SMS.Modules.Mail.Models;

namespace SMS.Modules.Mail.Services
{
  public interface IMailService
  {
    IEnumerable<MailMessage> Messages { get; set; }

    void GetMessages(string folder);

    void Send(MailMessage message);
  }
}