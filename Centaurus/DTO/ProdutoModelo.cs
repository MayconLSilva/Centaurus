using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.Model
{
    public class ProdutoModelo
    {
        public int idProduto { get; set; }
        public bool ativoProduto { get; set; }
        public bool descontinuadoProduto { get; set; }
        public char tipoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public string unidadeProduto { get; set; }
        public float vendaProduto { get; set; }
        public double saldoProduto { get; set; }
        public string marcaProduto { get; set; }
        public string categoriaProduto { get; set; }
        public string subCategoriaProduto { get; set; }
        public string fornecedorProduto { get; set; }
        public string codFabricanteProduto { get; set; }
        public string codBarrasProduto { get; set; }
        public string codInternoProduto { get; set; }
        public string dataCadastroProduto { get; set; }
        public string dataAlteracaoProduto { get; set; }
        public string usuarioCadastroProduto { get; set; }
        public string usuarioAlteracaoProduto { get; set; }
        public float ultimoCustoCompraProduto { get; set; }
        public float custoAnteriorProduto { get; set; }
        public float custoFinalProduto { get; set; }

        //Váriaveis utilizadas para carregar o nome
        public string nomeCategoria { get; set; }
        public string nomeSubCategoria { get; set; }
        public string nomeMarca { get; set; }
        public string nomeFornecedor { get; set; }

        //Váriaveis utilizadas para aba variação
        public int idProdVariacao { get; set; }
        public string unProdVariacao { get; set; }
        public char fatorProdVariacao { get; set; }
        public double qtdProdVariacao { get; set; }
        public string codBarrasVariacao { get; set; }
    }
}
