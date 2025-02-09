namespace Payment_DOMAIN.Models
{
    public class User : Entity
    {
        public string FullName { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
