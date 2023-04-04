using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float amountSeconds;

    // Update is called once per frame
    void Update()
    {
        amountSeconds += Time.deltaTime;
        if (amountSeconds < 2.0f)
        {
            return;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            amountSeconds = 0;
        }
    }
}
