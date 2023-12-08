namespace CrudFeelps.InputModels
{
    public class InputVaga
    {
        public string? empresa { get; set; } = null;
        public string? email { get; set; } = null;
        public string? cnpj { get; set; } = null;
        public string? foneSolicitante { get; set; } = null;
        public string? nomeSolicitante { get; set; } = null;
        public string? modeloContratacao { get; set; } = null;
        public string? tipoContratacao { get; set; } = null;
        public string? localContratacao { get; set; } = null;
        public string? horarioTrabalho { get; set; } = null;
        public string? cargo { get; set; } = null;
        public string? prioridadeContratacao { get; set; } = null;
        public string? senioridade { get; set; } = null;
        public string? regimeTrabalho { get; set; } = null;
        public decimal? budgetMaximo { get; set; } = null;
        public string? DescricaoBeneficios { get; set; } = null;
        public string? Responsabilidades { get; set; } = null;
        public string? RequisitosTecnicos { get; set; } = null;
        public string? RequisitosComportamentais { get; set; } = null;

        public bool ValidaCampo(object item)
        {
            if (item == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }


}
