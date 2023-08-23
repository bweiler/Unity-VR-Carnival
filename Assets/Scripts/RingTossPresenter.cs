using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RingTossPresenter : MonoBehaviour
{
    [SerializeField] TMP_Text TMP_ScoreText;
    private RingTossBoothService _ringTossBoothService;

    private void Start()
    {
        _ringTossBoothService = FindObjectOfType<RingTossBoothService>();
        if (_ringTossBoothService != null)
        {

        }
    }

    private void OnScoreUpdated(int newScore)
    {

    }


}
