using UnityEngine;

public class RasmusVariable : MonoBehaviour
{
    public int Var1 = 3;
    public int Var2 = 20;
    public int Var3 = 9;

    [SerializeField] private int Var4 = 32;

    void Start()
    {
        Debug.Log(Var1);
        Debug.Log(Var2);
        Debug.Log(Var3);
        Debug.Log(Var4);
    }
}
