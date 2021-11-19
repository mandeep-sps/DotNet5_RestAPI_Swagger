using Net_Core_Web_API.Models;
using System.Collections.Generic;

namespace Net_Core_Web_API.Interface
{
    public interface ILectureService
    {
        public Task<List<LectureResponseVM>> GetLecturesAsync();

        public Task<ICollection<CustomSPModel_Get_Result>> SpResultAsync();
    }
}
