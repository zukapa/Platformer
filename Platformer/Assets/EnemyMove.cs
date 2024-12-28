using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveDuration = 2;
    public float speed = 1;
    public Vector2 moveDirection = Vector2.up;

    private float timer = 0;

    private void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= moveDuration)
        {
            moveDirection *= -1;
            timer = 0;
        }
    }
}
