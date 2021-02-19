using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Funcionario.Models
{

    public partial class Estado
    {

        public Estado()
        {
            //avoid NullReferenceException
            this.Funcionario = new List<Funcionario>();
        }

        [Key]
        public int PK_Estado { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }


    public partial class Funcionario
    {

        [Key]
        [Display(Name = "Código")]
        public int PK_Funcionario { get; set; }

        [Required(ErrorMessage = "Este campo não pode estar vazio")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Este campo não pode estar vazio")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo não pode estar vazio")]

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public System.DateTime DataNascimento { get; set; }


        [Display(Name = "Salário: R$")]
        public Nullable<decimal> Salario { get; set; }

        [Display(Name = "Estado (UF)")]
        public Nullable<int> FK_Estado { get; set; }
        
        [ForeignKey("FK_Estado")]
        public virtual Estado Estado { get; set; }

    }

}
