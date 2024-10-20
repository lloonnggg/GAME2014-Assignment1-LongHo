using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 2 * Vector3.up * Time.deltaTime;
    }

    public void Spawn()
    {
        Instantiate(this, player.transform.position, Quaternion.identity);
    }
}
