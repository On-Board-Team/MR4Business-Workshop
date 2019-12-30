using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusableComponent : MonoBehaviour, IMixedRealityFocusHandler
{
    public void OnFocusEnter(FocusEventData eventData)
    {
        _renderer.material.color = Color.grey;
        Debug.Log($"OnFocusEnter from Pointer:{eventData.Pointer.PointerName}");
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        _renderer.material.color = Color.cyan;
        Debug.LogFormat("OnFocusExit from Pointer:{0}", eventData.Pointer.PointerName);
    }
    Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
}
