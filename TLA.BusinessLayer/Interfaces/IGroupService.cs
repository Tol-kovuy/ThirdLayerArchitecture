using System.Collections.Generic;


namespace TLA.BusinessLayer.Interfaces
{
    public interface IGroupService : IService<GroupDto>
    {
        IEnumerable<GroupDto> GetAllGroups();
    }
}
