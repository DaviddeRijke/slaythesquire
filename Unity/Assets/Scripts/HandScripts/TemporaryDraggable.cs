using UnityEngine;

namespace DefaultNamespace.Hand
{
    /// <summary>
    /// Not much changed from the original draggable, but because the old draggable was still being used, I did it in this class.
    /// </summary>
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

        /// <summary>
        /// Please keep in mind that this class should not be the one limiting which cards can or cannot be dragged.
        /// When checking mana/energy for a card, remember that it should still be draggable to discard.
        /// Instead, implement this logic at the corresponding dropzones or their associated scripts.
        /// </summary>
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

                card.position = new Vector3(card.position.x, card.position.y, card.position.z - 0.05f);
                card.eulerAngles = new Vector3(card.eulerAngles.x, card.eulerAngles.y, 0f);

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