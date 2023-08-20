using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color DesiredColor;

    private SpriteRenderer SpriteRenderer;
    private Color OrginalColor;
    private float Timer;
    void Start(){
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        OrginalColor = SpriteRenderer.color;
    }void FixedUpdate() {
        if (Timer <= Time.fixedTime) ReleasedColor();
    }
    
    public void PressedColor(){
        SpriteRenderer.color = DesiredColor;
        Timer = Time.fixedTime + 2.5f;
    }
    public void ReleasedColor() {
        SpriteRenderer.color = OrginalColor;
    }
}