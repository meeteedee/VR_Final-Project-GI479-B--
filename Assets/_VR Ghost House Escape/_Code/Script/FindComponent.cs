using UnityEngine;

public class FindComponent : MonoBehaviour
{
    void Start()
    {
        AudioListener audioListener = FindFirstObjectByType<AudioListener>();
        Debug.Log("- - - - -" + audioListener.gameObject.name);
    }
}
