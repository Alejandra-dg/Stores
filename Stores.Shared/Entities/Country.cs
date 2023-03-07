using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        //Serie de restricciones para el nombre:
            //1) Campo predeterminado
            [Display(Name = "Pais")]


            //2) Restringir que el país solo permita un número de caracteres
            // (tamaño máximo, error)
            [MaxLength(20, ErrorMessage = "El país {0} debe contener máximo de {1} caracteres")]


            //3) Requerido o campo obligatorio
            [Required(ErrorMessage ="El pais {0} es obligatorio")]
        
        public string Name { get; set; } = null;

        

    }
}
