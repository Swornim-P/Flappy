using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public GameObject type1;
    public GameObject type2;
    public GameObject type3;
    private List<GameObject> obstacles;
    

    // Start is called before the first frame update
    void Start()
    {
        obstacles = new List<GameObject>();
        obstacles.Add(type1);
        obstacles.Add(type2);  
        obstacles.Add(type3);


        InvokeRepeating("LaunchObstacles", 3, 1);
        foreach (GameObject obj in obstacles)
        {
            Debug.Log("Added GameObject: " + obj.name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LaunchObstacles()
    {
        int randomIndex = Random.Range(0, obstacles.Count);
        GameObject selectedObstacle = obstacles[randomIndex];
        // Vector3 spawnPosition = transform.position + spawnOffset;
        Instantiate(selectedObstacle);
    }
}

