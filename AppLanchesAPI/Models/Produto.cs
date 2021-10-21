using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string Unid { get; set; }
        public List<Componente> Componentes { get; set; }
    }
}
