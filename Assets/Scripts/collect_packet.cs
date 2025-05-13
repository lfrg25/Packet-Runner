using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collect_packet : MonoBehaviour
{
    [SerializeField] AudioSource packetFX;

    void OnTriggerEnter(Collider other)
    {
        packetFX.Play();
        M_LVL_INFO.packetCount += 1;
        this.gameObject.SetActive(false);

        if (M_LVL_INFO.packetCount == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}




