namespace WorldFabricCore.Core
{
    public struct Tag
    {
        private string tagName;
        public Tag()
        {
            tagName = "CommonTag";
            TagLibrary.AddTag(this);
        }
        public Tag(string name)
        {
            tagName = name;
            TagLibrary.AddTag(this);
        }
        public string GetName()
        {
            return tagName;
        }
        public override string ToString()
        {
            return "Tag: " + tagName;
        }
    }
    public class TagLibrary
    {
        private static List<Tag> tags = new List<Tag>();
        public static void AddTag(Tag newTag)
        {
            if (!tags.Contains(newTag))
            {
                tags.Add(newTag);
            }
        }
        public static void RemoveTag(Tag removableTag)
        {
            tags.Remove(removableTag);
        }
        public static void ClearTags()
        {
            tags = new List<Tag>();
        }
        public static Tag GetTag(string tagName)
        {
            foreach (Tag tag in tags)
            {
                if (tag.GetName() == tagName)
                {
                    return tag;
                }
            }
            throw new Exception("Not found tag exception");
        }
        public static List<Tag> GetTagList()
        {
            return new List<Tag>(tags);
        }
        public static bool Contains(Tag tag)
        {
            if (tags.Contains(tag))
            {
                return true;
            }
            return false;
        }
        public static bool Contains(string tagName)
        {
            foreach(Tag tag in tags)
            {
                if (tag.GetName() == tagName) 
                { 
                    return true;
                }
            }
            return false;
        }
        public static string ToString()
        {
            string result = "TagLibrary:\n";
            foreach (Tag tag in tags)
            {
                result += tag.ToString() + "\n";
            }
            return result;
        }
    }
}
