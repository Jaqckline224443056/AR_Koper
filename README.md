# 📦 AR-Based Teaching Aid Monitoring System

## 📖 Overview

Proyek ini merupakan sistem monitoring komponen **Teaching Aid Kit berbasis Augmented Reality (AR)** yang terintegrasi dengan **Firebase Realtime Database**.

Sistem ini memungkinkan pengguna untuk melihat informasi kondisi alat praktikum secara **real-time dan interaktif** hanya dengan mengarahkan kamera smartphone ke **AR marker** pada koper teaching aid.

Dengan memanfaatkan teknologi AR, objek fisik dapat menampilkan informasi digital secara langsung, sehingga meningkatkan efisiensi dan pengalaman dalam penggunaan alat praktikum.

---

## 🚀 Features

* 📡 Menampilkan **nama peminjam alat secara real-time**
* 🔍 Monitoring kondisi komponen:

  * LED
  * Motor DC
  * Motor Stepper
  * Sensor
  * Modul mikrokontroler
* 🧠 Visualisasi data dalam bentuk:

  * Floating Text
  * UI Panel
  * Objek 3D
* ☁️ Sinkronisasi otomatis dengan Firebase
* 📱 Integrasi antara aplikasi mobile dan AR

---

## 👥 Team Members

* **Jaqckline Yesyuruniwati** – Unity Developer
* **Mutia Saladina Daryono** – 3D Modeling
* **Ramanda Nizar Firdaus** – Unity Developer
* **Hassyfa Eka Putri** – Mobile App & Database

---

## 🎯 Purpose

Sistem ini dikembangkan untuk:

* ⚡ Meningkatkan efisiensi pencatatan inventaris
* 🔎 Memberikan transparansi kondisi alat
* ⏱️ Monitoring data secara real-time
* 🧪 Mendukung modernisasi laboratorium berbasis teknologi AR & Cloud

---

## 🏗️ System Architecture

Sistem ini terdiri dari 3 bagian utama:

### 1. Input (Mobile App - Kodular)

Admin menginput data seperti:

* Nama peminjam
* Status komponen

### 2. Database (Firebase)

Data disimpan dalam format JSON di Firebase Realtime Database dan dapat diakses secara real-time.

### 3. Visualization (Unity AR)

* Kamera mendeteksi marker
* Data diambil dari Firebase
* Informasi ditampilkan dalam bentuk AR

---

## 🔄 How It Works

1. Admin menginput data melalui aplikasi mobile
2. Data dikirim ke Firebase
3. Kamera AR mendeteksi marker pada koper
4. Unity mengambil data terbaru
5. Informasi muncul secara langsung di atas objek

---

## 📍 Implementation

* 📥 Input Data: Aplikasi mobile (Kodular)
* 🗄️ Storage: Firebase Realtime Database
* 👁️ Output: Aplikasi AR (Unity)
* 📍 Lokasi penggunaan:

  * Laboratorium
  * Ruang praktikum
  * Ruang kelas

---

## ⏰ Usage Scenario

* Saat peminjaman alat
* Saat pengembalian alat
* Saat pengecekan rutin
* Saat maintenance komponen

Data akan otomatis diperbarui dan langsung tampil di aplikasi AR.

---

## 🛠️ Technologies Used

* Unity (Augmented Reality)
* Firebase Realtime Database
* Kodular (Mobile App Builder)
* AR Marker Tracking

---

## 💡 Future Improvements

* Integrasi notifikasi kerusakan
* Dashboard monitoring berbasis web
* Peningkatan visualisasi 3D
* Sistem login user

---

## 📌 Conclusion

Dengan menggabungkan teknologi **Augmented Reality** dan **Cloud Computing**, sistem ini mampu mengubah metode monitoring alat praktikum menjadi lebih **interaktif, efisien, dan modern**.

---
