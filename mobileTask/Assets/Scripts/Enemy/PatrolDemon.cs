using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolDemon : Entity
{
    [SerializeField] private float _speed = 3.5f;
    private bool _facingRight = true;
    private Vector3 _dir;
    public float Distanse = 3f; 

    private SpriteRenderer sprite;


    void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * _dir.x * 0.7f, 0.1f);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, Distanse);

        
        if (hit.collider != null)
        {
            
            transform.position = Vector3.MoveTowards(transform.position, transform.position + _dir, 1f * Time.deltaTime);
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                Debug.Log($"ударился в {hit.collider.name}");
                transform.position = Vector3.MoveTowards(transform.position, transform.position + _dir, _speed * Time.deltaTime);
            }
            if (colliders.Length > 0 && !hit.collider.gameObject.CompareTag("Player"))
            {
                _dir *= -1;
                Flip();
                Debug.Log(colliders[0].name);
            }


        }
       

        transform.position = Vector3.MoveTowards(transform.position, transform.position + _dir, _speed * Time.deltaTime);
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<PlayerControl>().GetDamage(0.1f);
        }
    }
    private void Start()
    {
        _dir = transform.right;
        
    }

    void Update()
    {
        Move();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + Distanse * transform.localScale.x, transform.position.y));
        Gizmos.DrawSphere(transform.position + transform.up * 0.1f + transform.right * _dir.x * 0.7f, 0.1f);
    }
}
