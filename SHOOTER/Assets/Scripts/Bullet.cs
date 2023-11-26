using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public GameObject bonusBullet; 
    private float random;
    public GameObject bonus;
    public Rigidbody2D monRigidBody;
    public float speed;
    public TextMeshProUGUI myUi;

    // Start is called before the first frame update
    void Start()
    {
       
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       NewEnemy bullet=collision.gameObject.AddComponent<NewEnemy>();
        
        if (collision.gameObject.tag == "ennemy")
        {
            random = Random.Range(0, 4);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
            if (random == 2)
            {
                Instantiate(bonus, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            }
           
        }
        if (collision.gameObject.tag == "newenemy")
        {
            bullet.hp -= 1;
            Destroy(gameObject);
            if (bullet.hp <= 0)
            {
                Destroy(collision.gameObject);
                myUi.text = "";
            }
        }
    }
    
}
