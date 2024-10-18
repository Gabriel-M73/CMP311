namespace ToolsAPI.Models
{
    public class ToolItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Fastener { get; set; }
        public bool InToolbox { get; set; }
        public string? Secret { get; set; }
    }
}
