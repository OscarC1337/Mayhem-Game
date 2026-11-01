using UnityEngine;

public class ChaseScript : MonoBehaviour
{

    public GameObject Enemy;

    public Rigidbody2D RB;

    public float Speed = 2;

    Vector2 vel = new Vector2(0, 0);

    void Start()
    {

    }

    void Update()
    {

        if (transform.position.x < Enemy.transform.position.x)
        {
            vel.x = Speed;
        }
        if (transform.position.x > Enemy.transform.position.x)
        {
            vel.x = -Speed;
        }
        if (transform.position.y > Enemy.transform.position.y)
        {
            vel.y = -Speed;
        }
        if (transform.position.y < Enemy.transform.position.y)
        {
            vel.y = Speed;
        }

        RB.linearVelocity = vel;
    }
}

