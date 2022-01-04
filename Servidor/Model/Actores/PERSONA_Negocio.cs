using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class PERSONA_Negocio
    {        
        public static PERSONA Guardar(PERSONA p)
        {
            TestContactarEntities db = new TestContactarEntities();
            try
            {                
                if (p != null)
                {
                    PERSONA persona = db.PERSONA.Where(x => x.IDENTIFICACION == p.IDENTIFICACION).FirstOrDefault();
                    if (persona == null)
                    {
                        db.PERSONA.Add(p);
                        db.SaveChanges();
                    }
                    else                    
                    {
                        persona.PRIMERNOMBRE = p.PRIMERNOMBRE;
                        persona.SEGUNDONOMBRE = p.SEGUNDONOMBRE;
                        persona.PRIMERAPELLIDO = p.PRIMERAPELLIDO;
                        persona.SEGUNDOAPELLIDO = p.SEGUNDOAPELLIDO;

                        db.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public static PERSONA BuscarPorIdentificacion(string identificacion)
        {
            TestContactarEntities db = new TestContactarEntities();

            PERSONA persona = null;
            try
            {
               persona = db.PERSONA.Where(x => x.IDENTIFICACION == identificacion).FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return persona;
        }

        public static List<PERSONA> Listar()
        {
            List<PERSONA> listaPersonas = new List<PERSONA>();

            TestContactarEntities db = new TestContactarEntities();
            try
            {
                listaPersonas = db.PERSONA.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listaPersonas;

        }
    }
}
