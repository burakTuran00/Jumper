using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cr_Health : MonoBehaviour
{
    int health = 3;
    public List<Image> h = new List<Image>();


    private void Start()
    {
        Time.timeScale = 1f;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            
        if (collision.gameObject.CompareTag("circle"))
        {
            health -= 1;
            if (health == 2)
            {
                h[2].enabled = false;
            }

            else if (health == 1)
            {
                h[1].enabled = false;
            }

            else if (health == 0)
            {
                h[0].enabled = false;
                Time.timeScale = 1f;

                SceneManager.LoadScene(1);
            }

        }

   

    }
}
