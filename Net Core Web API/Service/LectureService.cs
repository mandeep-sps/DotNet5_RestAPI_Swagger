using Net_Core_Web_API.Database;
using Net_Core_Web_API.Interface;
using Net_Core_Web_API.Models;
using Microsoft.EntityFrameworkCore;
using Net_Core_Web_API.StoreProcedures;
using Net_Core_Web_API.CustomSql;

namespace Net_Core_Web_API.Service
{
    public class LectureService : BaseStoredProc, ILectureService
    {
        private readonly OnlineTeachingContext _context;
        public LectureService
            (OnlineTeachingContext context, StoredProcedureClass spContext) 
            : base(spContext)
        {
            _context = context;
        }

        public async Task<List<LectureResponseVM>> GetLecturesAsync()
        {
            List<LectureResponseVM> mainList = new();
            var data = await _context.Lectures.AsNoTracking().ToListAsync();
            mainList=data.Select(x => new LectureResponseVM
                {
                Id = x.Id,
                LectureDesc=x.LectureDescription,
                BoardUrl=x.Boardurl,
                Credit=x.Credit,
                TeacherId=x.TeacherId,
                StudentId=x.StudentId
            }).OrderByDescending(x=>x.Id).ToList();

            return mainList;
        }

        public async Task<ICollection<CustomSPModel_Get_Result>> SpResultAsync()
        {
            var spData= await ExecuteStoredProcCollectionAsync<CustomSPModel_Get_Result>
               ("your stor proc name here...");
            return spData;  
        }
    }
}
