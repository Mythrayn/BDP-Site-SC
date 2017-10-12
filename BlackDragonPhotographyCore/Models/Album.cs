using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackDragonPhotographyCore.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        public string AlbumDescription { get; set; }

        public int AlbumCoverImageID { get; set; }

        public DateTime AlbumCreateDt { get; set; }

        public int AlbumCreateUser { get; set; }

        public DateTime AlbumEditDt { get; set; }

        public int AlbumEditUser { get; set; }
    }
}
