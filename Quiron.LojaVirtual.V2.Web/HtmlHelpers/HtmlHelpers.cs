using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.V2.Web.HtmlHelpers
{
    using Models;
    public static class HtmlHelpers
    {
        //Representa uma cadeia de caracteres codificada em HTML que não deve ser codificada novamente.
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            //objeto dinâmico que permite que você expanda o número de caracteres na cadeia de caracteres que ele encapsula
            StringBuilder resultado = new StringBuilder();

            
            for (int i = 1; i <= paginacao.TotalPagina; i++)
            {
                //Representa uma classe que é usada por auxiliares HTML para criar elementos HTML.
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");

                }

                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);


            }

            return MvcHtmlString.Create(resultado.ToString());
        }

    }
}