using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetpackController : MonoBehaviour
{
    public float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    void MoveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
