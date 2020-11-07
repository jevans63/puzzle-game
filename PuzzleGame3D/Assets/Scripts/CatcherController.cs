using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherController : MonoBehaviour
{
    public Material red, green, blue;
    public GameObject floor;
    string color = "Blue";
    //bool swapable = true; 

    void OnMouseDown()
    {
        swapColor();
    }

    void Update()
    {
        // if (Input.GetKeyDown("z") && floor.gameObject.CompareTag("Block1") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("x") && floor.gameObject.CompareTag("Block2") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("c") && floor.gameObject.CompareTag("Block3") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("v") && floor.gameObject.CompareTag("Block4") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }

        // if (Input.GetKeyDown("b") && floor.gameObject.CompareTag("Block5") && swapable == true)
        // {
        //     swapColor();
        //     //StartCoroutine(DelaySwapable(1));
        // }
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

    // IEnumerator DelaySwapable(float time)
    // {
    //     swapable = false;
    //     yield return new WaitForSeconds(time);
    //     swapable = true;
    // }
}
