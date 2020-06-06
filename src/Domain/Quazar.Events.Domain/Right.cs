namespace Quazar.Events.Domain
{
    public class Right
    {
        public bool GuestAccess { get; }

        public bool VipAccess { get; }

        public bool ModeratorAccess { get; }

        public bool SpeechAccess { get; }

        public Right(bool guestAccess, bool vipAccess, bool moderatorAccess, bool speechAccess)
        {
            GuestAccess = guestAccess;
            VipAccess = vipAccess;
            ModeratorAccess = moderatorAccess;
            SpeechAccess = speechAccess;
        }
    }
}