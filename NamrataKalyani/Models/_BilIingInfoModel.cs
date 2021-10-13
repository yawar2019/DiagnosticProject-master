﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NamrataKalyani.Models
{
    public class _BilIingInfoModel
    {
        public int Id { get; set; }
        public string Investigation { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public decimal ReferalPercentage { get; set; }
    }
}