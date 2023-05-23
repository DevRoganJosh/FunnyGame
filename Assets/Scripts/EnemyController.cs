using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Resetting the position of the other GameObject
        other.gameObject.transform.position = new Vector2(-10.2f, other.gameObject.transform.position.y);
    }
}
