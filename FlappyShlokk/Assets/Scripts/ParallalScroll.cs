using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallalScroll : MonoBehaviour
{
    [SerializeField] float speed = 2;
    MeshRenderer mRenderer;
    
    

    float knightDist;

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

         mRenderer.material.mainTextureOffset += new Vector2(Time.deltaTime * speed, 0);
           

      
    }
}

