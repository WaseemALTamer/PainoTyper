using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

    public GameObject HitObject;

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePosition2D = new Vector2(mousePosition.x, mousePosition.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition2D, Vector2.zero);
            if (hit.collider != null){
                GameObject hitObject = hit.collider.gameObject;
                hitObject.GetComponent<AudioClipKey>().Play();
                HitObject = hitObject;
            }
        }
        if (Input.GetMouseButtonUp(0)){
            if (HitObject != null) { 
                HitObject.GetComponent<AudioClipKey>().Stop();
                HitObject = null;
            }
        }
    }
}