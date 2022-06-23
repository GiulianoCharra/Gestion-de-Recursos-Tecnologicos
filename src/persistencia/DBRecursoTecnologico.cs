using Gestión_de_Recursos_Tecnológicos.src.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Recursos_Tecnológicos.src.persistencia
{
    internal class DBRecursoTecnologico
    {

        public ArrayList findAll()
        {
            ArrayList recursos = new ArrayList();

            string query = "SELECT * FROM [dbo].[RECURSOS_TECNOLOGICOS]";

            DataTable resultados = Conexion.EjecutarComando(query);

            foreach (DataRow row in resultados.Rows)
            {
                int id_recurso_tecnologico = Convert.ToInt32(row[0]);
                int id_tipo_recurso_tecnologico = Convert.ToInt32(row[1]);
                int id_marca = Convert.ToInt32(row[2]);
                int id_modelo = Convert.ToInt32(row[3]);
                DateTime fecha_alta = Convert.ToDateTime(row[4]);
                Image image = (Image)row[5];
                string descripcion = Convert.ToString(row[6]);
                int id_responsable_tecnico = Convert.ToInt32(row[7]);
                int id_centro_investigacion = Convert.ToInt32(row[8]);
                int id_personal_cientifico = Convert.ToInt32(row[9]);
                DateTime time = Convert.ToDateTime(row[10]);
                TimeSpan fraccionamiento = new TimeSpan(time.Hour, time.Minute, time.Second);

                RecursoTecnologico rt = new RecursoTecnologico();
            }

            return recursos;
        }

    }
}
