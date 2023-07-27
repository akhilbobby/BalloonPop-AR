using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] balloons;
    private Vector3 spawnPoints;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;

    private void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2);

        for (int i = 0; i < 3; i++)
        {
            spawnPoints = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
            Instantiate(balloons[i], spawnPoints, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }


}





