using WorldFabricCore.ContinuousWorldCore.ContinuousMathCore;
using WorldFabricCore.Core.MathCore;
using WorldFabricCore.DiscreteWorldCore.DiscreteMathCore;

namespace WorldFabricCoreTests
{
    [TestClass]
    public class VectorClassTests
    {
        [TestMethod]
        public void FunctionCloneTests()
        {
            Vector mainVector = new Vector(4, new double[] { 3, 6, 2, 11});
            Vector resultVector = mainVector.Clone();


        }
        [TestMethod]
        public void FunctionLengthTests()
        {

        }
        [TestMethod]
        public void FunctionToStringTests()
        {

        }
        [TestMethod]
        public void FunctionEqualsTests()
        {

        }
        [TestMethod]
        public void OperatorSummTests()
        {

        }
        [TestMethod]
        public void OperatorSubTests()
        {

        }
    }
}