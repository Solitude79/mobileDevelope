using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _pos;

    private void Awake()
    {
        if (!_player)
        {
            _player = FindObjectOfType<PlayerControl>().transform;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_player)
        {
            _pos = _player.position;
            _pos.z = -10f;
            transform.position = Vector3.Lerp(transform.position, _pos, Time.deltaTime);
        }
        

    }
}
