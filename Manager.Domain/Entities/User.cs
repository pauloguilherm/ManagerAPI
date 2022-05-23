namespace Manager.Domain.Entities{

    public class User : Base{
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}