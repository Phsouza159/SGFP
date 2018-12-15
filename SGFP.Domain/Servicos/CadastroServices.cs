using SGFP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGFP.Domain.Servicos
{
    public class CadastroServices : BaseServices
    {
        public CadastroServices(IClienteRepository clienteDAO, IFuncionarioRepository funcionarioDAO, ICarroRepository carroDAO, IServicoRepository servicoDAO, IMaoDeObraRepository maoDeObraDAO, IEnderecoRepository enderecoDAO, IEmailRepository emailDAO, IOrcamentoRepository orcamentoDAO)
        {
            ClienteDAO = clienteDAO;
            FuncionarioDAO = funcionarioDAO;
            CarroDAO = carroDAO;
            ServicoDAO = servicoDAO;
            MaoDeObraDAO = maoDeObraDAO;
            EnderecoDAO = enderecoDAO;
            EmailDAO = emailDAO;
            OrcamentoDAO = orcamentoDAO;
        }

        public IClienteRepository ClienteDAO { get; private set; }

        public IFuncionarioRepository FuncionarioDAO { get; private set;}

        public ICarroRepository CarroDAO { get; private set; }

        public IServicoRepository ServicoDAO { get; private set; }

        public IMaoDeObraRepository MaoDeObraDAO { get; private set; }

        public IEnderecoRepository EnderecoDAO { get; private set; }

        public IEmailRepository EmailDAO { get; private set; }

        public IOrcamentoRepository OrcamentoDAO { get; set; }
    }
}
