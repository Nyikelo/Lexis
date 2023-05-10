using LexisDeedTrackerDataAccess.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LexisDeedTrackerDataAccess.Database
{
    public interface ITitleDeedDataAccess
    {
        Task<TitleDeed> GetTitleDeed(int? id);
        Task<IEnumerable<TitleDeed>> GetTitleDeeds();
    }
}