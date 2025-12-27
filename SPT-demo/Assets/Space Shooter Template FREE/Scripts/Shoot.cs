using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval;
    private float lastBulletTime;

    public Vector3 bulletOffset;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }
    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
    }
    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime > shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }
}
