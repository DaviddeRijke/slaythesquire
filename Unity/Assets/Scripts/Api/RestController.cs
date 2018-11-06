using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using Object = System.Object;

namespace Api
{
    public class RestController : MonoBehaviour
    {
        public const string Api = "http://localhost:8080/api";
		public UnityEvent started;

        public static RestController Instance { get; private set; }

        void Awake()
        {
            if(Instance == null) Destroy(Instance);
            Instance = this;
			started.Invoke();
        }

        public void Get<T>(string url, ILoadable loadable)
        {
            StartCoroutine(GetRequest<T>(url, loadable));
        }

        public void Put(string url, int data)
        {
            //Debug.Log(data);
            StartCoroutine(PutRequest(url, JsonUtility.ToJson(new IntegerWrapper(data))));
        }

        public void Post(string url, object data)
        {
            var json =
                "{\"winner\":{\"id\":0,\"username\":\"a\",\"decks\":[],\"currency\":0},\"loser\": {\"id\":0,\"username\":\"a\",\"decks\":[],\"currency\":0}}";
            Debug.Log(json);
            StartCoroutine(PostRequest(url, JsonUtility.ToJson(data)));
            StartCoroutine(PostRequest(url, json));
        }

        IEnumerator PutRequest(string url, string data)
        {         
            //Debug.Log(Api + url + data);         
            using (UnityWebRequest www = UnityWebRequest.Put(Api + url, data))
            {
                www.SetRequestHeader("Content-Type", "application/json");             
                yield return www.SendWebRequest();
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
                        //Debug.Log(jsonResult);                      
                    }
                }
            }
        }

        IEnumerator PostRequest(string url, string json)
        {
            var uwr = new UnityWebRequest(Api + url, "POST");
            byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
            uwr.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
            uwr.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            uwr.SetRequestHeader("Content-Type", "application/json");

            //Send the request then wait here until it returns
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.Log("Error While Sending: " + uwr.error);
            }
            else
            {
                Debug.Log("Received: " + uwr.downloadHandler.text);
            }
        }


        IEnumerator GetRequest<T>(string url, ILoadable loadable)
        {
            using (UnityWebRequest www = UnityWebRequest.Get(Api + url))
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
                        //Debug.Log(jsonResult);
                        T[] entities =
                            JsonHelper.getJsonArray<T>(jsonResult);
                        //Debug.Log(entities);
                        loadable.SetData(entities);
                    }          
                }
            }
        }
    }

[System.Serializable]
    internal class IntegerWrapper
{
    public int value;

    public IntegerWrapper(int value)
        {
            this.value = value;
        }
    }
}
