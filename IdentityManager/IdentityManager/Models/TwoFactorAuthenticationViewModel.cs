namespace IdentityManager.Models
{
    public class TwoFactorAuthenticationViewModel
    {
        // Used to login
        public string Code { get; set; }

        // Used to Register/Signup
        public string Token { get; set; }
        public string QRCodeUrl { get; set; }
    }
}
