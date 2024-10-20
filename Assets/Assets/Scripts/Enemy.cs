using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] EnemyBullet enemyBullet;

    [SerializeField] int fireRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootBullet());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime;
        
    }

    IEnumerator ShootBullet()
    {
        while (true)
        {
            Instantiate(enemyBullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
