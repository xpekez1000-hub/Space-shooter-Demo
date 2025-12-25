using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public GameObject explosionPrefab;
    private void OnTriggerEnter2D(Collider2D collision) => Die();
    
    // Start is called before the first frame update
   private void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1f);
        Destroy(gameObject);
    }
}
