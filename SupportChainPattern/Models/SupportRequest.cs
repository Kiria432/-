namespace SupportChainPattern.Models
{
    public class SupportRequest
    {
        public string Description { get; set; }
        public bool IsSolved { get; set; }
        public SupportRequest(string description)
        {
            Description = description;
            IsSolved = false;
        }
    }
}
