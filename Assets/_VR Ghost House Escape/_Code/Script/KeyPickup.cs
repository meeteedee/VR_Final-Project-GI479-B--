using UnityEngine;

[RequireComponent(typeof(Collider))]
public class KeyPickup : MonoBehaviour
{
    public string keyId = "Key1";  // ตั้งชื่อไม่ซ้ำกัน เช่น Key1, Key2, Key3, Key4

    private void Reset()
    {
        // ให้ Collider เป็น Trigger อัตโนมัติเวลาเพิ่ม component
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("- - - - - - - Something touch Key " + other.gameObject.name);
        if (!other.CompareTag("Player")) return;

        PlayerInventory inv = other.GetComponent<PlayerInventory>();
        if (inv != null)
        {
            inv.AddKey(keyId);
            // ทำ effect เพิ่มได้ เช่นเสียง เก็บของ
            Destroy(gameObject);   // ลบกุญแจออกจากฉาก
        }
    }
}