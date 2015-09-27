using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuariosMetadado))]
    public partial class Usuarios
    {

    }



    public class UsuariosMetadado
    {

        [Required(ErrorMessage="Obrigatório informar o nome")]
        [StringLength(80, ErrorMessage="O nome deve possuir no máximo 80 caracteres")]
        public string nome { get; set;}

        [Required(ErrorMessage="Obrigatório informar o login")]
        [StringLength(30, ErrorMessage="O login deve possuir no máximo 30 caracteres")]
        public string login{get; set; }

        [Required(ErrorMessage="Obrigatório informar a senha")]
        [StringLength(100, ErrorMessage="A senha deve possuir no máximo 100 caracteres")]
        public string senha { get; set; }

        [Required(ErrorMessage="Obrigatório informa o email")]
        [StringLength(100, ErrorMessage="O email deve possuir no máximo 100 caracteres")]
        public string email { get; set; }


    }
}