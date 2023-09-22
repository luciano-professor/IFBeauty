using System.ComponentModel.DataAnnotations;

namespace IFBeauty.Models;

public class Agendamento
{
  [Required]
  public int Id { get; set; }

  [Required]
  public DateTime Horario { get; set; }

  public bool? Confirmado { get; set; }

  //Propriedade de Navegação
  public Procedimento Procedimento { get; set; }

  //Chave estrangeira para Procedimento
  public int ProcedimentoId { get; set; }

  //Propriedade de Navegacao
  public Usuario Cliente { get; set; }

  //Chave estrangeira
  public int ClienteId { get; set; }

  //Propriedade de Navegacao
  public DiaFuncionamento DiaFuncionamento { get; set; }

  //Chave Estrangeira
  public int DiaFuncionamentoId { get; set; }
}
