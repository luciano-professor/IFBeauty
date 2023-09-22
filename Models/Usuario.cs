using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IFBeauty.Models;

public class Usuario
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "varchar(100)")]
  public string Nome { get; set; }

  [Required]
  [Column(TypeName = "varchar(100)")]
  public string Email { get; set; }

  [Required]
  [Column(TypeName = "varchar(40)")]
  public string Senha { get; set; }

  [Required]
  [Column(TypeName = "varchar(20)")]
  public string Telefone { get; set; }

  //Propriedade de Navegação
  public Endereco Endereco { get; set; }

  //Propriedade de Navegacao
  public List<Agendamento> Agendamentos { get; set; }

  //Propriedade de Navegação
  public List<Perfil> Perfis { get; set; }

}
