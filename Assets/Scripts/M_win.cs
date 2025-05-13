using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class M_win : MonoBehaviour 

{
    public void StartGameagain()
    {
        M_LVL_INFO.packetCount = 0;
        SceneManager.LoadScene(0);
    }
}