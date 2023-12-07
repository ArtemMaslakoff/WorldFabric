using WorldFabricCore.Core.MathCore;

namespace WorldFabricCore.ContinuousWorldCore.ContinuousMathCore
{
    public class ContinuousTransform : Transform
    {
        public ContinuousTransform() : base() { }
        public ContinuousTransform(Position position, Rotation rotation, Scale scale) : base(position, rotation, scale) { }
    }
}
