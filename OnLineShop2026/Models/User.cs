namespace OnLineShop2026.Models
{
    public class User
    {
        private const string DefaultAvatar = "/images/default_avatar.jpg";
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AvatarPath { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            AvatarPath = DefaultAvatar;
        }

        public User(string firstName, string lastName, string email, string? avatarPath = null)
        {
            Id = Guid.NewGuid();
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            Email = email ?? string.Empty;
            AvatarPath = string.IsNullOrEmpty(avatarPath) ? DefaultAvatar : avatarPath!;
        }

        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"Пользователь: {FullName}, Email: {Email}";
        }
    }
}