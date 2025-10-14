using System;
using UnityEngine;

public class spawnHawks : MonoBehaviour
{
    public GameObject hawk;
    public Transform[] lanes;
    private float timer = 2;
    public int lane;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            PickLane();
            SpawnHawk(lane);
            timer = 2;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    public void PickLane()
    {
        lane = UnityEngine.Random.Range(0, lanes.Length);
        Debug.LogWarning("Chose Lane");
    }
    public void SpawnHawk(int l)
    {
        Instantiate(hawk, lanes[l]);
        Debug.LogError("Spawned Hawk");
    }
}
