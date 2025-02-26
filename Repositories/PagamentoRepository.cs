using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreysGym.Repositories
{
    public class PagamentoRepository
    {
        public static void Save(Pagamento pagamento)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(pagamento.Usuario).State = EntityState.Unchanged;
                    dbContext.Entry(pagamento.Plano).State = EntityState.Unchanged;
                    if (pagamento.Id == 0)
                    {
                        dbContext.Pagamentos.Add(pagamento);
                    }
                    else
                    {
                        dbContext.Entry(pagamento).State
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
        public static List<Pagamento> FindByUsuario(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Pagamentos
                        .Include(p => p.Usuario)
                        .Include(p => p.Plano)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
