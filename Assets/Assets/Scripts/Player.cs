using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float X;
    float Y;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Input handling for movement
        X = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        Y = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(X, Y, 0);
    }
}
