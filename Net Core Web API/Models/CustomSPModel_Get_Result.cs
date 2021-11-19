using Microsoft.EntityFrameworkCore;

namespace Net_Core_Web_API.Models
{
    [Keyless]
    public class CustomSPModel_Get_Result
    {
        
        public int ID { get; set; }

        public string? Name { get; set; }   
    }
}
