using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Legends.API
{
    public class ServersResponse : ErrorBase
    {
        public static string Tips = "Data from apexlegendsstatus.com";

        [JsonProperty("Origin_login")]
        public ApexOauthCrossplay OriginLogin { get; set; }

        [JsonProperty("EA_novafusion")]
        public ApexOauthCrossplay EaNovafusion { get; set; }

        [JsonProperty("EA_accounts")]
        public ApexOauthCrossplay EaAccounts { get; set; }

        [JsonProperty("ApexOauth_Crossplay")]
        public ApexOauthCrossplay ApexOauthCrossplay { get; set; }

        [JsonProperty("selfCoreTest")]
        public SelfCoreTest SelfCoreTest { get; set; }

        [JsonProperty("otherPlatforms")]
        public OtherPlatforms OtherPlatforms { get; set; }

    }

    public class ApexOauthCrossplay
    {
        [JsonProperty("EU-West")]
        public Asia EuWest { get; set; }

        [JsonProperty("EU-East")]
        public Asia EuEast { get; set; }

        [JsonProperty("US-West")]
        public Asia UsWest { get; set; }

        [JsonProperty("US-Central")]
        public Asia UsCentral { get; set; }

        [JsonProperty("US-East")]
        public Asia UsEast { get; set; }

        [JsonProperty("SouthAmerica")]
        public Asia SouthAmerica { get; set; }

        [JsonProperty("Asia")]
        public Asia Asia { get; set; }
    }

    public class Asia
    {
        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("HTTPCode")]
        public int HttpCode { get; set; }

        [JsonProperty("ResponseTime")]
        public int ResponseTime { get; set; }

        [JsonProperty("QueryTimestamp")]
        public int QueryTimestamp { get; set; }
    }

    public class OtherPlatforms
    {
        [JsonProperty("Playstation-Network")]
        public PlaystationNetwork PlaystationNetwork { get; set; }

        [JsonProperty("Xbox-Live")]
        public PlaystationNetwork XboxLive { get; set; }
    }

    public class PlaystationNetwork
    {
        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("QueryTimestamp")]
        public int QueryTimestamp { get; set; }
    }

    public class SelfCoreTest
    {
        [JsonProperty("Status-website")]
        public Asia StatusWebsite { get; set; }

        [JsonProperty("Stats-API")]
        public Asia StatsApi { get; set; }

        [JsonProperty("Overflow-#1")]
        public Asia Overflow1 { get; set; }

        [JsonProperty("Overflow-#2")]
        public Asia Overflow2 { get; set; }

        [JsonProperty("Origin-API")]
        public Asia OriginApi { get; set; }

        [JsonProperty("Playstation-API")]
        public Asia PlaystationApi { get; set; }

        [JsonProperty("Xbox-API")]
        public Asia XboxApi { get; set; }
    }

    public enum Status { Slow, Up };

}
