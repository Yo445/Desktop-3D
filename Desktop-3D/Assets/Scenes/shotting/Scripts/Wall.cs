using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    HealthBar healthBar;

    public string EnemyTag;

    private float timer = 0;


    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
        private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag(EnemyTag) && timer <=0)
        {
                healthBar.Damage();
                timer = 1f;
            Debug.Log(collision.gameObject.name);

        }
        timer -=Time.deltaTime;
        
    }
}
