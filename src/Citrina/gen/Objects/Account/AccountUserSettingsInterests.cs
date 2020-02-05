using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class AccountUserSettingsInterests
    {
        public AccountUserSettingsInterest Activities { get; set; } 

        public AccountUserSettingsInterest Interests { get; set; } 

        public AccountUserSettingsInterest Music { get; set; } 

        public AccountUserSettingsInterest Tv { get; set; } 

        public AccountUserSettingsInterest Movies { get; set; } 

        public AccountUserSettingsInterest Books { get; set; } 

        public AccountUserSettingsInterest Games { get; set; } 

        public AccountUserSettingsInterest Quotes { get; set; } 

        public AccountUserSettingsInterest About { get; set; } 
    }
}
