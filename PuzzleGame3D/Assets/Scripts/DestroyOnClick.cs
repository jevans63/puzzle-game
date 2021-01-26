using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a simple script which is attached only to the Orange bomb object prefab
// It allows for the Orange bomb block to be clicked by the player 
// to “diffuse” it before it touches the bottom row
// When the block is clicked it plays a sound effect and is removed by using the Destroy() function
public class DestroyOnClick : MonoBehaviour
{
    public AudioClip diffuse;
    public AudioSource Source;
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Source.PlayOneShot(diffuse, 0.6f);
            // Destroy(this.gameObject);
            StartCoroutine(Diffuse(0.1f));
        }
    }

    IEnumerator Diffuse(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
