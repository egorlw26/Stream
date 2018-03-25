using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpetBeh : MonoBehaviour
{
    bool active = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
    }
}
