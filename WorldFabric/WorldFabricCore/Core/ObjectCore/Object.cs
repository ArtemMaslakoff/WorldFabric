using WorldFabricCore.Core.MathCore;

namespace WorldFabricCore.Core.ObjectCore
{
    public class Object
    {
        protected string name;
        protected Transform transform;
        protected Tag tag;
        protected List<Object> subObjects;
        public Object()
        {
            name = "";
            transform = new Transform();
            tag = new Tag();
            subObjects = new List<Object>();
        }
        public Object(string name)
        {
            this.name = name;
            transform = new Transform();
            tag = new Tag();
            subObjects = new List<Object>();
        }
        public Object(string name, Transform transform)
        {
            this.name = name;
            this.transform = transform;
            tag = new Tag();
            subObjects = new List<Object>();
        }
        public Object(string name, Transform transform, Tag tag)
        {
            this.name = name;
            this.transform = transform;
            this.tag = tag;
            subObjects = new List<Object>();
        }
        public void SetTag(string tagName)
        {
            TagLibrary.AddTag(new Tag(tagName));
            tag = new Tag(tagName);
        }
        public void SetTag(Tag tag)
        {
            TagLibrary.AddTag(tag);
            this.tag = tag;
        }
        public void SetTransform(Transform transform)
        {
            this.transform = transform;
        }
        public List<Object> GetSubObjects()
        {
            return subObjects;
        }
        public Tag GetTag()
        {
            return tag;
        }
        public string GetTagName()
        {
            return tag.GetName();
        }
        public Transform GetTransform()
        {
            return transform;
        }
        public void AddSubObject(Object newSubObject)
        {
            if (!subObjects.Contains(newSubObject))
            {
                subObjects.Add(newSubObject);
            }
        }
        public void RemoveSubObject(Object removableObject)
        {
            subObjects.Remove(removableObject);
        }
        public override string ToString()
        {
            string result = "Object: " + name + "\n";
            foreach (var str in transform.ToString().Split('\n'))
            {
                result += "\t" + str + "\n";
            }
            result += "\t" + tag.ToString() + "\n";
            return result;
        }
    }
}
