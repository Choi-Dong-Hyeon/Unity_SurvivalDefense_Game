using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController player;

    private void Awake()
    {
        player = GetComponent<PlayerController>();
    }
    


    void Start()
    {
        Manager.Input.OnMoveAction += OnMove;
       
    }


    void Update()
    {

    }

    void OnMove()
    {
        float _speed = 20.0f;
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(moveX, 0, moveZ).normalized * _speed * Time.deltaTime;
    }
}
