using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTossBoothService : MonoBehaviour
{
    public event Action<int> ScoreUpdated;
    [SerializeField] private GameObject[] rings;
    private int scoreToAdd = 10;
    private int _score;
    private Vector3[] _ringStartingPositions;
    private Quaternion[] _ringStartingOrientations;

    void Start()
    {
        _ringStartingPositions = new Vector3[rings.Length];
        _ringStartingOrientations = new Quaternion[rings.Length];

        for (int i = 0; i < rings.Length; i++)
        {
            _ringStartingPositions[i] = rings[i].transform.position;
            _ringStartingOrientations[i] = rings[i].transform.rotation;

        }
        Debug.Log("In Service");
    }

    public void AddToScore()
    {
        _score += scoreToAdd;
        ScoreUpdated?.Invoke(_score);
    }

    [ContextMenu("Reset Game")]
    public void ResetGame()
    {
        for (int i = 0; i < rings.Length; i++)
        {
            rings[i].transform.SetPositionAndRotation(_ringStartingPositions[i], _ringStartingOrientations[i]);
        }
        _score = 0;
        ScoreUpdated?.Invoke(_score);
    }

}
