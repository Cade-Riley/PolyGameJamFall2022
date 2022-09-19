using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vSpeed = 5;
    public float hSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(hSpeed * Input.GetAxis("Horizontal") * Time.deltaTime,0, vSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
