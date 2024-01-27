using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class Player
// {
//   public int health;
// }

public class PickUp : MonoBehaviour
{
  
  // public GameObject gm; // pasujes u unity
  private ScoreManager sm;

  private void Start()
  {
    // sm = gm.GetComponent<ScoreManager>();
    sm = GameObject.Find("Canvas").GetComponent<ScoreManager>();
  }

  // Kada objekat sa tagom "Player" se sudari sa kristalom, obrisi ga
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.tag == "Player")
    {
      // igrac.poeni += 10;
      sm.score += 1f;
      Destroy(gameObject);
    }
  }
}

