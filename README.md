# GameProjectRecapDemo1
Layered structure intro

* Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz.

                                            ----Gereksinimler-----

Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

Satışlarda kampanya entegrasyonunu simule ediniz.

iki katmanlı yapı olarak öğrenip yapmaya çalıştım 
katmanlar:

1.Entities : Varliklarin bulundugu kisimlar

2.Business : Is katmaninin oldugu kisimlar

Her katmanda ise soyut işlemleri tanımlamak için Abstract, somut işlemleri tanımlamak için Concrete klasörü bulunmaktadır

Entities:

Bu katmanın soyut kısmında tüm varlıkların referansını tutabilecek bir IEntity interface' i; somut kısmında ise oluşturulacak oyunlar için Game, Kişiler için Person, Oyuncular için Player class'ları bulunmakta.

Business:

Bu katman Abstract (soyut) kısım, Concrete (somut) kısım ve ValidationRules (dogrulama Kuralları) olmak üzere üç bölümden oluşmaktadır.

Soyut kısımdaki IEntitiyService interface' i, somut kısımda bulunan GameManager.cs ve PlayerManager.cs' in referanslarını tutmak ve eş görevleri paylaştırmak üzere üretilmiştir.

PlayerManager.cs' de bulunan ekleme metodunda mernis validasyon simülasyonu yapılmıştır.

 SalesSerice interface'sinde bulunan kampanya indirimlerine Sales kisminda yer verilmiştir.

Ayrıca Concrete bölümünde bulunan Platforms bölümünde, çeşitli oyun dağıtım platformlarına yer verilmiştir.
