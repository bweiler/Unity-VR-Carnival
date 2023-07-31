using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTossRingBehavior : MonoBehaviour
{
    private bool _isAroundBottle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bottle"))
        {
            _isAroundBottle = true;
            StartCoroutine(ScoreDelay());
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bottle"))
        {
            _isAroundBottle = false;
        }

    }

    private IEnumerator ScoreDelay()
    {
        yield return new WaitForSeconds(3f);
        if (_isAroundBottle)
        {
            // add to score
        }
    }
}
