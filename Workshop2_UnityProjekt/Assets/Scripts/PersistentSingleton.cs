using UnityEngine;

public class PersistentSingleton : MonoBehaviour
{
    [SerializeField] private string type;
    
    public string Type => type;
    
    private void Awake()
    {
        int amountOfSameType = 0;
        foreach (PersistentSingleton persistentSingleton in FindObjectsByType<PersistentSingleton>(FindObjectsSortMode.None))
        {
            if (persistentSingleton.Type == type)
            {
                amountOfSameType++;
            }
        }

        if (amountOfSameType > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }
}
