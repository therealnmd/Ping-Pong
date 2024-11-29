using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 400.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
        AddStartingForce();
    }
    public void ResetBall()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector2.zero;
       
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 _direction = new Vector2(x, y);
        _rigidbody.AddForce(_direction * this.speed);
    }


    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
