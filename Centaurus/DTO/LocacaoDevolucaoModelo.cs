﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.DTO
{
    public class LocacaoDevolucaoModelo
    {
        public int idLocacaoDev { get; set; }
        public int idClienteLocacaoDev { get; set; }
        public string nomeClienteLocacaoDev { get; set; }
        public DateTime dataLancamentoLocacaoDev { get; set; }
        public DateTime dataDevolucaoLocacaoDev { get; set; }
        public int idLocacao { get; set; }
        public float totalLocacaoDev { get; set; }
        public double qtdItensLocacaoDev { get; set; }
        public string usuarioLocacaoDev { get; set; }
        public int codigoItem { get; set; }

        //váriaveis ref. aos itens
        public int idProdutoDevLocacao { get; set; }
        public int idProdutoVariacaoDevLocacao { get; set; }
        public float valorProdutoDevLocacao { get; set; }
        public double qtdProdutoDevLocacao { get; set; }


    }
}
