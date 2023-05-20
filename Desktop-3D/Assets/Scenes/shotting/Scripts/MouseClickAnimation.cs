using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickAnimation : MonoBehaviour
{
    void Start()
    {
        
    }

void Update() {
    if (Input.GetMouseButtonDown(0)) {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger("Shoot");
    }
}
}
