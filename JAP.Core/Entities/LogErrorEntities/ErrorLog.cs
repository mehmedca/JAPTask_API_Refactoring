using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Entities.LogErrorEntities
{
    public class ErrorLog
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(150)]
        public string ExceptionMessage { get; set; }

        [MaxLength(150)]
        public string ExceptionType { get; set; }
        public int? ExceptionCode { get; set; }

        public string ExceptionSource { get; set; }
        public string ExceptionTrace { get; set; }

        public DateTime LogDate { get; set; }
        
        public string UserId { get; set; }
    }
}
