using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float animalRange = 15;
    private float animalPosZ = 25;
    private float animalPosX = 25;
    private float startDelay = 2;
    private float animalInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalsTop", startDelay, animalInterval);
        InvokeRepeating("SpawnRandomAnimalsLeft", startDelay, animalInterval);
        InvokeRepeating("SpawnRandomAnimalsRight", startDelay, animalInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpawnRandomAnimals();
        //}
    }

    void SpawnRandomAnimalsTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 animalPos = new Vector3(Random.Range(-animalRange, animalRange), 0, animalPosZ);
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0);

        Instantiate(animalPrefabs[animalIndex], animalPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalsLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 animalPos = new Vector3(-animalPosX, 0, Random.Range(0, 15));
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0);

        Instantiate(animalPrefabs[animalIndex], animalPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalsRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 animalPos = new Vector3(animalPosX, 0, Random.Range(0, 15));
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0);

        Instantiate(animalPrefabs[animalIndex], animalPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
