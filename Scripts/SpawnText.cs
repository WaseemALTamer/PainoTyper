using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq.Expressions;

public class SpawnText : MonoBehaviour
{
    public GameObject TextPrefab;

    // Start is called before the first frame update
    void Start(){
        GameObject Object = Instantiate(TextPrefab);
        Object.transform.position = gameObject.transform.position + new Vector3(0.01f,0,-2);
        if (GetComponent<KeyClick>().Space == false) {
            Object.transform.position += new Vector3(0, -1, 0);
        }
        else {
            Object.GetComponent<LetterSetup>().SetColorWhite = true;
        }
        Object.GetComponent<LetterSetup>().Text = GetComponent<KeyClick>().KeyName;
        Object.transform.SetParent(gameObject.transform);
    }
}
