using System;
using System.Windows.Forms;

namespace Tp___AppCook2._0
{
    public class UtilidadesDeGrillas
    {
        internal static void CargarAccionesDeGrilla(DataGridView grilla)
        {
            int indiceColumnaEditar = ObtenerIndice(grilla, "Editar");
            int indiceColumnaEliminar = ObtenerIndice(grilla, "Eliminar");

            foreach (DataGridViewRow row in grilla.Rows)
            {
                row.Cells[indiceColumnaEliminar].Value = "Eliminar";
                row.Cells[indiceColumnaEditar].Value = "Editar";
            }
        }

        internal static int ObtenerIndice(DataGridView grilla, string nombreColumna)
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna) //El valor de la columna que yo le paso es igual a la columna actual?
                {
                    return column.Index; //devuelvo el indice de la columna con ese nombre que le pase por parametro
                    
                }
            }

            throw new Exception("No hay una columna con nombre solicitado en la grilla");
        }
    }
    
}