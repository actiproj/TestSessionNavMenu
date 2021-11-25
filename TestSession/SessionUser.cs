namespace TestSession
{    public class SessionUser
    {
        public Boolean Complete { get; set; } = false;
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
    }

    public class MenuInformation
    {
        public event Action OnChange;
        public void NotifyDataChanged() => OnChange?.Invoke();
    }
}
