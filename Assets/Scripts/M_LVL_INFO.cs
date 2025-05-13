using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_LVL_INFO : MonoBehaviour 
{
    public static int packetCount = 0;
    [SerializeField] GameObject packetDisplay;

    void Update(){
        packetDisplay.GetComponent<TMPro.TMP_Text>().text = "PACKETS: " + packetCount;
    }



}
