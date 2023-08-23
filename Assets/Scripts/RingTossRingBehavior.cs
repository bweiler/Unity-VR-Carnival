using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTossRingBehavior : MonoBehaviour
{
    [SerializeField] private bool _isAroundBottle;
    [SerializeField] private RingTossBoothService _ringTossBoothService;

    void Start()
    {
        _ringTossBoothService = FindObjectOfType<RingTossBoothService>();
        Debug.Log("made it ");
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
        if (_ringTossBoothService != null && _isAroundBottle)
        {
            _ringTossBoothService.AddToScore();
        }
    }
}
