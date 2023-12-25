using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{   public GameObject Levels;
    // Start is called before the first frame update
    public void Deactive()
    {
        Levels.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    Levels.SetActive(!Levels.activeSelf);   
    }
}
