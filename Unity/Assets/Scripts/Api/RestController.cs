using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Api
{
    public class RestController : MonoBehaviour
    {
        public const string Api = "http://localhost:8080/api";

        public static RestController Instance { get; private set; }

        void Awake()
        {
            if(Instance == null) Destroy(Instance);
            Instance = this;
        }

        public void Get<T>(string url, ILoadable loadable)
        {
            StartCoroutine(GetRequest<T>(url, loadable));
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
                        Debug.Log(jsonResult);
                        T[] entities =
                            JsonHelper.getJsonArray<T>(jsonResult);
                        Debug.Log(entities);
                        loadable.SetData(entities);
                        foreach (var entity in entities)
                        {
                            var card = entity as Card;
                            if (card.tags.Length == 0) break;
                            Debug.Log(card.tags[0].name + ", " + card.tags[0].id);
                        }
                    }          
                }
            }
        }

        void Update()
        {

        }
    }
}
