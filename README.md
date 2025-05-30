# 🎬 IMDB Film Listesi Uygulaması

Bu küçük konsol uygulaması, kullanıcıdan sınırsız sayıda film adı ve IMDB puanı alarak bir film listesi oluşturur. Uygulama, kullanıcı film eklemeyi bıraktığında bazı filtrelemeler yaparak sonuçları listeler.

---

## 🚀 Özellikler

- Kullanıcıdan film adı ve IMDB puanı alma
- Filmleri bir `List<Movie>` içinde saklama
- Kullanıcı her filmden sonra devam etmek isteyip istemediğini seçebilir
- Uygulama sonunda 3 liste sunar:
  1. **Tüm filmler**
  2. **IMDB puanı 4 ile 9 arasında olan filmler**
  3. **Adı 'A' harfiyle başlayan filmler**

---

## 📦 Kullanılan Yapılar

- `Movie` sınıfı:
  - `Name` → Film adı (string)
  - `ImdbScore` → IMDB puanı (double)
- `List<Movie>` → Film nesnelerini dinamik olarak tutmak için
- `while`, `if`, `foreach` gibi temel kontrol yapıları
- `StartsWith` yerine `Name[0] == 'A' || 'a'` gibi karakter karşılaştırması

---

## 🧠 Başlangıç Seviyesi İçin Uygun

Bu proje:
- Sınıf (class) kullanımı
- Liste yapısı (`List<T>`)
- Döngüler ve kullanıcı girişi
- Basit filtreleme işlemleri

konularını öğrenmek isteyenler için uygundur.

---
