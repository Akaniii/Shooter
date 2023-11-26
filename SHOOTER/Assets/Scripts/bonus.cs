using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovementEtTir player = collision.gameObject.GetComponent<MovementEtTir>();
        ;
        if (player != null)
        {
            
            Destroy(gameObject);
            
        }
    }
}
