namespace Backend.Models
{
    public class ExternalAuthDto
    {
        public string Provider { get; set; }
        public string IdToken { get; set; }
        public string AuthToken { get; set; }
    }
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
        public bool Is2StepVerificationRequired { get; set; }
        public string Provider { get; set; }
    }
    public class CompanyInformation
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
    }
    public class MailSettings
    {
        public string EmailFrom { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
    }
}