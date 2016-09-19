using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.Ajax.DAL
{
    public class Db
    {
        public static string BuscarProduto(int query)
        {
            using (var ctx = new AdventureWorksLT2008Entities())
            {
                try
                {
                    return ctx.Product.Where(p => p.ProductID == query).FirstOrDefault<Product>().Name;
                }
                catch
                {
                    return "nenhum produto com código " + query;
                }
            }
        }

        public static List<Product> ListarProdutos(string query)
        {
            using (var ctx = new AdventureWorksLT2008Entities())
            {
                if (string.IsNullOrEmpty(query))
                    return ctx.Product.ToList<Product>();

                return ctx.Product.Where(p => p.Name.StartsWith(query)).ToList<Product>();
            }
        }
    }
}