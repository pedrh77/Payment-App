namespace Payment_DOMAIN.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime Disabled_In { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
