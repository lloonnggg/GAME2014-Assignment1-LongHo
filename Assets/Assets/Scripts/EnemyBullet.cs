using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = FindObjectOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += 2 * Vector3.down * Time.deltaTime;
    }

    public void Spawn()
    {
        Instantiate(this, enemy.transform.position, Quaternion.identity);
    }
}
