using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyScore : MonoBehaviour
{
    KillCounter killCounterScript;

    public TextMeshProUGUI  text;
    void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
        text.text = killCounterScript.kills.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
