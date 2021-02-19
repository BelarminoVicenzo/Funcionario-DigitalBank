using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

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
        public int PK_Funcionario { get; set; }
        
        [Required]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime DataNascimento { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public Nullable<int> FK_Estado { get; set; }

        public virtual Estado Estado { get; set; }
    }

}
