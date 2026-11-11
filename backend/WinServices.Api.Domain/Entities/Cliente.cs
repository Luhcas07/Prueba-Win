namespace WinServices.Api.Domain.Entities
{
    public sealed class Cliente : BaseEntity
    {
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string Segmento { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
    }
}
