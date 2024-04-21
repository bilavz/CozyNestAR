using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARManager : MonoBehaviour
{
    public GameObject ARObject;
    public ShowNotification notificationScript;

    // Start is called before the first frame update
    void Start()
    {
        // Munculkan notifikasi saat AR belum ditemukan
        notificationScript.ActivateInterface();
    }

    // Method ini dapat dipanggil ketika AR ditemukan
    public void ARFound()
    {
        ARObject.SetActive(true); // Aktifkan objek AR
        notificationScript.DeactivateInterface(); // Sembunyikan notifikasi
    }
}
