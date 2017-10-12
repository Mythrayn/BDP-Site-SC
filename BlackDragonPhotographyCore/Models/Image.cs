using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlackDragonPhotographyCore.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageDescription { get; set; }

        public string Keywords { get; set; }

        public DateTime ImageCreateDt { get; set; }

        public int ImageCreateUser { get; set; }

        public DateTime ImageEditDt { get; set; }

        public int ImageEditUser { get; set; }

        public string ImageData { get; set; }

        public int VisitCount { get; set; }

        public string ImageSize { get; set; }

        public string OriginalFileName { get; set; }

        public string FileSize { get; set; }

        public string FileType { get; set; }

        public string FilePath { get; set; }

        public int RoleID { get; set; }
    }
}
