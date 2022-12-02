using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reticula.Modelo {
    public class Materia {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MateriaID { get; set; }

        public String Nombre { get; set; }

        public int Creditos { get; set; }

        public String Horas { get; set; }

    }
}
