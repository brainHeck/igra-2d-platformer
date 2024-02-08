using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    public PlayerScript player;
    public int potrebniPoeni;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && player.poeni == potrebniPoeni)
        {
            Debug.Log("pobeda!");
            //SceneManager.LoadScene("level2");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
