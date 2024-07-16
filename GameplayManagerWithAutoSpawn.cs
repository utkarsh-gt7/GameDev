using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{

    [SerializeField] GameObject targetPrefab;

    private void Start()
    {
        winPanel.SetActive(false);
        InvokeRepeating("SpawnTarget", lf, 1f);
    }

    void SpawnTarget()
    {
        float xPos = Random.Range(-7.5f, 7.5f);
        float yPos = Random.Range(-4f, 4f);

        Vector3 randomtargetPos = new Vector3(xPos, yPos, 0);

        Instantiate(targetPrefab, randomtargetPos, Quaternion.identity);
    }
]
