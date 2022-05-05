using System.Collections.Generic;
using Newtonsoft.Json;
namespace Apex.Legends.API
{
    public class BridgeResponse : ErrorBase
    {
        [JsonProperty("global")]
        public Global Global { get; set; }

        [JsonProperty("realtime")]
        public Realtime Realtime { get; set; }

        [JsonProperty("legends")]
        public Legends Legends { get; set; }

        [JsonProperty("mozambiquehere_internal")]
        public MozambiquehereInternal MozambiquehereInternal { get; set; }

        [JsonProperty("ALS")]
        public Als Als { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }
    }

    public class Als
    {
        [JsonProperty("isALSDataEnabled")]
        public bool IsAlsDataEnabled { get; set; }
    }

    public class Global
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("toNextLevelPercent")]
        public int ToNextLevelPercent { get; set; }

        [JsonProperty("internalUpdateCount")]
        public long InternalUpdateCount { get; set; }

        [JsonProperty("bans")]
        public Bans Bans { get; set; }

        [JsonProperty("rank")]
        public Arena Rank { get; set; }

        [JsonProperty("arena")]
        public Arena Arena { get; set; }

        [JsonProperty("battlepass")]
        public Battlepass Battlepass { get; set; }

        [JsonProperty("badges")]
        public Damage[] Badges { get; set; }
    }
    public class Arena
    {
        [JsonProperty("rankScore")]
        public long RankScore { get; set; }

        [JsonProperty("rankName")]
        public string RankName { get; set; }

        [JsonProperty("rankDiv")]
        public int RankDiv { get; set; }

        [JsonProperty("ladderPosPlatform")]
        public int LadderPosPlatform { get; set; }

        [JsonProperty("rankImg")]
        public string RankImg { get; set; }

        [JsonProperty("rankedSeason")]
        public string RankedSeason { get; set; }
    }

    public class Damage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class Bans
    {
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("remainingSeconds")]
        public int RemainingSeconds { get; set; }

        [JsonProperty("last_banReason")]
        public string LastBanReason { get; set; }
    }
    public class Battlepass
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("history")]
        public Dictionary<string, long> History { get; set; }
    }

    public class Legends
    {
        [JsonProperty("selected")]
        public Selected Selected { get; set; }

        [JsonProperty("all")]
        public All All { get; set; }
    }

    public class All
    {
        [JsonProperty("Global")]
        public Ash Global { get; set; }

        [JsonProperty("Revenant")]
        public Ash Revenant { get; set; }

        [JsonProperty("Crypto")]
        public Ash Crypto { get; set; }

        [JsonProperty("Horizon")]
        public Ash Horizon { get; set; }

        [JsonProperty("Gibraltar")]
        public Ash Gibraltar { get; set; }

        [JsonProperty("Wattson")]
        public Ash Wattson { get; set; }

        [JsonProperty("Fuse")]
        public Ash Fuse { get; set; }

        [JsonProperty("Bangalore")]
        public Ash Bangalore { get; set; }

        [JsonProperty("Wraith")]
        public Ash Wraith { get; set; }

        [JsonProperty("Octane")]
        public Ash Octane { get; set; }

        [JsonProperty("Bloodhound")]
        public Bloodhound Bloodhound { get; set; }

        [JsonProperty("Caustic")]
        public Ash Caustic { get; set; }

        [JsonProperty("Lifeline")]
        public Ash Lifeline { get; set; }

        [JsonProperty("Pathfinder")]
        public Ash Pathfinder { get; set; }

        [JsonProperty("Loba")]
        public Ash Loba { get; set; }

        [JsonProperty("Mirage")]
        public Ash Mirage { get; set; }

        [JsonProperty("Rampart")]
        public Ash Rampart { get; set; }

        [JsonProperty("Valkyrie")]
        public Ash Valkyrie { get; set; }

        [JsonProperty("Seer")]
        public Ash Seer { get; set; }

        [JsonProperty("Ash")]
        public Ash Ash { get; set; }

        [JsonProperty("Mad Maggie")]
        public Ash MadMaggie { get; set; }
    }

    public class Ash
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }
    public class ImgAssets
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }
    }

    public class Bloodhound
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Datum
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("rank")]
        public Rank Rank { get; set; }

        [JsonProperty("rankPlatformSpecific")]
        public RankPlatformSpecific RankPlatformSpecific { get; set; }
    }

    public class Rank
    {
        [JsonProperty("rankPos")]
        public int RankPos { get; set; }

        [JsonProperty("topPercent")]
        public float TopPercent { get; set; }
    }

    public class RankPlatformSpecific
    {
        [JsonProperty("rankPos")]
        public string RankPos { get; set; }

        [JsonProperty("topPercent")]
        public string TopPercent { get; set; }
    }

    public class Selected
    {
        [JsonProperty("LegendName")]
        public string LegendName { get; set; }

        [JsonProperty("data")]
        public object[] Data { get; set; }

        [JsonProperty("gameInfo")]
        public GameInfo GameInfo { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class GameInfo
    {
        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("skinRarity")]
        public string SkinRarity { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("frameRarity")]
        public string FrameRarity { get; set; }

        [JsonProperty("pose")]
        public string Pose { get; set; }

        [JsonProperty("poseRarity")]
        public string PoseRarity { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("introRarity")]
        public string IntroRarity { get; set; }

        [JsonProperty("badges")]
        public Badge[] Badges { get; set; }
    }

    public class Badge
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class MozambiquehereInternal
    {
        [JsonProperty("isNewToDB")]
        public bool IsNewToDb { get; set; }

        [JsonProperty("claimedBy")]
        public string ClaimedBy { get; set; }

        [JsonProperty("APIAccessType")]
        public string ApiAccessType { get; set; }

        [JsonProperty("ClusterID")]
        public string ClusterId { get; set; }

        [JsonProperty("rate_limit")]
        public RateLimit RateLimit { get; set; }

        [JsonProperty("clusterSrv")]
        public string ClusterSrv { get; set; }
    }

    public class RateLimit
    {
        [JsonProperty("max_per_second")]
        public int MaxPerSecond { get; set; }

        [JsonProperty("current_req")]
        public object CurrentReq { get; set; }
    }

    public class Realtime
    {
        [JsonProperty("lobbyState")]
        public string LobbyState { get; set; }

        [JsonProperty("isOnline")]
        public int IsOnline { get; set; }

        [JsonProperty("isInGame")]
        public int IsInGame { get; set; }

        [JsonProperty("canJoin")]
        public int CanJoin { get; set; }

        [JsonProperty("partyFull")]
        public int PartyFull { get; set; }

        [JsonProperty("selectedLegend")]
        public string SelectedLegend { get; set; }

        [JsonProperty("currentState")]
        public string CurrentState { get; set; }

        [JsonProperty("currentStateSinceTimestamp")]
        public int CurrentStateSinceTimestamp { get; set; }

        [JsonProperty("currentStateAsText")]
        public string CurrentStateAsText { get; set; }
    }

    public class Total
    {
        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("enemies_scanned")]
        public Damage EnemiesScanned { get; set; }

        [JsonProperty("specialEvent_kills")]
        public Damage SpecialEventKills { get; set; }

        [JsonProperty("kd")]
        public Kd Kd { get; set; }
    }

    public class Kd
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }


}
