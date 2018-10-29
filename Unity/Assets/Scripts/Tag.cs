using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tag
{
    public int id;
    public string name;

    public override bool Equals(object obj)
    {
        Debug.Log("EQUALS HEUJ");
        var tag = obj as Tag;
        return tag != null && id.Equals(tag.id);
    }

    public Tag(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public static List<Tag> GetMockData()
    {
        return new List<Tag>
        {
            new Tag(1, "ddd"),
            new Tag(2, "aaa"),
            new Tag(3, "bbb"),
            new Tag(4, "ccc")
        };
    }
}