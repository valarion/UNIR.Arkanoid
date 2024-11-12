using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private GameObject pala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Move Freely
        var inputH = Input.GetAxisRaw("Horizontal");
        transform.Translate(inputH * Vector3.right * speed * Time.deltaTime);

        // 2. Limit movement
        float limitedX = Mathf.Clamp(transform.position.x, -4.75f + pala.transform.lossyScale.x/2, 4.75f - pala.transform.lossyScale.x/2);
        transform.position = new Vector3(limitedX, transform.position.y, transform.position.z);
    }
}
