# Try-Catch Kullanıcı Girişi Uygulaması

Bu basit C# konsol uygulaması, kullanıcıdan sayı girişi alır ve girilen sayının karesini hesaplayarak ekrana yazdırır. Kullanıcı geçersiz bir giriş (örneğin harf veya sembol) yaparsa, `try-catch` yapısı kullanılarak hata yakalanır ve kullanıcı uygun bir mesajla bilgilendirilir.

## Özellikler

- Kullanıcıdan sayı girişi istenir.
- Girilen sayı geçerliyse karesi hesaplanır ve ekrana yazdırılır.
- Geçersiz giriş durumunda hata mesajı gösterilir.
- Kullanıcı doğru bir sayı girene kadar işlem tekrarlanır.

## Kullanım

1. Uygulamayı başlatın.
2. Konsolda "Lütfen bir sayı girin:" mesajını göreceksiniz.
3. Bir tam sayı girin.
   - Örnek giriş: `5`
   - Çıktı: `Sayının karesi: 25`
4. Eğer sayı yerine harf veya sembol gibi geçersiz bir ifade girerseniz:
   - Çıktı: `Geçersiz giriş! Lütfen bir sayı giriniz.`
