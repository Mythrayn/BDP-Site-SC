﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackDragonPhotographyCore.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
    }
}
