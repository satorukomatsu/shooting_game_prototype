using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private LifeManage lifeManage;

    // Start is called before the first frame update
    void Start()
    {
        lifeManage = GameObject.Find("Player")?.GetComponent<LifeManage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Animal")
        {
            int life = lifeManage.decreaseLife();
            if (life == 0)
            {
                Destroy(gameObject);
                Debug.Log("Game Over!!");
            }
        }
    }
}
