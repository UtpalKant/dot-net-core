using Newtonsoft.Json;
using System;

namespace ECart.Application.Core.Models.DTO
{
    public class Token
    {
        [JsonProperty("authorisation")]
        public Guid Authorisation { get; set; }
        [JsonProperty("issued")]
        public DateTime Issued { get; set; }
        [JsonProperty("username")]
        public string UserName { get; set; }

        public Token(string authorisation, string username)
        {
            this.Authorisation = GetAuthorisation(authorisation);
            this.Issued = DateTime.UtcNow;
            this.UserName = username;
        }

        private Guid GetAuthorisation(string authorisation)
        {
            return string.IsNullOrEmpty(authorisation) ? new Guid("0D703D17-FD87-44A2-9CFD-5FF5CE40925D") : new Guid(authorisation);
        }
    }
}
