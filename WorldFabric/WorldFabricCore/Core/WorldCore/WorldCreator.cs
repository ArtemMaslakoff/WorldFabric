using WorldFabricCore.Core;
using WorldFabricCore.Core.ParameterCore;
using static WorldFabricCore.Core.WorldCore.World;

namespace WorldFabricCore.Core.WorldCore
{
    public static class WorldCreator
    {
        public static World CreateWorld(WorldNumericType worldType)
        {
            new Parameter("Mass");
            switch (worldType)
            {
                case WorldNumericType.DISCRETE:
                    {
                        return new World(WorldNumericType.DISCRETE);
                    }
                case WorldNumericType.CONTINUOUS:
                    {
                        return new World(WorldNumericType.CONTINUOUS);
                    }
            }
            throw new NotImplementedException();
        }
    }
}