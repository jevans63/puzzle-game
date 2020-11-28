using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class DestroyOnCollisionLimit : MonoBehaviour
{        
    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        SceneManager.LoadScene("MainMenu");
    }
}