using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpikeDie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //SceneManager.LoadScene("level1");
            SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
        }
    }
}
