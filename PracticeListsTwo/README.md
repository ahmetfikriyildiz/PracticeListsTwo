# Kahve Listesi Konsol Uygulaması

Bu uygulama, kullanıcıdan kahve adlarını alarak bir listeye ekler ve ardından bu listeyi ekrana yazdırır. Kullanıcı, 5 adet kahve ismi girdikten sonra tüm kahvelerin listesi ekrana yazdırılır.

## Özellikler

- Kullanıcıdan ardışık olarak kahve adlarını alma
- Girilen kahve adlarını bir listeye ekleme
- 5 kahve ismi girildikten sonra tüm kahvelerin listesini ekrana yazdırma


Kullanım

Program çalıştığında, kullanıcıdan 5 adet kahve adı istenir.
Her kahve adı girildikten sonra Enter tuşuna basılır.
5 kahve ismi girildiğinde, tüm kahvelerin listesi ekrana yazdırılır.
Kod Açıklaması

List<string> list = new List<string>();: Kullanıcının girdiği kahve adlarını tutmak için bir liste oluşturur.
for döngüsü: 5 kez çalışarak her seferinde kullanıcıdan kahve adı alır ve listeye ekler.
foreach döngüsü: Listedeki tüm kahve adlarını ekrana yazdırır.