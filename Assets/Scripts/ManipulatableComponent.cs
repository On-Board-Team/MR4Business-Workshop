using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// This script will basically enable the user to move a component as
    /// much as the pointer has moved.
    /// (If the left hand drags the object by (0 , 0.5 , 1),
    /// this object will also move by (0, 0.5 ,1) 
    /// [Not a fancy implementation]
    /// </summary>
    public class ManipulatableComponent : MonoBehaviour, IMixedRealityPointerHandler
    {
        public void OnPointerClicked(MixedRealityPointerEventData eventData)
        {
            //We won't use be using this method;
        }

        Vector3 _initialGameObjectPosition, _initialPointerPosition;
        public void OnPointerDown(MixedRealityPointerEventData eventData)
        {
            //We save both the initial positions
            _initialGameObjectPosition = transform.position;
            _initialPointerPosition = eventData.Pointer.Position;
        }

        public void OnPointerDragged(MixedRealityPointerEventData eventData)
        {
            //We calculate how much the pointer has moved
            Vector3 difference = eventData.Pointer.Position - _initialPointerPosition;

            transform.position = _initialGameObjectPosition + difference;
        }

        public void OnPointerUp(MixedRealityPointerEventData eventData)
        {
            //We won't be using this method too
        }
    }
}
