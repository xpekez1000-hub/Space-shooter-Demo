using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private float timer;
    public float blinkInterval = 0.1f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= blinkInterval)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            timer = 0f;
        }
    }
}
