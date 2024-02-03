using FileProtector.Exceptions;

namespace FileProtector.Utils
{
    public static class CheckUtils
    {
        private const int MIN_PASSWORD_LENGTH = 6;

        public static void CheckPasswords(string password, string passwordConfirmation)
        {
            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                throw new ArgumentException(
                    string.Format("Password must be at least {0} characters long",
                    MIN_PASSWORD_LENGTH));
            }

            if (password != passwordConfirmation)
            {
                throw new ArgumentException("Passwords not match");
            }
        }

        public static void CheckSelectedPaths(List<string> paths)
        {
            if (paths.Count == 0)
            {
                throw new InvalidOperationException("Please select file(s) or folder");
            }

            paths.ForEach(path =>
            {
                if (!File.Exists(path) || !Directory.Exists(path))
                {
                    throw new PathNotFoundException(string.Format("Cannot find: '{0}'", path));
                }
            });
        }
    }
}
