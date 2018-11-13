using UnityEngine;

namespace DefaultNamespace.Hand
{
    [RequireComponent(typeof(CardView3D))]
    public class TemporaryDraggable : MonoBehaviour
    {
        private CardView3D cv3d;
        private Transform card;
        private Vector3 dragOffset;
        private Plane plane;

        private Vector3 _ogPosition;
        private Quaternion _ogRotation;
        
        private void Awake()
        {
            cv3d = GetComponent<CardView3D>();
        }

        void OnMouseDown()
        {
            //if acceptinput

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, (1 << 10)))
            {
                card = hit.transform;
                
                _ogPosition = card.position;
                _ogRotation = card.rotation;
      
                card.rotation = new Quaternion(0f, 0f, 0f, 0f);
                plane.SetNormalAndPosition(Camera.main.transform.forward, card.position);
                dragOffset = card.position - Offset(ray);
            }
            else
            {
                Debug.Log("card is null");
            }
        }

        private Vector3 Offset(Ray ray)
        {
            float dist;
            plane.Raycast(ray, out dist);
            return ray.GetPoint(dist);
        }

        void OnMouseDrag()
        {
            //if acceptinput
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            card.position = Offset(ray) + dragOffset;
        }

        void OnMouseUp()
        {
            //if acceptinput

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, 1 << 9))
            {
                var dropZone = hit.transform.GetComponent<DropZone>();
                Debug.Log(dropZone.name);
                dropZone.DropCard(cv3d);
            }
            else
            {
                Debug.Log("resetting");
                cv3d.transform.position = _ogPosition;
                cv3d.transform.rotation = _ogRotation;
            }
        }
    }
}