using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using UnityEngine;

public class AudioClipKey : MonoBehaviour
{
    public AudioClip soundClip;


    private AudioSource Speaker;
    private ChangeColor SpriteChanger;
    private float Timer;
    private bool State;


    void Start(){
        Speaker = GetComponent<AudioSource>();
        SpriteChanger = GetComponent<ChangeColor>();
        Speaker.clip = soundClip;
    }
    public void FixedUpdate(){
        if (State){
            Speaker.volume = 1.0f;
        }
        else {
            Speaker.volume *= 1 / (Time.fixedTime - Timer);  
        }if (Speaker.volume == 0) {
            Speaker.Stop();
        }
    }
    
    
    public void Play(){
        Timer = Time.fixedDeltaTime + 3;
        Speaker.Play();
        Speaker.volume = 1.0f;
        State = true;
        SpriteChanger.PressedColor();
    }
    public void Stop(){
        if (State){
            Timer = Time.fixedTime;
            State = false;
            SpriteChanger.ReleasedColor();
        }
    }
    
}