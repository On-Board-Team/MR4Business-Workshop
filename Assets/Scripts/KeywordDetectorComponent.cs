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
    public class KeywordDetectorComponent : MonoBehaviour, IMixedRealitySpeechHandler
    {
        TextMesh _textMesh;
        private void Start()
        {
            _textMesh = GetComponent<TextMesh>();

            CoreServices.InputSystem.RegisterHandler<IMixedRealitySpeechHandler>(this);
        }
        public void OnSpeechKeywordRecognized(SpeechEventData eventData)
        {
            //For the registered keywords, go to the MixedRealityToolkit GameObject
            //Check for the Input Profile, Speech Section.

            //The MRTK designers intentionnaly blocked the modification of the default used profiles
            //in order for us not to screw the current config.

            //If any modification is required, clone & customize the profile you want to modify.
            _textMesh.text = $"Keyword: {eventData.Command.Keyword}";
        }
    }
}
