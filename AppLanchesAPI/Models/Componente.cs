using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Domain
{
    public class Componente
    {
        public int Id { get; set; }
        public int Id_Produto { get; set; }
        public string Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string Unid { get; set; }
        public double Quantidade { get; set; }
        public Produto Produto { get; set; }
    
    }
}
