using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] int DestroyTime = 12;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "end");
        Destroy(this.gameObject);
    }*/
}
