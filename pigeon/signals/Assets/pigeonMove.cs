using UnityEngine;

public class pigeonMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpStrength);
        }

    }
}
