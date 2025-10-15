using UnityEngine;

public class pigeonMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpStrength;
    public Transform[] paths;
    public int currentPath = 1;
    private int nextPath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        transform.position = paths[currentPath].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            choosePath(1);
            transform.position = paths[nextPath].position;
            currentPath = nextPath;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            choosePath(0);
            transform.position = paths[nextPath].position;
            currentPath = nextPath;
        }
        transform.position = new Vector3(0, transform.position.y, 0);
        transform.rotation = Quaternion.identity;

    }
    public void choosePath(int direction)
    {
        if (direction == 1 && currentPath < 2)
        {
            nextPath = currentPath + 1;
        }
        else if (direction == 1 && currentPath == 2)
        {
            Debug.LogError("Can't jump any higher than that.");
        }
        else if (direction == 0 && currentPath > 0)
        {
            nextPath = currentPath - 1;
        }
        else if (direction == 0 && currentPath == 0)
        {
            Debug.LogError("Can't go any lower");
        }
    }
}
