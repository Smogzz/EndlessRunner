using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basePrefab;
    float minY = -4f;
    float maxY = -1.54f;
    Player playerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBase", 2.0f, 2.0f);
        playerScript = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       if(playerScript.isAlive == false) 
       {
            CancelInvoke();
       }
    }

    void SpawnBase()
    {
        Instantiate(basePrefab, new Vector2(14.12f, Random.Range(minY,maxY)),Quaternion.identity);
    }
    

}

