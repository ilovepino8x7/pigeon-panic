using UnityEngine;
using UnityEngine.SceneManagement;

public class logicManager : MonoBehaviour
{
    public int playerHealth = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("Fail");
        }
    }
    public void HawkHit()
    {
        playerHealth -= 1;
    }
}
