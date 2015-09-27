using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }

    public class MedicoMetadado
    {
        [Required(ErrorMessage= "Obrigatório informar o CRM")]
        [StringLength(30, ErrorMessage="O CRM deve possuir no máximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage="Obrigatório informar o Nome")]
        [StringLength(80, ErrorMessage="O Nome deve possuir no máximo 80 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage="Obrigatório informar o endereço")]
        [StringLength(100, ErrorMessage="O endereço deve possuir no máximo 100 caracteres")]
        public string endereco { get; set; }

        [Required(ErrorMessage="Obrigatorio informar o bairro")]
        [StringLength(60, ErrorMessage="O bairro deve possuir no máximo 60 caracteres")]
        public string bairro { get; set; }

        [Required(ErrorMessage="Obrigatório informar o email")]
        [StringLength(100, ErrorMessage="O email deve possuir no máximo 100 caracteres")]
        public string email { get; set; }

        [Required(ErrorMessage="Obrigatório informar se atende por convenio")]
        public bool atendePorConvenio { get; set; }

        [Required(ErrorMessage="Obrigatório informar se tem clinica")]
        public bool TemClinica { get; set; }

        [StringLength(80, ErrorMessage="O website deve possuir no máximo 80 caracteres")]
        public string webSiteBlog { get; set; }

        [Required(ErrorMessage="Obrigatório informar a cidade")]
        public int cidadeID { get; set; }

        [Required(ErrorMessage="Obrigatório informar a especialidade")]
        public int especialidadeID { get; set; }
    }
}