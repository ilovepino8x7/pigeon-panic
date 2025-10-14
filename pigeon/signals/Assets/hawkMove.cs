using UnityEngine;

public class hawkMove : MonoBehaviour
{
    public int moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Time.deltaTime * moveSpeed;
    }
}
