namespace FileProtector.Models
{
    public class FormField
    {
        public TextBox Field { get; }
        public string Placeholder { get; }
        public bool IsPassword { get; } = false;

        public FormField(TextBox field, string placeholder)
        {
            Field = field;
            Placeholder = placeholder;
        }

        public FormField(TextBox field, string placeholder, bool isPassword)
        {
            Field = field;
            Placeholder = placeholder;
            IsPassword = isPassword;
        }
    }
}
