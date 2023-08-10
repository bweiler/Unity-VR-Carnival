using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTossBoothService : MonoBehaviour
{
    [SerializeField] private GameObject[] rings;
    private int _score;
    private Vector3[] _ringStartingPositions;
    private Quaternion[] _ringStartingOrientations;

    void Start()
    {
        _ringStartingPositions = new Vector3[rings.length];
        _ringStartingOrientations = new Quarterion[rings.length];

        for (int i = 0, i < rings.Length, i++)
        {
            _ringStartingPositions[i] = rings[i].transform.position;
            _ringStartingOrientations[i] = rings[i].transform.rotation;

        }
    }

    public void AddToScore(int scoreToAdd)
    {
        _score += scoreToAdd;
    }

    public void ResetGame()
    {
        for (int i = 0, i < rings.Length, i++)
        {
            rings[i].transform.SetPositionAndRotation(_ringStartingPositions[i], _ringStartingOrientations[i]);
        }
    }

}
