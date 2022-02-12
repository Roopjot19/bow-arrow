using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  
  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag.Equals("Balloon1")) 
    {
        scorescript.scoreValue += 1;
        Destroy(collision.gameObject);
    }
    if (collision.gameObject.tag.Equals("Balloon2")) 
    {
        scorescript.scoreValue += 1;
        Destroy(collision.gameObject);
    }
  }

  void OnTriggerEnter2D(Collider2D other) 
  {
        if (other.gameObject.tag.Equals("Balloon1")) 
        {
            scorescript.scoreValue += 1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag.Equals("Balloon2")) 
        {
            scorescript.scoreValue += 1;
            Destroy(other.gameObject);
        }
  }

}
