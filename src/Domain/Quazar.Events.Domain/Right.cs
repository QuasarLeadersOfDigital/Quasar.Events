namespace Quazar.Events.Domain
{
    public class Right
    {
        public bool GuestAccess;

        public bool VipAccess;

        public bool ModeratorAccess;

        public bool SpeechAccess;

        public Right(bool guestAccess, bool vipAccess, bool moderatorAccess, bool speechAccess)
        {
            GuestAccess = guestAccess;
            VipAccess = vipAccess;
            ModeratorAccess = moderatorAccess;
            SpeechAccess = speechAccess;
        }
    }
}