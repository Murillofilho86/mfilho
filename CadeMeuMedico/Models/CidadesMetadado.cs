﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadesMetadado)]
    public partial class Cidades
    {

    }

    public class CidadesMetadado
    {
        [Required(ErrorMessage="Obrigatório informar o nome")]
        [StringLength(100, ErrorMessage="O nome deve possuir no máximo 100 caracteres")]
        public string nome{get; set;}


    }
}