using System.Runtime.CompilerServices;

namespace Project_Helpdesk_Portal.Entities
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }

        public bool IsMobile { get; set; }

        public bool IsArchive { get; set; }
    }
}
