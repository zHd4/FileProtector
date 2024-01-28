namespace FileProtector.Models
{
    public class PasswordsCheckStatus
    {
        public bool Success { get; }
        public string Message { get; }

        public PasswordsCheckStatus(bool status, string message) 
        {
            Success = status;
            Message = message;
        }
    }
}
