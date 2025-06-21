namespace Atividade_Almir_Api.Model
{
    public class EncomendaMotoDTO
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int ClienteId { get; set; }
    }
}
