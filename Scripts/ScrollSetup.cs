using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSetup : MonoBehaviour
{
    public GameObject ScrollContent;
    public GameObject NotePrefab;
    public string[] NoteArray;

    // Start is called before the first frame update
    void Start(){
        for (int i = 0; i < NoteArray.Length; i++) {
            GameObject Object = Instantiate(NotePrefab);
            Object.transform.position = new Vector3 (3.2f,(i*1.2f)+(-5),0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
