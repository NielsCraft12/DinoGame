using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float backGroundSpeed;
    public Renderer backgroundRenderer;

    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backGroundSpeed * Time.deltaTime, 0f);
    }

}
