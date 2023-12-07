namespace WorldFabricCore.Core
{
    public abstract class World
    {

    }
    public class WorldSpace
    {
        private WorldLimitType limitType;
        public WorldSpace(WorldLimitType limitType)
        {
            this.limitType = limitType;
        }
        public WorldLimitType GetWorldLimitType()
        {
            return limitType;
        }
    }
}
