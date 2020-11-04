using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public Material red, green, blue;
    public GameObject floor;
    string color = "Blue";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && floor.gameObject.CompareTag("Block1"))
        {
            swapColor();
        }

        if (Input.GetKeyDown("x") && floor.gameObject.CompareTag("Block2"))
        {
            swapColor();
        }

        if (Input.GetKeyDown("c") && floor.gameObject.CompareTag("Block3"))
        {
            swapColor();
        }

        if (Input.GetKeyDown("v") && floor.gameObject.CompareTag("Block4"))
        {
            swapColor();
        }

        if (Input.GetKeyDown("b") && floor.gameObject.CompareTag("Block5"))
        {
            swapColor();
        }

    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.CompareTag(color))
        {
            Destroy(col.gameObject);
        } 
    }

        void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(color))
        {
            Destroy(col.gameObject);
        } 
    }

    void swapColor()
    {
        if (color == "Red")
        {
            floor.GetComponent<MeshRenderer>().material = green;
            color = "Green";
        }
        else if (color == "Green")
        {
            floor.GetComponent<MeshRenderer>().material = blue;
            color = "Blue";
        }
        else if (color == "Blue")
        {
            floor.GetComponent<MeshRenderer>().material = red;
            color = "Red";
        }
    }
}
