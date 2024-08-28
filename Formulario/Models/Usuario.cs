using System.ComponentModel.DataAnnotations;

namespace Formulario.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string nomeUsuario { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime nascimentoUsuario { get; set; }

        [Required]
        [Display(Name = "Contato")]
        [RegularExpression(@"\(?\d{2}\)?\s?\d{4,5}-?\d{4}", ErrorMessage = "O telefone deve estar no formato (xx) xxxx-xxxx ou (xx) xxxxx-xxxx.")]
        public string contatoUsuario { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O email inserido não é válido.")]
        public string emailUsuario { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [Display(Name = "CEP")]
        public string cepUsuario { get; set; }

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [Display(Name = "Endereço")]
        public string enderecoUsuario { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        [Display(Name = "Número")]
        public int numeroUsuario { get; set; }

        [Display(Name = "Complemento")]
        public string complementoUsuario { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [Display(Name = "Bairro")]
        public string bairroUsuario { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [Display(Name = "Cidade")]
        public string cidadeUsuario { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório.")]
        [Display(Name = "UF")]
        public string ufUsuario { get; set; }

        public List<string> UFs { get; } = new List<string>
        {
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        };
    }
}
