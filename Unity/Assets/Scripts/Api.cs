using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

[CreateAssetMenu(fileName = "Api", menuName = "Api")]
public class Api : ScriptableObject {
    public string apiUrl = "http://145.93.133.194:8080/api";

    public IDictionary<string, object> GetCardById(int id)
    {
        WebRequest request = WebRequest.Create(apiUrl + "/cards/get?id=" + id); 
        request.Credentials = CredentialCache.DefaultCredentials; 
        WebResponse response = request.GetResponse(); 
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        response.Close();
        IDictionary<string, object> json = Json.JsonParser.FromJson(responseFromServer);
        return json;
    }
}
