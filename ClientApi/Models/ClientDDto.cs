namespace ClientApi.Models
{
    public class ClientDDto
    {
        public string Email { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Phone { get; internal set; }
        public string? Address { get; internal set; }
        public string Status { get; internal set; }
    }
}