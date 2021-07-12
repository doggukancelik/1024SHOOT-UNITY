using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class best : MonoBehaviour
{
    public Text bestSkor;
    void Start()
    {
       bestSkor= gameObject.GetComponent<Text>();
       bestSkor.text = playerPrefs.highPrefs().ToString();
    }

    void Update()
    {

        bestSkor.text = playerPrefs.highPrefs().ToString();

    }
}
