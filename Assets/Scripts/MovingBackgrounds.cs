using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackgrounds : MonoBehaviour
{
    public Renderer bgRenderer;

    [SerializeField] float scrollSpeed;

    
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0f);
        
    }
}
