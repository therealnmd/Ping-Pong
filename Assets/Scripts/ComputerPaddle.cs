using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if (this.ball.velocity.x < 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this._speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this._speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * this._speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * this._speed);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
