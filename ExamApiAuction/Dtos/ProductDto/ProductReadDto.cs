﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.ProductDto
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public float M_Price { get; set; }
        public int Id_Cate { get; set; }
        public string DesCription { get; set; }
        public string SorfDescription { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
