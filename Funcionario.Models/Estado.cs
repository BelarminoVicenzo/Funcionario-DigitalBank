using System.Collections.Generic;
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

}
