using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Renderer rr;
    public Color colorEnter = new Color(235f/255f, 0f, 0f);
    public Color colorStay = new Color(145f/255f, 0f, 0f);
    public Color colorExit = new Color(1f, 35f/255f, 35f/255f);

    private Color originalColor; //When we want to revert changes

    // Start is called before the first frame update
    void Start()
    {
        rr = GetComponentInChildren<Renderer>();
        originalColor = rr.material.color;
    }

    void OnTriggerEnter(Collider collider)
    {
        rr.material.color = colorEnter;
    }

    void OnTriggerStay(Collider collider)
    {
        rr.material.color = colorStay;
    }

    void OnTriggerExit(Collider collider)
    {
        rr.material.color = colorExit;
    }
}
