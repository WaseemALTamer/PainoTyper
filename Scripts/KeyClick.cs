using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class KeyClick : MonoBehaviour
{

    public string KeyName;
    public string SecoundKey;
    public bool Space;

    private bool Shift;
    private AudioClipKey Player;
    private Dictionary<string, KeyCode> keyMap;

    // Start is called before the first frame update
    void Start(){
        Player = GetComponent<AudioClipKey>();
        keyMap = new Dictionary<string, KeyCode> { };
        keyMap.Add("a", KeyCode.A);
        keyMap.Add("b", KeyCode.B);
        keyMap.Add("c", KeyCode.C);
        keyMap.Add("d", KeyCode.D);
        keyMap.Add("e", KeyCode.E);
        keyMap.Add("f", KeyCode.F);
        keyMap.Add("g", KeyCode.G);
        keyMap.Add("h", KeyCode.H);
        keyMap.Add("i", KeyCode.I);
        keyMap.Add("j", KeyCode.J);
        keyMap.Add("k", KeyCode.K);
        keyMap.Add("l", KeyCode.L);
        keyMap.Add("m", KeyCode.M);
        keyMap.Add("n", KeyCode.N);
        keyMap.Add("o", KeyCode.O);
        keyMap.Add("p", KeyCode.P);
        keyMap.Add("q", KeyCode.Q);
        keyMap.Add("r", KeyCode.R);
        keyMap.Add("s", KeyCode.S);
        keyMap.Add("t", KeyCode.T);
        keyMap.Add("u", KeyCode.U);
        keyMap.Add("v", KeyCode.V);
        keyMap.Add("w", KeyCode.W);
        keyMap.Add("x", KeyCode.X);
        keyMap.Add("y", KeyCode.Y);
        keyMap.Add("z", KeyCode.Z);
        keyMap.Add("0", KeyCode.Alpha0);
        keyMap.Add("1", KeyCode.Alpha1);
        keyMap.Add("2", KeyCode.Alpha2);
        keyMap.Add("3", KeyCode.Alpha3);
        keyMap.Add("4", KeyCode.Alpha4);
        keyMap.Add("5", KeyCode.Alpha5);
        keyMap.Add("6", KeyCode.Alpha6);
        keyMap.Add("7", KeyCode.Alpha7);
        keyMap.Add("8", KeyCode.Alpha8);
        keyMap.Add("9", KeyCode.Alpha9);
        keyMap.Add("space", KeyCode.Space);
        keyMap.Add("f1", KeyCode.F1);
        keyMap.Add("f2", KeyCode.F2);
        keyMap.Add("f3", KeyCode.F3);
        keyMap.Add("f4", KeyCode.F4);
        keyMap.Add("f5", KeyCode.F5);
        keyMap.Add("f6", KeyCode.F6);
        keyMap.Add("f7", KeyCode.F7);
        keyMap.Add("f8", KeyCode.F8);
        keyMap.Add("f9", KeyCode.F9);
        keyMap.Add("f10", KeyCode.F10);
        keyMap.Add("f11", KeyCode.F11);
        keyMap.Add("f12", KeyCode.F12);
        keyMap.Add(";", KeyCode.Semicolon);
        keyMap.Add("'", KeyCode.Quote);
        keyMap.Add(",", KeyCode.Comma);
        keyMap.Add(".", KeyCode.Period);
        keyMap.Add("/", KeyCode.Slash);
        keyMap.Add("backslash", KeyCode.Backslash);
        keyMap.Add("minus", KeyCode.Minus);
        keyMap.Add("equals", KeyCode.Equals);
        keyMap.Add("[", KeyCode.LeftBracket);
        keyMap.Add("]", KeyCode.RightBracket);
        keyMap.Add("backquote", KeyCode.BackQuote);
    }

    // Update is called once per frame
    void Update(){
        if (KeyName == "")return;
            

        if (Input.GetKeyDown(keyMap["space"])) Shift = true;
            
        if (Input.GetKeyUp(keyMap["space"])) { 
            Shift = false;
            Player.Stop();
        }if(Shift != Space)return;


        if (KeyName != "" && SecoundKey != "") {
            if (Input.GetKeyDown(keyMap[KeyName]) || Input.GetKeyDown(keyMap[SecoundKey])){
                Player.Play();
            }
            if (Input.GetKeyUp(keyMap[KeyName]) || Input.GetKeyUp(keyMap[SecoundKey])){
                Player.Stop();
            }
            return;
        }

        if (Input.GetKeyDown(keyMap[KeyName])) {
            Player.Play();
        }if (Input.GetKeyUp(keyMap[KeyName])) {
            Player.Stop();
        }
    }
}