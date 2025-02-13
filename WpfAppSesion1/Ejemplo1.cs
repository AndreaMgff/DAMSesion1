using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppSesion1
{   
    
    /// <summary>
/// Clase de ejemplo
/// </summary>
    internal class Ejemplo1
    {
        public int numero;
        public string texto;
        /// <summary>
        /// Este constructor iguala numero a n
        /// </summary>
        /// <param name="n"> n es el valor para numero</param>
        public Ejemplo1(int n)
        {
            this.Funcion3();
            numero = n;
        }
        /// <summary>
        ///Este texto es de ejemplo de la funcion1
        /// </summary>
        /// <param name="txt">recibe el texto</param>
        public void Funcion1(string txt)
        {
            texto = txt;
        }
        /// <summary>
        /// Texto de ejemplo
        /// </summary>
        /// <returns>Devuelve un numero</returns>
        public int Funcion2()
        {
            return numero;
        }
        /// <summary>
        /// Texto de ejemplo de la funcion 3
        /// </summary>
        /// <returns>Devuelve texto</returns>
        public string Funcion3()
        {
            return texto;
        }
    }
}
