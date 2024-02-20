namespace FileProtector.Models
{
    public class CryptoState
    {
        public bool Completed { get; set; }
        public long FilesCount { get; set; }
        public long TransformedFilesCount { get; set; }
        public string Message { get; set; } = "";
        public List<string> Errors { get; } = new List<string>();
    }
}
