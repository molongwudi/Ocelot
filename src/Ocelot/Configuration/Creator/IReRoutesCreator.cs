using System.Collections.Generic;
using Ocelot.Configuration.File;

namespace Ocelot.Configuration.Creator
{
    public interface IReRoutesCreator
    {
        List<ReRoute> Create(FileConfiguration fileConfiguration);
    }
}
