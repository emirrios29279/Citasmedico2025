// Dentro de WebCitasM/Lógica/ManejadorSeguridad.cs
using System;
using System.Security.Cryptography;
using System.Text;

namespace WebCitasM
{
    public class ManejadorSeguridad
    {
        // Método que se probará para validar si una contraseña es válida y para probar la excepción.
        public string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                // Este es el punto que usaremos para la prueba de excepción/falla.
                throw new ArgumentException("La contraseña no puede ser nula o vacía.", nameof(password));
            }

            // Simulación de hashing usando SHA-256 (como se mencionó en el documento)
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}