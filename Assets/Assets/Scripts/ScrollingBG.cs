using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Vector3 dir = Vector3.down;

    [SerializeField] Vector3 boundary;
    [SerializeField] Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;

        if (transform.position.y < boundary.y)
        {
            transform.position = spawnPos;
        }
    }
}
