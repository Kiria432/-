namespace SupportChainPattern.Models
{
    public class SupportRequest
    {
        public string ProblemType { get; set; }
        public string Description { get; set; }
        public string EquipmentModel { get; set; }
        public string OperatingSystem { get; set; }
        public bool IsSolved { get; set; }

        public SupportRequest(string problemType, string description, string equipmentModel, string operatingSystem)
        {
            ProblemType = problemType;
            Description = description;
            EquipmentModel = equipmentModel;
            OperatingSystem = operatingSystem;
            IsSolved = false;
        }
    }
}
