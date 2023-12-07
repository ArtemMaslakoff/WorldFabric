using WorldFabricCore;
using WorldFabricCore.Core;
using WorldFabricCore.Core.MathCore;
using WorldFabricCore.Core.ObjectCore.BodyCore;
using WorldFabricCore.Core.ParameterCore;
using Object = WorldFabricCore.Core.ObjectCore.Object;

World world = WorldCreator.CreateWorld(WorldNumericType.CONTINUOUS);
world = WorldCreator.CreateWorld(WorldNumericType.DISCRETE);

Object obj = new Object("Artem");
Object body = new Body();
obj.AddSubObject(body);


Console.WriteLine(ParameterLibrary.ToString());
Console.WriteLine(obj.ToString());

obj.GetTransform().Translate(new Vector(3, new double[] { 1, 2, 3 }));
obj.GetTransform().Rotate(new Vector(3, new double[] { 1, 2, 3 }));
obj.GetTransform().Scale(new Vector(3, new double[] { 1, 2, 3 }));
obj.SetTag("Human");
Console.WriteLine(obj.ToString());

Console.WriteLine(TagLibrary.ToString());