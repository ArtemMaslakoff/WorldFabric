using WorldFabricCore.Core.TransformCore;

namespace WorldFabricCore.Core.ObjectCore.FieldCore
{
    public class Field : Object
    {
        public Field() : base() { }
        public Field(string name) : base(name) { }
        public Field(string name, Transform transform) : base(name, transform) { }
        public Field(string name, Transform transform, Tag tag) : base(name, transform, tag) { }
    }
}
