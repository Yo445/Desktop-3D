using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCounter : MonoBehaviour
{
public TextMeshProUGUI  counterText;
public int kills;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }
    private void ShowKills()
    {
        if(counterText != null)
        {
            counterText.text = kills.ToString();
        }
        
    }
    public void AddKill()
    {
        kills++;
    }
}
