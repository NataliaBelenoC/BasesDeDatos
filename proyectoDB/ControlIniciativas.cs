using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDB
{
    internal class ControlIniciativas
    {
        public string ctrlRegistro(Iniciativas iniciativa)
        {
            ModeloIniciativas modeloIniciativas = new ModeloIniciativas();
            string respuesta = "";

            if (string.IsNullOrEmpty(iniciativa.Nombrei) || string.IsNullOrEmpty(iniciativa.SituacionProblema) || string.IsNullOrEmpty(iniciativa.MarcoConceptual) || string.IsNullOrEmpty(iniciativa.MarcoTecnologico) || string.IsNullOrEmpty(iniciativa.EstadoArte) || string.IsNullOrEmpty(iniciativa.Metodología) || string.IsNullOrEmpty(iniciativa.Objetivos) || string.IsNullOrEmpty(iniciativa.Justificacion) || string.IsNullOrEmpty(iniciativa.Referencias))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (iniciativa.Nombrei == iniciativa.Nombrei)
                {
                    if (modeloIniciativas.existeIniciativa(iniciativa.Nombrei))
                    {
                        respuesta = "La iniciativa ya existe";
                    }
                }
            }
            return respuesta;

        }
    }
}
