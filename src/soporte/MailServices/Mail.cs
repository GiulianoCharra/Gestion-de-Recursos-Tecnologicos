using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.soporte
{
    internal class Mail : MailService
    {
        public Mail()
        {
            senderMail = "compu.mundo.hiper.mega.red.utn.frc1@gmail.com";
            password = "bwuvivaznipvhqtt";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initializeSmtpClient();
        }
    }
}
