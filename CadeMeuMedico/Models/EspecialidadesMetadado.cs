using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(EspecialidadesMetadado))]
    public partial class Especialidades
    {

    }

    public class EspecialidadesMetadado
    {
        [Required(ErrorMessage="Obrigatório informa o nome")]
        [StringLength(100, ErrorMessage="O nome deve possuir no máximo 100 caracteres")]
        public string nome { get; set; }
    }
}