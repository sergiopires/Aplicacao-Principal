using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino.Aluno.DomainModel
{
    public class EnderecoMOD
    {
        public int Cod_Endereco { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}
