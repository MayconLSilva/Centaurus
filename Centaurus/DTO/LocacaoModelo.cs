using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.DTO
{
    public class LocacaoModelo
    {
        public int idLocacao { get; set; }
        public DateTime dataPrevisaoEntregaLocao { get; set; }
        public DateTime dataLancamentoLocao { get; set; }
        public string idClienteLocao { get; set; }
        public float descontoLocao { get; set; }
        public float totalLocao { get; set; }
        public double qtdItensLocao { get; set; }
        public string usuarioLocacao { get; set; }

        //VARIÁVEIS REF. LOCAÇÃO ITENS
        public int idProdutoLocacaoItens { get; set; }
        public float valorLocadoLocacaoItens { get; set; }
        public float valorOriginalLocacaoItens { get; set; }
        public float custoDiaLocacaoItens { get; set; }
        public int idLocacaoLocacaoItens { get; set; }
        public double qtdItensLocacaoItens { get; set; }
        public int idVariacaoProdutoLocacaoItens { get; set; }
    }
}
