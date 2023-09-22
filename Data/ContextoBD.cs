using IFBeauty.Models;
using Microsoft.EntityFrameworkCore;

namespace IFBeauty.Data;

public class ContextoBD : DbContext
{
  public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
  {

  }

  //Tabelas
  public DbSet<Procedimento> Procedimentos { get; set; }

  public DbSet<Agendamento> Agendamentos { get; set; }

  public DbSet<DiaFuncionamento> DiasFuncionamento { get; set; }

  public DbSet<Usuario> Usuarios { get; set; }

  public DbSet<Endereco> Enderecos { get; set; }

  public DbSet<Perfil> Perfis { get; set; }

}
