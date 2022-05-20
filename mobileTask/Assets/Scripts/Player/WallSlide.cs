using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSlide : MonoBehaviour
{
    public float Distanse = 1f;
    public float SlideSpeed = -1f;

    private PlayerControl _player;

    private void Start()
    {
        _player = GetComponent<PlayerControl>();
    }
    private void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, Distanse);

        if (!_player.IsGrounded && hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            if (GetComponent<Rigidbody2D>().velocity.y < SlideSpeed)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, SlideSpeed);
            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + Distanse * transform.localScale.x, transform.position.y)) ;
    }

}
