using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

[CreateAssetMenu(fileName = "Api", menuName = "Api")]
public class Api : ScriptableObject {
    public string apiUrl = "http://192.168.30.103:8080/api";

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

    public List<IDictionary<string, object>> GetAllCards()
    {
        WebRequest request = WebRequest.Create(apiUrl + "/cards");
        request.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        response.Close();
        List<IDictionary<string, object>> json = Json.JsonParser.Deserialize<List<IDictionary<string, object>>>(responseFromServer);
        return json;
    }

	public List<int> GetAllCardIds()
	{
		List<int> ids = new List<int>();
		WebRequest request = WebRequest.Create(apiUrl + "/cards");
		request.Credentials = CredentialCache.DefaultCredentials;
		WebResponse response = request.GetResponse();
		Stream dataStream = response.GetResponseStream();
		StreamReader reader = new StreamReader(dataStream);
		string responseFromServer = reader.ReadToEnd();
		reader.Close();
		response.Close();
		List<IDictionary<string, object>> json = Json.JsonParser.Deserialize<List<IDictionary<string, object>>>(responseFromServer);
		foreach (IDictionary<string, object> cardInfo in json)
		{
			ids.Add(Convert.ToInt32(cardInfo["id"]));
		}
		return ids;
	}
}
