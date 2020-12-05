using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
