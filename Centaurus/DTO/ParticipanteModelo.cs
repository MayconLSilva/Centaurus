using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.Model
{
    public class ParticipanteModelo
    {

        public int idParticipante { get; set; }

        public string nomeParticipante { get; set; }

        public string razaosocialapelidoParticipante { get; set; }

        public string cpfcnpjParticipante { get; set; }

        public string rgieParticipante { get; set; }

        public string enderecoParticipante { get; set; }

        public string numeroEnderecoParticipante { get; set; }

        public string bairoParticipante { get; set; }

        public string ufParticipante { get; set; }

        public string cidadeParticipante { get; set; }

        public string cepParticipante { get; set; }

        public string telefoneParticipante { get; set; }

        public string celularParticipante { get; set; }

        public string emailParticipante { get; set; }
        public bool tipoclienteParticipante { get; set; }
        public bool tipofornecedorParticipante { get; set; }
        public bool tipofuncionarioParticipante { get; set; }
        public bool ativoParticipante { get; set; }
        public string dataCadastroParticipante { get; set; }
        public string dataAlteracaoParticipante { get; set; }
        public string usuarioCadastroParticipante { get; set; }
        public string usuarioAlteracaoParticipante { get; set; }
    }
}
