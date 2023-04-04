using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private ScoreManage scoreManage;

    void Start()
    {
        scoreManage = GameObject.Find("Player")?.GetComponent<ScoreManage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            scoreManage.countUpScore();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
