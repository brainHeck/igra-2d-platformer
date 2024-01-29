using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
  private ScoreManager sm;
  private PlayerScript player;

  private void Start()
  {
    // sm = gm.GetComponent<ScoreManager>();
    sm = GameObject.Find("Canvas").GetComponent<ScoreManager>();
    player = GameObject.Find("Lik").GetComponent<PlayerScript>();
  }

  // Kada objekat sa tagom "Player" se sudari sa kristalom, obrisi ga
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player")
    {
      sm.score += 1f;
      player.poeni += 1;
      Debug.Log(player.poeni);
      Destroy(gameObject);
    }
  }
}

