using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; 
using CapaEntidad;
using Microsoft.Identity.Client;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario(); 

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar(); 
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty; 

            if(obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n"; 
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if(Mensaje != string.Empty)
            {
                return 0; 
            }
            else
            {
                return objcd_usuario.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
      
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }

        public static string GenerarNuevaClave()
        {
            Random random = new Random();
            string nuevaClave = "";
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            for (int i = 0; i < 8; i++)
            {
                nuevaClave += caracteres[random.Next(caracteres.Length)];
            }
            return nuevaClave;
        }

        public static void RestablecerClave(string documento)
        {
            string correo = CD_Usuario.ObtenerCorreoPorDocumento(documento);
            if (correo != null)
            {
                string nuevaClave = GenerarNuevaClave();
                CD_Usuario.ActualizarClave(documento, nuevaClave);
                EnviarCorreo(correo, nuevaClave);
            }
            else
            {
                throw new Exception("El documento ingresado no existe.");
            }
        }

        private static void EnviarCorreo(string correoDestinatario, string nuevaClave)
        {
            try
            {
                var mensaje = new MailMessage();
                mensaje.From = new MailAddress("juancruzrodriguez3@gmail.com");  // Correo desde el cual se enviará
                mensaje.To.Add(correoDestinatario);
                mensaje.Subject = "Recuperación de Clave";
                mensaje.Body = $"Hola,\n\nTu nueva clave es: {nuevaClave}\n\nRecuerda pedirle a un administrador que la cambie.\n\nSaludos,\nSoporte Técnico";

                var cliente = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("juancruzrodriguez3@gmail.com", "gutv hwxx tmqq yvvj"),
                    EnableSsl = true
                };
                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
