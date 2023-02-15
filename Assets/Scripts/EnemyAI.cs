using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyAI : MonoBehaviour
{
    public int score;
    public string sceneName;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            for (score = 1; score >= 4; score++)
            {
                if(score == 3)
                {
                    SceneManager.LoadScene(sceneName);
                }
                
            }
        }
    }
}
