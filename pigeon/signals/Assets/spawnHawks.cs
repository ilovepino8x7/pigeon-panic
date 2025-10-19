using System;
using UnityEngine;

public class spawnHawks : MonoBehaviour
{
    public GameObject hawk;
    public Transform[] lanes;
    private float timer = 0;
    public int lane;
    public float[] spawnRate;
    public int currentRate = 0;
    public int hawksSpawned = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickLane();
        SpawnHawk(lane);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnRate[currentRate])
        {
            PickLane();
            SpawnHawk(lane);
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
        CheckRate();
    }
    public void PickLane()
    {
        lane = UnityEngine.Random.Range(0, lanes.Length);
        Debug.LogWarning("Chose Lane");
    }
    public void SpawnHawk(int l)
    {
        Instantiate(hawk, lanes[l]);
        hawksSpawned += 1;
        Debug.LogError("Spawned Hawk");
    }
    public void CheckRate()
    {
        if (hawksSpawned == 5)
        {
            currentRate = 1;
        }
        else if (hawksSpawned == 10)
        {
            currentRate = 2;
        }
        else if (hawksSpawned == 15)
        {
            currentRate = 3;
        }
        else if (hawksSpawned == 25)
        {
            currentRate = 4;
        }
        else if (hawksSpawned == 50)
        {
            currentRate = 5;
        }
        else if (hawksSpawned >= 75)
        {
            //Arrive
        }
    }
}
