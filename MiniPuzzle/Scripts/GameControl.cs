using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject CanvasWin;

    public static bool youWin;

    void Start()
    {
        CanvasWin.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        if(pictures[0].rotation.z == 0 &&
           pictures[1].rotation.z == 0 &&
           pictures[2].rotation.z == 0 &&
           pictures[3].rotation.z == 0 &&
           pictures[4].rotation.z == 0 &&
           pictures[5].rotation.z == 0 &&
           pictures[6].rotation.z == 0 &&
           pictures[7].rotation.z == 0)
        {
            youWin = true;
            CanvasWin.SetActive(true);
        }

    }
}
