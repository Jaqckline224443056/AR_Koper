using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FirebaseDataManager : MonoBehaviour
{
    private DatabaseReference dbReference;

    // Variabel data dari Firebase
    private string valBuzzer = "-";
    private string valLED = "-";
    private string valMotor = "-";
    private string valPotensio = "-";
    private string valButton = "-";
    private string valKondisi = "-";
    private string valPeminjam = "-";
    private string valStatus = "-";
    private string valTanggal = "-";
    private string valWaktu = "-";

    // UI Text (drag di Inspector)
    public TextMeshPro txtBuzzer, txtLED, txtMotor, txtPotensio, txtButton;
    public TextMeshPro txtKondisi, txtPeminjam, txtStatus, txtTanggal, txtWaktu;

    private bool isDataUpdated = false;

    void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            if (task.Result == Firebase.DependencyStatus.Available)
            {
                dbReference = FirebaseDatabase.DefaultInstance.RootReference;

                dbReference.Child("tukel").Child("koper").ValueChanged += HandleValueChanged;
            }
            else
            {
                Debug.LogError("Firebase tidak siap: " + task.Result);
            }
        });
    }

    void HandleValueChanged(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError("Error: " + args.DatabaseError.Message);
            return;
        }

        DataSnapshot snapshot = args.Snapshot;

        if (snapshot != null && snapshot.Exists)
        {
            valBuzzer = snapshot.Child("komponenBUZZER").Value?.ToString() ?? "-";
            valLED = snapshot.Child("komponenLED").Value?.ToString() ?? "-";
            valMotor = snapshot.Child("komponenMOTOR DC").Value?.ToString() ?? "-";
            valPotensio = snapshot.Child("komponenPOTENSIOMETER").Value?.ToString() ?? "-";
            valButton = snapshot.Child("komponenPUSH BUTTON").Value?.ToString() ?? "-";
            valKondisi = snapshot.Child("kondisi_komponen").Value?.ToString() ?? "-";
            valPeminjam = snapshot.Child("peminjam").Value?.ToString() ?? "-";
            valStatus = snapshot.Child("status").Value?.ToString() ?? "-";
            valTanggal = snapshot.Child("tanggal_dipinjam").Value?.ToString() ?? "-";
            valWaktu = snapshot.Child("waktu_dipinjam").Value?.ToString() ?? "-";

            isDataUpdated = true;
        }
    }

    void Update()
    {
        if (isDataUpdated)
        {
            txtBuzzer.text = "Buzzer: " + valBuzzer;
            txtLED.text = "LED: " + valLED;
            txtMotor.text = "Motor DC: " + valMotor;
            txtPotensio.text = "Potensiometer: " + valPotensio;
            txtButton.text = "Push Button: " + valButton;

            txtKondisi.text = "Kondisi: " + valKondisi;
            txtPeminjam.text = "Peminjam: " + valPeminjam;
            txtStatus.text = "Status: " + valStatus;
            txtTanggal.text = "Tanggal: " + valTanggal;
            txtWaktu.text = "Waktu: " + valWaktu;

            // Contoh warna status
            if (valStatus.ToLower().Contains("dipinjam"))
                txtStatus.color = Color.red;
            else
                txtStatus.color = Color.green;

            isDataUpdated = false;
        }
    }

    void OnDestroy()
    {
        if (dbReference != null)
        {
            dbReference.Child("tukel").Child("koper").ValueChanged -= HandleValueChanged;
        }
    }
}