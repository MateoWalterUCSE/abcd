using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.Producto;

namespace Tp___AppCook2._0
{
    public class ControlTipiadoYCampos
    {
        

        internal bool VerificarSeleccion(int indiceSeleccion)
        {
            if (indiceSeleccion >= 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
        
        internal void SoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;//si entra entonces agrego
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        internal void SoloNumerosEnteros(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        internal void SoloNumerosEnterosYDecimales(KeyPressEventArgs e, string pText)
        {
            bool Bandera = pText.Any(x => x == ',');
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' && !Bandera) //solo existe una coma
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        internal void SoloNumerosDecimales(KeyPressEventArgs e, string pText)
        {
            bool Bandera = pText.Any(x => x == ',');//primer (,) va a ser false
                                                    //si contiene la bandera va  ser false
            if (Char.IsNumber(e.KeyChar))           //para que la siguiente coma no se pueda cargar
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' && !Bandera) //solo existe una coma
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
    }
}
