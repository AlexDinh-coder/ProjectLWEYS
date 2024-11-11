using BusinessObject.BaseModel;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    internal class Email
    {
        private readonly IConfiguration _configuration;
        public Email(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<bool> SendEmailAsync(EmailModel emailModel)
        {
            try
            {
                var emailMessage = new MimeMessage();
                emailMessage.From.Add(new MailboxAddress(_configuration["SmtpSettings:SenderName"], _configuration["SmtpSettings:SenderEmail"]));

                if (emailModel.To != null)
                {
                    foreach (var email in emailModel.To)
                    {
                        emailMessage.To.Add(new MailboxAddress("", email));
                    }
                }              
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
