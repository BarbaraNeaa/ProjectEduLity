README - EduLity Installation Guide

Halooo!
Selamat datang di EduLity! Berikut adalah panduan instalasi yang (semoga) bisa membantu Bapak / teman-teman menjalankan aplikasi EduLity.

Persyaratan Sistem:
- Sistem Operasi: Windows 10, macOS, atau Linux
- .NET Framework 4.7.2 atau versi lebih baru
- PostgreSQL Database

Langkah-langkah Instalasi:

1. Unduh Kode Sumber
   - Unduh ZIP file dari repositori EduLity atau dapatkan dari sumber yang sesuai.
   - Link GitHub kami https://github.com/BarbaraNeaa/ProjectEduLity.git 

2. Ekstrak ZIP File
   - Ekstrak konten ZIP file ke lokasi yang diinginkan di komputer Anda.

3. Persiapan Database
   - Pastikan PostgreSQL telah diinstal di sistem Anda.
   - Buatlah database baru dengan nama "Demo" atau sesuai keinginan Anda.
   - Pastikan untuk mengganti parameter koneksi database di file konfigurasi sesuai dengan pengaturan PostgreSQL Anda.

4. Konfigurasi Koneksi Database
   - Buka file konfigurasi aplikasi, seperti `appsettings.json`.
   - Temukan dan atur parameter koneksi database seperti `Server`, `Port`, `User Id`, `Password`, dan `Database` sesuai dengan pengaturan PostgreSQL Anda.

5. Build Aplikasi
   - Buka terminal atau command prompt di direktori proyek EduLity.
   - Jalankan perintah `dotnet build` untuk membangun aplikasi.

6. Jalankan Aplikasi
   - Setelah pembangunan selesai, jalankan aplikasi dengan perintah `dotnet run`.

7. Akses Aplikasi
   - Buka browser web dan akses aplikasi melalui URL `http://localhost:5000` atau sesuai dengan port yang diatur.

8. Register dan Login
   - Gunakan FirstForm untuk login atau registrasi sebagai pengguna baru.

9. Jelajahi Aplikasi
   - Setelah login, Anda dapat menjelajahi berbagai fitur, termasuk mengisi pertanyaan, melihat hasil rekap, dan membaca penjelasan.

CATATAN TAMBAHAN
- Pastikan firewall Anda memperbolehkan koneksi ke PostgreSQL.
- Jika ada masalah, periksa log aplikasi untuk mendapatkan informasi lebih lanjut.

Selamat menikmati pengalaman menggunakan EduLity! 

Silakan menghubungi Barbara apabila teman-teman / Bapak memiliki pertanyaan dalam bentuk apapun.

Barbara : wa.me/6285875891040
Thank you! :D
