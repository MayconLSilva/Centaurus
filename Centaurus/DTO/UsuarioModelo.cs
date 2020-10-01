using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.DTO
{
    public class UsuarioModelo
    {
        public int idUsuario { get; set; }
        public string idNomeUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public bool ativoUsuario { get; set; }
        public bool botaoParticipanteUsuario { get; set; }
        public bool botaoGrupoProdutoUsuario { get; set; }
        public bool botaoProdutoUsuario { get; set; }
        public bool botaoMarcaUsuario { get; set; }
        public bool botaoCategoriaSubCategoriaUsuario { get; set; }
        public bool botaoUsuariosUsuario { get; set; }
    }
}
