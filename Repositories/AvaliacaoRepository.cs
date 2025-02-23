using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class AvaliacaoRepository
    {
        public static void Save(Avaliacao avaliacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(avaliacao.Usuario).State = EntityState.Unchanged;
                    if (avaliacao.Id == 0)
                    {
                        dbContext.Avaliacoes.Add(avaliacao);
                    }
                    else
                    {
                        dbContext.Entry(avaliacao).State
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

        public static List<Avaliacao> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Avaliacoes.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Avaliacao FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Avaliacoes.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Avaliacao> FindByUsuario(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Avaliacoes
                        .Include("Usuario")
                        .Where(p => p.Usuario.Id == usuario.Id)
                        .ToList<Avaliacao>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Avaliacao avaliacao)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Avaliacoes.Attach(avaliacao);
                    dbContext.Avaliacoes.Remove(avaliacao);
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
