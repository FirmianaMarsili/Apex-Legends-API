

namespace Apex.Legends.API
{
    public class Name2UID : ResponseBase<Name2UIDResponse>
    {
        public string Method => "nametouid";

        public string Player { get; set; }

        public Platform Platform { get; set; }
    }
}
