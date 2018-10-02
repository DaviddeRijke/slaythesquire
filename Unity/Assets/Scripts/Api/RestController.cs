using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class RestController : MonoBehaviour
{
    public const string api = "http://localhost:8080/api";

    public void GetCard(int id)
    {
        StartCoroutine(Get<Card>("/cards/get?id=" + id));
    }

    IEnumerator Get<T>(string url)
    {
        using (UnityWebRequest www = UnityWebRequest.Get(api + url))
        {
            yield return www.Send();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                if (www.isDone)
                {
                    string jsonResult =
                        Encoding.UTF8.GetString(www.downloadHandler.data);
                    Debug.Log(jsonResult);
                    T[] entities =
                        JsonHelper.getJsonArray<T>(jsonResult);
                }
            }
        }
    }

    void Update()
    {

    }
}
