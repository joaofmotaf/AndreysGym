using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class TreinoRepository
    {
        public static void Save(Treino treino)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(treino.Programacao).State = EntityState.Unchanged;
                    if (treino.Id == 0)
                    {
                        dbContext.Treinos.Add(treino);
                    }
                    else
                    {
                        dbContext.Entry(treino).State
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

        public static List<Treino> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Treinos.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Treino FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Treinos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Treino> FindByProgramacao(Programacao programacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Treinos
                        .Include("Programacao")
                        .Where(t => t.Programacao.Id == programacao.Id)
                        .ToList<Treino>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Treino FindWExercicios(Treino treino)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Treinos
                        .Include("Exercicios")
                        .Where(t => t.Id == treino.Id)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Remove(Treino treino)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Treinos.Attach(treino);
                    dbContext.Treinos.Remove(treino);
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
