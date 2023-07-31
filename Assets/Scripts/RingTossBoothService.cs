using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTossBoothService : MonoBehaviour
{
    private int _score;
    public void AddToScore(int scoreToAdd)
    {
        _score += scoreToAdd;
    }

}
