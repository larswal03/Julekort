namespace Julekortgenerator.Models
{
    public class ChristmasCard
    {
        public string BackGroundColor { get; set; } = "rgb(255, 40, 0)";
        public string BorderColor { get; set; } = "rgb(255, 40, 0)";
        public string TextColor1 { get; set; } = "rgb(255, 255, 255)";
        public string TextColor2 { get; set; } = "rgb(255, 255, 255)";
        public string TextColor3 { get; set; } = "rgb(255, 255, 255)";
        public string TextColor4 { get; set; } = "rgb(255, 255, 255)";
        public string Header { get; set; } = "God jul!";
        public string Greeting { get; set; } = "";
        public string ReceiverName { get; set; } = "";
        public string SenderName { get; set; } = "";
        
        public string[] Images { get; set; } = new string[] { "", "", "" };
        
        public string MyFont { get; set; } = "'Courier New', monospace";
    }
}
