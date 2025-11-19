using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // เก็บ id ของกุญแจที่เก็บแล้ว
    private HashSet<string> keys = new HashSet<string>();

    public void AddKey(string keyId)
    {
        if (!keys.Contains(keyId))
        {
            keys.Add(keyId);
            Debug.Log("Got key: " + keyId);
        }
    }

    public bool HasKey(string keyId)
    {
        return keys.Contains(keyId);
    }
}
