using Mensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Model;

namespace Servidor.Servicios
{
    /// <summary>
    /// Summary description for PersonaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonaWS : System.Web.Services.WebService
    {

        [WebMethod]
        public PersonaMSJ Guardar(PersonaMSJ personamsj)
        {
            
            PERSONA persona = new PERSONA();
            persona.TIPOIDENTIFICACION = personamsj.CODIGOTIPOIDENTIFICACION;
            persona.IDENTIFICACION = personamsj.IDENTIFICACION;
            persona.PRIMERNOMBRE = personamsj.PRIMERNOMBRE;
            persona.SEGUNDONOMBRE = personamsj.SEGUNDONOMBRE;
            persona.PRIMERAPELLIDO = personamsj.PRIMERAPELLIDO;
            persona.SEGUNDOAPELLIDO = personamsj.SEGUNDOAPELLIDO;
            persona.ESTAACTIVO = true;

            persona = PERSONA_Negocio.Guardar(persona);
            personamsj.SECUENCIAL = persona.SECUENCIAL;

            return personamsj;
        }

        [WebMethod]
        public List<PersonaMSJ> Listar()
        {
            List<PersonaMSJ> mensajeSalida = new List<PersonaMSJ>();
            try
            {
                List<PERSONA> listaPersonas = PERSONA_Negocio.Listar();
                foreach (PERSONA persona in listaPersonas)
                {
                    PersonaMSJ per = new PersonaMSJ(persona.SECUENCIAL,
                        persona.TIPOIDENTIFICACION,
                        persona.IDENTIFICACION,
                        persona.PRIMERNOMBRE,
                        persona.SEGUNDONOMBRE,
                        persona.PRIMERAPELLIDO,
                        persona.SEGUNDOAPELLIDO,
                        persona.ESTAACTIVO
                        );

                    mensajeSalida.Add(per);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mensajeSalida;
        }

        [WebMethod]
        public PersonaMSJ BuscarPorIdentificacion(string identificacion)
        {
            PersonaMSJ personaMSJ = null;
            try
            {
                PERSONA persona = PERSONA_Negocio.BuscarPorIdentificacion(identificacion);
                if (persona != null)
                {
                    personaMSJ = new PersonaMSJ(persona.SECUENCIAL,
                            persona.TIPOIDENTIFICACION,
                            persona.IDENTIFICACION,
                            persona.PRIMERNOMBRE,
                            persona.SEGUNDONOMBRE,
                            persona.PRIMERAPELLIDO,
                            persona.SEGUNDOAPELLIDO,
                            persona.ESTAACTIVO
                            );
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return personaMSJ;
        }
    }
}
