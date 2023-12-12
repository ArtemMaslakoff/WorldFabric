namespace WorldFabricCore.Core.WorldCore
{
    public class World
    {
        private WorldNumericType worldNumericType;
        private WorldSpace worldSpace;
        private List<object> objects;
        /// <summary>
        /// Создает стандартный мир
        /// </summary>
        public World()
        {
            worldNumericType = WorldNumericType.CONTINUOUS;
            worldSpace = new WorldSpace();
            objects = new List<object>();
        }
        public World(WorldSpace worldSpace)
        {
            worldNumericType = WorldNumericType.CONTINUOUS;
            this.worldSpace = new WorldSpace(worldSpace);
            objects = new List<object>();
        }
        public World(WorldNumericType worldNumericType)
        {
            this.worldNumericType = worldNumericType;
            worldSpace = new WorldSpace();
            objects = new List<object>();
        }
        public World(WorldNumericType worldNumericType, WorldSpace worldSpace)
        {
            this.worldNumericType = worldNumericType;
            this.worldSpace = new WorldSpace(worldSpace);
            objects = new List<object>();
        }
        public void AddObject(Object obj)
        {
            if (!objects.Contains(obj))
            {
                objects.Add(obj);
            }
        }
        public List<Object> GetObjects()
        {
            return objects;
        }
        public enum WorldNumericType
        {
            DISCRETE,
            CONTINUOUS
        }
    }
    public class WorldSpace
    {
        private WorldLimitType limitType;
        public WorldSpace()
        {
            limitType = WorldLimitType.AXES_UNLIMITED;
        }
        public WorldSpace(WorldSpace worldSpace)
        {
            limitType = worldSpace.limitType;
        }
        public WorldSpace(WorldLimitType limitType)
        {
            this.limitType = limitType;
        }
        public WorldLimitType GetWorldLimitType()
        {
            return limitType;
        }
        public enum WorldLimitType
        {
            AXES_LIMITED,
            AXES_UNLIMITED,
            FORM_LIMITED
        }
    }
}
