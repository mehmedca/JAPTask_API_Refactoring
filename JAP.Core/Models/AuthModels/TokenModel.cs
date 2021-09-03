using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.AuthModels
{
    public class TokenModel
    {
        public string Token { get; set; }
        public DateTime ValidTo { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
    }
}
