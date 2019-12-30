using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

public class ClickableComponent : MonoBehaviour, IMixedRealityInputHandler
{
    Renderer _renderer;
    public void OnInputDown(InputEventData eventData)
    {
        _renderer.material.color = Color.red;
    }
    public void OnInputUp(InputEventData eventData)
    {
        _renderer.material.color = Color.green;
    }
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
}
