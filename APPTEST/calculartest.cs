// Archivo: APPTES/calculartest.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace APPTES
{
    // [TestClass] indica que esta clase contiene métodos de prueba
    [TestClass]
    public class Calculartest
    {
        // 1. PRUEBA DE ÉXITO (Resultado Positivo)
        // [TestMethod] indica que este es un método de prueba ejecutable
        [TestMethod]
        public void TestHashPassword_ContrasenaValida_RetornaHashNoVacio() 
        {
            // Arrange: Preparar el escenario y los datos
            var manejador = new ManejadorSeguridad();
            string passwordEntrada = "passwordsegura"; // Contraseña válida

            // Act: Ejecutar la función a probar
            string hashResultado = manejador.HashPassword(passwordEntrada);

            // Assert: Verificar el resultado
            // 1. El hash no debe ser nulo o vacío
            Assert.IsFalse(string.IsNullOrEmpty(hashResultado), "El hash no debe ser nulo o vacío.");
            // 2. El hash no debe ser igual a la entrada (demuestra que el cifrado funcionó)
            Assert.AreNotEqual(passwordEntrada, hashResultado, "El hash debe ser diferente a la contraseña de entrada.");
        }
        
        // 2. PRUEBA DE FALLA ESPERADA (Resultado con Excepción)
        [TestMethod]
        // [ExpectedException] indica que esta prueba SOLO PASA si se lanza la ArgumentException
        [ExpectedException(typeof(ArgumentException))]
        public void TestHashPassword_ContrasenaVacia_LanzaArgumentException()
        {
            // Arrange
            var manejador = new ManejadorSeguridad();
            string passwordEntrada = ""; // Contraseña inválida/vacía

            // Act
            // Al llamar a la función con una entrada vacía, ESPERAMOS que lance la excepción.
            // Si la excepción se lanza, la prueba pasa. Si no se lanza, la prueba falla.
            manejador.HashPassword(passwordEntrada);
            
            // No se necesita Assert adicional porque [ExpectedException] hace la verificación.
        }
    }
}