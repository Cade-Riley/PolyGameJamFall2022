using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vSpeed = 5;
    public float hSpeed = 5;
    private float hInput;
    private float vInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(hSpeed * hInput * Time.deltaTime, 0, vSpeed * vInput * Time.deltaTime);
    }
}
