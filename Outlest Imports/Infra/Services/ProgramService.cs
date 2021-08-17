
using Domain.EF.Entity;
using System;
using System.Linq;

namespace Infra.Services
{
    public class ProgramService : ServiceBase
    {
        public int InserirProdutos(Produtos Registro)
        {
            try
            {
                contexto.Set<Produtos>().Add(Registro);

                contexto.SaveChanges();

                return Registro.Codigo;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public int InserirEstoque(Estoque Registro)
        {
            try
            {
                contexto.Set<Estoque>().Add(Registro);

                contexto.SaveChanges();

                return Registro.CodigoProduto;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public int AtualizaProdutos(Produtos Registro)
        {
            try
            {
               var Produto = contexto.Produtos.SingleOrDefault(t => t.Codigo == Registro.Codigo);

                contexto.Entry(Produto).CurrentValues.SetValues(Registro);
                contexto.SaveChanges();
                return Registro.Codigo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AtualizaEstoque(Estoque Registro)
        {
            try
            {
                contexto.Estoque.SingleOrDefault(t => t.CodigoProduto == Registro.CodigoProduto);

                contexto.Entry(Registro).CurrentValues.SetValues(Registro);
                contexto.SaveChanges();

                return Registro.CodigoProduto;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluiProdutos(Produtos Registro)
        {
            try
            {
                var Produto = contexto.Produtos.SingleOrDefault(t => t.Codigo == Registro.Codigo);

                contexto.Set<Produtos>().Remove(Produto);
                contexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluiEstoque(Estoque Registro)
        {
            try
            {
                contexto.Estoque.SingleOrDefault(t => t.CodigoProduto == Registro.CodigoProduto);

                contexto.Set<Estoque>().Remove(Registro);
                contexto.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
