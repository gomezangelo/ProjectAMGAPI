using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamente = 2,
        [Description("Concluída")]
        Concluida = 3
    }
}
