using System.ComponentModel.DataAnnotations;

namespace IFBeauty.Models;

public class DiaFuncionamento
{
  [Required]
  public int Id { get; set; }

  [Required]
  public DateTime Inicio { get; set; }

  [Required]
  public DateTime Fim { get; set; }

  //Propriedade de Navegacao
  public List<Agendamento> Agendamentos { get; set; }
}
