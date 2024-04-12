using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2Notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificable notificadorEmail = new NotificacionEmail("sorellanag3@miumg.edu.gt");
            notificadorEmail.Notifica(" Hola,soy Sinthia");
            
            INotificable notificadorWhatsapp = new NotificacionWhatsap("+502 5905-4810");
            notificadorWhatsapp.Notifica("He enviado un correo");
         
            INotificable notificadorSMS = new NotificacionSMS("+502 3456-5766");
            notificadorSMS.Notifica("Me gustan los k-dramas");

            Console.ReadLine();
        }
    }
    public interface INotificable
    {
        void Notifica(string mensaje);
    }

    public class NotificacionEmail : INotificable
    {
        public string DirreccionCorreo { get; set; }
        public NotificacionEmail(string dirreccionCorreo)
        {
            DirreccionCorreo = dirreccionCorreo;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Enviando Email a {DirreccionCorreo}:{mensaje}");
        }
    }

    public class NotificacionWhatsap : INotificable
    {
        public string NumeroTelefono { get; set; }
        public NotificacionWhatsap(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        public void Notifica( string mensaje)
        {
            Console.WriteLine($"Enviando WhatsApp al {NumeroTelefono}: {mensaje}");
        }
    }

    public class NotificacionSMS : INotificable
    {
        public string NumeroTelefono { get; set; }
        public NotificacionSMS(string numeroTelefono)
        {
            NumeroTelefono = numeroTelefono;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Enviando SMS al {NumeroTelefono}: {mensaje}");
        }
    }
}
