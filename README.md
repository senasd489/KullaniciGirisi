# ERP Sipariş ve Stok Yönetimi

C# ve Windows Forms ile geliştirilmiş, kullanıcı girişi, sipariş, stok ve raporlama modüllerini içeren bir ERP masaüstü uygulaması. Staj sürecimde geliştirdiğim bir projedir.

## Özellikler

- **Kullanıcı girişi:** Kullanıcı adı ve şifre ile sisteme giriş
- **Kullanıcı işlemleri:** Kullanıcı ekleme, güncelleme, silme ve listeleme; yetki düzeyi ve aktiflik durumu yönetimi
- **Sipariş işlemleri:** Cari, sipariş türü, siparişi alan, fiyat listesi, lot no, etiket no gibi bilgilerle sipariş ve sipariş detayı girişi
- **Stok işlemleri:** Stok kartı tanımlama (genel bilgiler, finans bilgileri, koleksiyon kodları, bileşenler, müşteri rotaları, stok türleri)
- **Sipariş raporları:** Filtrelenebilir sipariş listesi ve FastReport ile yazdırılabilir/PDF'e aktarılabilir raporlar
- **Seçim pencereleri:** Cari no, stok adı, lot no, sipariş no, etiket no gibi alanlar için arama/seçim formları

## Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---|---|
| C# / .NET Framework 4.7.2 | Uygulama dili ve çatısı |
| Windows Forms | Masaüstü arayüz |
| Entity Framework 6 (Database First) | Veritabanı erişimi |
| Microsoft SQL Server | Veritabanı |
| FastReport Open Source | Raporlama ve PDF çıktısı |

## Proje Yapısı

```
KullaniciGirisi/
├── Frm_GirisEkrani.cs           # Giriş ekranı
├── Frm_AnaMenu.cs               # Ana menü
├── Frm_KullaniciIslemleri.cs    # Kullanıcı yönetimi
├── Frm_SiparisGirisi.cs         # Sipariş girişi
├── Frm_StokIslemleri.cs         # Stok kartı işlemleri
├── Frm_SiparisRaporlari.cs      # Sipariş raporları
├── Frm_*Secenekler.cs           # Seçim / arama pencereleri
├── RaporlarModels/              # Rapor ve filtre modelleri
├── Model01.edmx                 # ERP veritabanı modeli (EF)
├── Model1.edmx                  # Kullanıcı giriş veritabanı modeli (EF)
└── BasitSiparisRaporu.frx       # FastReport rapor şablonu
```

## Kurulum

1. Repoyu klonlayın:
   ```bash
   git clone https://github.com/senasd489/KullaniciGirisi.git
   ```
2. `KullaniciGirisi.slnx` dosyasını Visual Studio ile açın.
3. NuGet paketlerini geri yükleyin (Solution'a sağ tık → **Restore NuGet Packages**).
4. SQL Server'da `ERP` ve `KullaniciGirisSistemi` veritabanlarını oluşturun.
5. Gerekirse `App.config` içindeki bağlantı cümlelerini kendi sunucunuza göre düzenleyin (varsayılan: yerel sunucu, Windows kimlik doğrulaması).
6. Projeyi çalıştırın (**F5**).

## Ekran Görüntüleri

<!-- Ekran görüntülerini "screenshots" klasörüne ekleyip aşağıdaki satırları açabilirsiniz -->
<!-- ![Giriş Ekranı](screenshots/giris.png) -->
<!-- ![Sipariş Girişi](screenshots/siparis.png) -->

## Geliştirici

**Sena Sadık** · Yazılım Mühendisliği Öğrencisi · [GitHub](https://github.com/senasd489)
