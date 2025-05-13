using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectHIT : MonoBehaviour 
{

    [SerializeField] GameObject packetGUY;
    [SerializeField] GameObject guyanim;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
        }
        
    IEnumerator CollisionEnd()
    {

        packetGUY.GetComponent<player_movement>().enabled = false;
        guyanim.GetComponent<Animator>().Play("Stumble Backwards");
        yield return new WaitForSeconds(4);
        M_LVL_INFO.packetCount = 0;
        SceneManager.LoadScene(1);
    }
}