using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Text HealthText;
    public float speed = 5f;
    public int health = 100;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        HealthText = GameObject.Find("Health").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(moveX, 0, moveZ) * (speed * Time.deltaTime));
        rb.velocity = new Vector3(moveX, 0, moveZ) * (speed);
    }

    public void Damage(int damage)
    {
        health -= damage;
        HealthText.text = $"Health {health}";
    }
}
