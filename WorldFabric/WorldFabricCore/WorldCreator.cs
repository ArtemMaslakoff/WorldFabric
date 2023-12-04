using WorldFabricCore.Core;

namespace WorldFabricCore
{
    public static class WorldCreator 
    {
        public static World CreateWorld(WorldType worldType)
        {
            switch (worldType)
            {
                case WorldType.DISCRETE:
                {
                    return new DiscreteWorldCore.DiscreteWorld();
                }
                case WorldType.CONTINUOUS:
                {
                    return new ContinuousWorldCore.ContinuousWorld();
                }
            }
            throw new NotImplementedException();
        }
    }
    public enum WorldType
    {
        DISCRETE,
        CONTINUOUS
    }
}