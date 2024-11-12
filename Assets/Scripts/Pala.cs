using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    [SerializeField]
    private float powerupScale = 2f;
    [SerializeField]
    private float powerupTime = 5f;
    private float powerupTimeLeft;
    private float startWidth;

    // Start is called before the first frame update
    void Start()
    {
        startWidth = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (powerupTimeLeft > 0)
        {
            powerupTimeLeft -= Time.deltaTime;
            if(powerupTimeLeft < 0)
            {
                transform.localScale = new Vector3(startWidth, transform.localScale.y, transform.localScale.z);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Powerup")
        {

            Destroy(other.gameObject);
            powerupTimeLeft = powerupTime;
            transform.localScale = new Vector3(powerupScale * startWidth, transform.localScale.y, transform.localScale.z);
        }

    }
}
