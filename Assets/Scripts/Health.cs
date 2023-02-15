using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Update is called once per frame
    
}
