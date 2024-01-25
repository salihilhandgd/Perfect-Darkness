using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // takip edilecek hedef (karakter)
    public float distance = 10f; // kamera ile hedef aras�ndaki mesafe
    public float height = 5f; // kameran�n hedefin �st�nde olacak y�ksekli�i
    public float smoothSpeed = 0.125f; // kamera hareketinin yumu�akl���

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + new Vector3(height, -distance , 0f); // hedefin konumunu alarak kameran�n istenen konumunu hesapla
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // yumu�ak bir hareket i�in Lerp fonksiyonu kullan
        transform.position = smoothedPosition;

        transform.LookAt(target); // hedefe bak
    }
}
