using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float vSpeed = 5;
    public float hSpeed = 5;
    public GameObject grid;
    public GameObject grass;
    private float hInput;
    private float vInput;
    private Vector3 direction;
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

        direction = new Vector3((Input.GetAxisRaw("Horizontal")), 0, (Input.GetAxisRaw("Vertical")));
        if (Mathf.Abs(direction.x) > 0.01 || Mathf.Abs(direction.z) > 0.01)
        {
            //transform.rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.15F);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(grass, (grid.GetComponent<GridScript>().GetWorldPosition((int)transform.position.x, (int)transform.position.z)), transform.rotation);
        }
        //Debug.Log(direction);

        /*
if (hInput > 0.01)
{
    //transform.Rotate(Vector3.up, 90f);
    transform.eulerAngles = Vector3.up * 90;
} 
else if (hInput < -0.01)
{
    //transform.Rotate(Vector3.up, 90f);
    transform.eulerAngles = Vector3.down * 90;
}
else if (vInput > 0.01)
{
    //transform.Rotate(Vector3.up, 90f);
    transform.eulerAngles = Vector3.up * 180;
}
else if (vInput < -0.01)
{
    //transform.Rotate(Vector3.up, 90f);
    transform.eulerAngles = Vector3.down * -180;
}
*/


    }
}
