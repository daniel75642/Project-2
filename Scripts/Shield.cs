using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject player;
    private float speed = 120f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + player.transform.up * 1.5f;
        if (Input.GetKey(KeyCode.L))
            transform.Rotate(new Vector3(0, 0, -speed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.J))
            transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
    }
}
