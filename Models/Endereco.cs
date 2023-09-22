using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IFBeauty.Models;

public class Endereco
{
  [Required]
  public int Id { get; set; }

  [Required]
  [Column(TypeName = "varchar(80)")]
  public string Rua { get; set; }

  [Required]
  [Column(TypeName = "varchar(10)")]
  public string Numero { get; set; }

  [Required]
  [Column(TypeName = "varchar(20)")]
  public string Bairro { get; set; }

  [Required]
  [Column(TypeName = "varchar(20)")]
  public string Cidade { get; set; }

  [Required]
  [Column(TypeName = "varchar(9)")]
  public string CEP { get; set; }

  //Propriedade de Navegação
  public Usuario Usuario { get; set; }

  //Chave estrangeira para tabela Usuario
  public int UsuarioId { get; set; }
}
