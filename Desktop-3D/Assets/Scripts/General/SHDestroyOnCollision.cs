using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SHDestroyOnCollision : MonoBehaviour
{
    KillCounter killCounterScript;

    [SerializeField]
    string strTag;

    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    private bool oradyAdded= false;
    void Start()
    {
        Debug.Log("Pew pew") ;
        killCounterScript=GameObject.Find("KCO").GetComponent<KillCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
        if (bDestroyOther && !oradyAdded)
            {
                    Destroy(collision.gameObject);
                    killCounterScript.AddKill();
                    oradyAdded = true;
            }

        if (bDestroySelf )
        {
                
                Destroy(this.gameObject);
                //oradyAdded = true;
        }


            Debug.Log (collision); 
        }


        
    }
}
