namespace FileProtector.Models
{
    public class CryptoState
    {
        public bool Completed { get; set; }
        public int FilesCount { get; set; }
        public int TransformedFilesCount { get; set; }
        public string Message { get; set; } = "";
        public List<string> Errors { get; } = new List<string>();
    }
}
