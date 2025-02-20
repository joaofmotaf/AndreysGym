using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class PlanoRepository
    {
        public static void Save(Plano plano)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (plano.Id == 0)
                    {
                        dbContext.Planos.Add(plano);
                    }
                    else
                    {
                        dbContext.Entry(plano).State
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

        public static List<Plano> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Planos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Plano FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Planos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Plano plano)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Planos.Attach(plano);
                    dbContext.Planos.Remove(plano);
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
