using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebCRUDMVC.Models
{
    [Table("Advogados")]
    public class Pessoa
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
        [Column("Data de Criação")]
        [Display(Name = "Data de Cadastro")]
        public DateTime CreatedDate { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("Número da OAB")]
        [Display(Name = "Número da OAB")]
        public string OAB { get; set; }

    }
}
