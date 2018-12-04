using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packet
{

    private string action;
    private Dictionary<string, string> properties;

    public string Action
    {
        get
        {
            return action;
        }
        set
        {
            action = value.ToUpper();
        }
    }
    /// <summary>
    /// Returns the json to send
    /// </summary>
    public string Message
    {
        get
        {
            JObject props = props = new JObject();
            foreach (KeyValuePair<string, string> item in properties)
            {
                props.Add(item.Key, item.Value);
            }

            JObject json = new JObject(
                new JProperty("action", action),
                new JProperty("properties", props));

            return json.ToString();
        }
    }

    /// <summary>
    /// Use this for new Packets
    /// </summary>
    public Packet()
    {
        properties = new Dictionary<string, string>();
    }

    /// <summary>
    /// Use this for recieved Packets
    /// </summary>
    /// <param name="recievedMessage"></param>
    public Packet(string message)
    {
        properties = new Dictionary<string, string>();

        JObject json = JObject.Parse(message);

        action = json.GetValue("action").ToString();

        JToken propToken = json.GetValue("properties");
        if (propToken.HasValues)
        {
            JObject props = (JObject)propToken;
            foreach (var item in props)
            {
                properties.Add(item.Key, item.Value.ToString());
            }
        }
    }

    public void OverrideProperty(string property, string value)
    {
        RemoveProperty(property);
        AddProperty(property, value);
    }

    public void OverrideArrayProperty(string property, List<string> value)
    {
        RemoveProperty(property);
        AddArrayProperty(property, value);
    }

    public bool AddProperty(string property, int value)
    {
        return AddProperty(property, value.ToString());
    }

    public bool AddProperty(string property, string value)
    {
        if (!properties.ContainsKey(property))
        {
            properties.Add(property, value);
            return true;
        }
        return false;
    }

    public bool AddArrayProperty(string property, List<string> value)
    {
        if (!properties.ContainsKey(property))
        {
            string[] valueArray = value.ToArray();
            JArray array = JArray.FromObject(valueArray);
            properties.Add(property, array.ToString());
            return true;
        }
        return false;
    }

    public bool RemoveProperty(string property)
    {
        if (properties.ContainsKey(property))
        {
            properties.Remove(property);
            return true;
        }
        return false;
    }

    public string GetProperty(string property)
    {
        if (properties.ContainsKey(property))
        {
            return properties[property];
        }
        return null;
    }

    public List<string> GetArrayProperty(string property)
    {
        if (properties.ContainsKey(property))
        {
            List<string> list = new List<string>();

            JArray array = JArray.Parse(properties[property]);
            foreach (JToken token in array.Children())
            {
                string json = token.ToString();
                Debug.Log(json);
            }

            return list;
        }
        return null;
    }
}