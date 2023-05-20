using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{

    public Slider Slide;

    [SerializeField]
    string strSceneName;

    void Start()
    {
        Slide.minValue = 0;
        Slide.maxValue = 50;
    }

    public void Damage()
    {
        Slide.value -= 5;
        Debug.Log("damage");
        if(Slide.value <= 0)
        {
            SceneManager.LoadScene(strSceneName);
        }
        
    }
}