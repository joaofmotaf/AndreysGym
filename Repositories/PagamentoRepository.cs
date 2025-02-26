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


    }
}
