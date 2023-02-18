namespace Modelo_PixSafra.Models.Security
{
    public class Authorization
    {
        public string Auth { get; private set; }
        public Authorization() { }
        public Authorization(string auth)
        {
            Auth = auth;
        }
    }
}
