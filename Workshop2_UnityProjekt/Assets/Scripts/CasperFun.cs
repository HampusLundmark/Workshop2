using System;
using UnityEngine;

public class CasperFun : MonoBehaviour
{
    [SerializeField] private int amountOfBeans;
    [SerializeField] private int amountOfWater;

    private void Start()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }
}
