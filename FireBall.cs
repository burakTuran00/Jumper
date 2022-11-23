using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FireBall : MonoBehaviour
{
   
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            float xRan = Random.Range(-7.8f, 8.1f);
            float yRan = Random.Range(3.9f, 4.4f);
            transform.position = new Vector2(xRan, yRan);

        }
        else if (collision.gameObject.CompareTag("oyuncu"))
        {
            
            float xRan = Random.Range(-7.8f, 8.1f);
            float yRan = Random.Range(3.9f, 4.4f);
            transform.position = new Vector2(xRan, yRan);

          



        }
    }
}
