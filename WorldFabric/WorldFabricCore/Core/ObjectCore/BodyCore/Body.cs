using WorldFabricCore.Core.MathCore;

namespace WorldFabricCore.Core.ObjectCore.BodyCore
{
    public class Body : Object
    {
        public Body() : base() { }
        public Body(string name) : base(name) { }
        public Body(string name, Transform transform) : base(name, transform) { }
        public Body(string name, Transform transform, Tag tag) : base(name, transform, tag) { }
    }
}
