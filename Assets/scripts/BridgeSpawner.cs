using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSpawner : MonoBehaviour
{

    private bool hasBridgeSpawned =false;

    [SerializeField]
    private GameObject bridgeWalls;
    [SerializeField]
    private GameObject bridge;
    [SerializeField]
    private GameObject bridgeCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && !hasBridgeSpawned)
        {
            SpawnBridge();
            hasBridgeSpawned = true;
        }    
    }

    void SpawnBridge()
    {
        bridgeWalls.SetActive(true);
        bridge.SetActive(true);
        bridgeCollider.SetActive(false);
    }
}
