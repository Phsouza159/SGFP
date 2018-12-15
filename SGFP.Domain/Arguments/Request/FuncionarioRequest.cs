using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Arguments.Request
{
    public class FuncionarioRequest : PessoaRequest
    {
        public int Categoria { get;  set; }
    }
}
