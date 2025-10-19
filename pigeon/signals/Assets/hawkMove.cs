using UnityEngine;

public class hawkMove : MonoBehaviour
{
    public int moveSpeed;
    public logicManager logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindWithTag("Logos").GetComponent<logicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Time.deltaTime * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            logic.HawkHit();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "HawkDestroyer")
        {
            Destroy(transform.gameObject);
        }
    }
}
