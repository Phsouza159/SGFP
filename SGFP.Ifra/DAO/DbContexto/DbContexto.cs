using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using SGFP.Domain.Entidades;
using SGFP.Domain.Entidades.Base;
using SGFP.Infra.DAO.Map;

namespace SGFP.Infra.DAO.DbContexto
{
    public class DbContexto : DbContext
    {
        public DbContexto()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var config = new ConfigurationBuilder()
            //        .SetBasePath(Directory.GetCurrentDirectory())
            //        .AddJsonFile("appsettings.json")
            //        .Build();

            //optionsBuilder.UseSqlServer("Data Source=ATLAS;Initial Catalog=SGFP;User ID=SystemSGFP;Password=3l3f@nt3");
            optionsBuilder.UseSqlServer("Data Source=sql7002.site4now.net;Persist Security Info=True;User ID=DB_A43D0F_pauloh159_admin;Password=soufoda123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().Ignore( e => e.Notifications);
            modelBuilder.Entity<Pessoa>().HasKey(e => e.Id).HasName("ID");

            modelBuilder.ApplyConfiguration(new AvaliacaoMap());

            modelBuilder.ApplyConfiguration(new CarroMap());

            modelBuilder.ApplyConfiguration(new CidadeMap());

            //modelBuilder.ApplyConfiguration(new PessoaMap());

            modelBuilder.ApplyConfiguration(new ClienteMap());

            modelBuilder.ApplyConfiguration(new DocumentoMap());

            modelBuilder.ApplyConfiguration(new EmailMap());

            modelBuilder.ApplyConfiguration(new EnderecoMap());

            modelBuilder.ApplyConfiguration(new EstadoMap());

            modelBuilder.ApplyConfiguration(new FuncionarioMap());

            modelBuilder.ApplyConfiguration(new MaoDeObraMap());

            modelBuilder.ApplyConfiguration(new OrcamentoMap());

            modelBuilder.ApplyConfiguration(new PaisMap());

            modelBuilder.ApplyConfiguration(new ServicoMap());

            modelBuilder.ApplyConfiguration(new TelefoneMap());
        }

        public DbSet<Avaliacao> Avalicao { get; set; }

        public DbSet<Carro> Carro { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        //public DbSet<Pessoa> Pessoa { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Documento> Documento { get; set; }

        public DbSet<Email> Email { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }

        public DbSet<MaoDeObra> MaoDeObra { get; set; }

        public DbSet<Orcamento> Orcamento { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<Servico> Servico { get; set; }

        public DbSet<Telefone> Telefone { get; set; }
    }
}

