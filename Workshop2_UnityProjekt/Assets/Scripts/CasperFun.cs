using System;
using UnityEngine;

public class CasperFun : MonoBehaviour
{
    [SerializeField] private int amountOfBeans;
    [SerializeField] private int amountOfWater;

    private bool hasBeenEvil;
    private void Update()
    {
        if (!hasBeenEvil)
        {
            int random = UnityEngine.Random.Range(0, 101);
            if (random == 74)
            {
                Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                hasBeenEvil = true;
            }
        }
    }
}
