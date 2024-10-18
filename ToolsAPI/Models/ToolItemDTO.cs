namespace ToolsAPI.Models
{
    public class ToolItemDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Fastener { get; set; }
        public bool InToolbox { get; set; }
    }
}
