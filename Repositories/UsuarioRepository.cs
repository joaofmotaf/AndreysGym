using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndreysGym.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AndreysGym.Repositories
{
    public class UsuarioRepository
    {
        public static void Save(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (usuario.Plano != null)
                    {
                        dbContext.Entry(usuario.Plano).State = EntityState.Unchanged;
                    }
                    if (usuario.Id == 0)
                    {
                        dbContext.Usuarios.Add(usuario);
                    }
                    else
                    {
                        dbContext.Entry(usuario).State
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

        public static List<Usuario> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Credencial)
                        .Include(u => u.TreinoAtual)
                        .Include(u => u.Plano)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Credencial)
                        .Include(u => u.TreinoAtual)
                        .Include(u => u.Plano)
                        .Where(u => u.Id == id)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario FindByIdWCredencial(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Credencial)
                        .Include(u => u.TreinoAtual)
                        .Include(u => u.Plano)
                        .Where(u => u.Id == id)
                        .FirstOrDefault<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Credencial)
                        .Include(u => u.TreinoAtual)
                        .Include(u => u.Plano)
                        .Where(u => u.Nome.Contains(partialName))
                        .ToList<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario Autenticar(String email, String senha)
        {
            Credencial credencial = new Credencial
            {
                Email = email,
                Senha = senha
            };
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Credencial)
                        .Include(u => u.TreinoAtual)
                        .Include(u => u.Plano)
                        .Where(u => u.Credencial.Email == credencial.Email
                            && u.Credencial.Senha == credencial.Senha)
                        .FirstOrDefault<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Remove(Usuario usuario)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    usuario = FindByIdWCredencial(usuario.Id);
                    usuario.TreinoAtual = null;
                    dbContext.SaveChanges();
                    dbContext.Usuarios.Attach(usuario);
                    dbContext.Usuarios.Remove(usuario);

                    // OR

                    // But cascade delete fails...
                    //dbContext.Entry(usuario).State
                    //    = EntityState.Deleted;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario FindByIdWPlano(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Usuarios
                        .Include(u => u.Plano)
                        .Where(u => u.Id == id)
                        .FirstOrDefault<Usuario>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
