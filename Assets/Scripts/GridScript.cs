using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{

    public int width;
    public int height;
    public int cellsize = 1;
    private int[,] gridArray;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        width = (int)transform.localScale.x;
        height = (int)transform.localScale.z;
        gridArray = new int[width, height];

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetWorldPosition((int)player.transform.position.x, (int)player.transform.position.z));
    }
    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, 1, y) * cellsize;
    }

    public void SetValue(int x, int y, int value)
    {
        gridArray[x, y] = value; //0 = empty, 1 = tall grass, 2 = plant1, 3 = plant2, 4 = plant3, 5 = destroyedPlant
    }
}
