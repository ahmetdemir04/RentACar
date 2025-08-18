# Araç Kiralama Otomasyonu

Rent a Car Otomasyonu
Bu proje, Windows Forms tabanlı bir araç kiralama otomasyonudur. Araç ekleme ve listeleme, müşteri ekleme ve listeleme, sözleşme oluşturma ve biten sözleşmeleri görüntüleme gibi temel işlevleri içerir. Basit ama işlevsel bir yapıyla araç kiralama süreçlerini kolayca yönetmeyi amaçlamaktadır.

<!-- Programın çalışır halde bulunan video: -->

# Proje Veritabanının Kurulumu ve Yapılandırılması

<p>Uygulamanın veritabanını kendi SQL Server Management Studio ortamınıza eklemek için aşağıdaki adımları takip ediniz:</p>
1. SQL Server Management Studio'yu açınız. <br>
2. Sol kısımdaki Databases bölümüne sağ tıklayarak Import Data-tier Application seçeneğine tıklayınız.<br>
3. Açılan sihirbazda Next butonuna tıklayarak devam ediniz.<br>
4. Proje klasörüne gidip database klasörünü içerisindeki .dacpac dosyasını seçip içeri aktarma işlemini tamamlayınız.<br>
5. Ardından Visual Studio ortamında ClsConnection isimli sınıf dosyasını açınız.<br>
6. Seçtikten sonra açık olan tüm panelerde okay, okay diyerek database kurunuz. <br>
7. Bu sınıf içerisindeki Constring (bağlantı dizesi) alanını, kendi veritabanınızın bağlantı yoluna göre güncelleyiniz. <br>

<p> Belirtilen adımları eksiksiz uyguladığınız takdirde proje sorunsuz bir şekilde çalışacaktır.</p>

## Dasboard Sayfası

![img](Images/dashboard.png)

## Müşteri Kayıt Sayfası

![img](Images/customer.png)

## Müşteri Listeleme Sayfaı

![img](Images/customer_list.png)

## Araba Ekleme Sayfası

![img](Images/car_add.png)

## Araba Listeleme Sayfası

![img](Images/car_list.png)

## Kontrat Ekleme Sayfası

![img](Images/contract.png)

## Bitmiş Kontrat Listeleme Sayfası

![img](Images/finished_contract.png)

## Ödeme Paneli

![img](Images/payment.png)

## Hızlı Erişim Araç Listesi

![img](Images/short_car_list.png)
