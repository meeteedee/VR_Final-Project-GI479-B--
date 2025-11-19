using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DoorUnlock : MonoBehaviour
{
    [Header("Key Settings")]
    public string requiredKeyId = "Key1";   // ตั้งเป็น Key1 / Key2 / Key3 / Key4 ให้ตรงกับกุญแจ

    [Header("Door Object (optional)")]
    public GameObject doorObject; // ถ้าเว้นว่าง จะลบ GameObject นี้เอง

    private void Reset()
    {
        // ให้ collider เป็น trigger จะได้เดินทะลุจุดตรวจจับได้
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerInventory inv = other.GetComponent<PlayerInventory>();
        if (inv == null) return;

        if (inv.HasKey(requiredKeyId))
        {
            Debug.Log("Door opened with key: " + requiredKeyId);

            // ถ้าไม่เซ็ต doorObject จะลบตัวที่มีสคริปต์นี้
            if (doorObject == null)
                Destroy(gameObject);
            else
                Destroy(doorObject);
        }
        else
        {
            Debug.Log("Need key: " + requiredKeyId);
        }
    }
}