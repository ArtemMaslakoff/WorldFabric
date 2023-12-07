using WorldFabricCore.Core;
using WorldFabricCore.Core.ParameterCore;

namespace WorldFabricCore
{
    public static class WorldCreator 
    {
        public static World CreateWorld(WorldNumericType worldType)
        {
            switch (worldType)
            {
                case WorldNumericType.DISCRETE:
                {
                    Parameter mass = new Parameter("Mass");
                    return new DiscreteWorldCore.DiscreteWorld();
                }
                case WorldNumericType.CONTINUOUS:
                {
                    Parameter mass = new Parameter("Mass");
                    return new ContinuousWorldCore.ContinuousWorld();
                }
            }
            throw new NotImplementedException();
        }
    }
    public enum WorldNumericType
    {
        DISCRETE,
        CONTINUOUS
    }
    public enum WorldLimitType
    {
        AXES_LIMITED,
        AXES_UNLIMITED,
        FORM_LIMITED
    }
}