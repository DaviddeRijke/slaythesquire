using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

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
