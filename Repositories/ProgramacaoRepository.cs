using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class ProgramacaoRepository
    {
        public static void Save(Programacao programacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(programacao.Usuario).State = EntityState.Unchanged;
                    if (programacao.Id == 0)
                    {
                        dbContext.Programacoes.Add(programacao);
                    }
                    else
                    {
                        dbContext.Entry(programacao).State
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

        public static List<Programacao> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Programacoes.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Programacao FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Programacoes.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Programacao> FindByUsuario(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Programacoes
                        .Include("Usuario")
                        .Where(p => p.Usuario.Id == usuario.Id)
                        .ToList<Programacao>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Programacao programacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Programacoes.Attach(programacao);
                    dbContext.Programacoes.Remove(programacao);
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
