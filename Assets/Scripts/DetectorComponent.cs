using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class DetectorComponent : MonoBehaviour, IMixedRealitySourceStateHandler
    {
        Renderer _renderer;
        public void OnSourceDetected(SourceStateEventData eventData)
        {
            _renderer.material.color = Color.magenta;
        }

        public void OnSourceLost(SourceStateEventData eventData)
        {
            _renderer.material.color = Color.blue;
        }
        private void Start()
        {
            _renderer = GetComponent<Renderer>();

            //If for example, we raise a hand, the Source (the hand) will be detected,
            //before this object has the focus which is why, 
            //OnSourceDetected(eventData) won't be called.

            //If we want it to capture every SourceDetected/Lost no matter
            //the current focused objects we will need to add this gameObject
            //to the Global Listeners. This can be done in two ways

            //1. Add the InputSystemGlobalListener component
            gameObject.AddComponent<InputSystemGlobalListener>(); //which is deprecated

            ////2. Register the source detection handler
            //CoreServices.InputSystem.RegisterHandler<IMixedRealitySourceStateHandler>(this);


        }
    }
}
