using SistemaDeTarefas.Enums;

namespace SistemaDeTarefas.Models
{
    public class TarefasModel
    {
        public int Tarefas_ID { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
    }
}
