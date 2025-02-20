using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class FrequenciaRepository
    {
        public static void Save(Frequencia frequencia)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (frequencia.Id == 0)
                    {
                        dbContext.Frequencias.Add(frequencia);
                    }
                    else
                    {
                        dbContext.Entry(frequencia).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Frequencia> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Frequencias.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Frequencia FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Frequencias.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Frequencia> FindByUsuario(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Frequencias
                        .Include("Usuario")
                        .Where(p => p.Usuario.Id == usuario.Id)
                        .ToList<Frequencia>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Frequencia frequencia)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Frequencias.Attach(frequencia);
                    dbContext.Frequencias.Remove(frequencia);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
