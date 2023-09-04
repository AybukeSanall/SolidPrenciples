# SOLİD PRENSİPLERİ

### Single Responsibility Prenciple (Tek sorumluluk Prensibi)

Tek Sorumluluk Prensibi (SRP), nesne yönelimli programlamada bir sınıfın yalnızca bir sorumluluğa odaklanması gerektiğini vurgulayan bir tasarım ilkesidir.

### Open-Closed Principle (Açık Kapalı Prensibi)
"Yazılım birimleri (sınıflar, modüller, fonksiyonlar vb.) değişikliklere kapalı, ancak uzantılara açık olmalıdır."
    
Bu prensip, mevcut kodu değiştirmeden yeni davranışları veya özellikleri eklemek için tasarımın genişletilebilir olması gerektiğini belirtir. 

### Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
"Herhangi bir alt sınıf, üst sınıfın yerine geçebilmeli ve beklenen davranışları sağlamalıdır."

LSP, nesne yönelimli programlamada bir tasarım ilkesidir ve türetilmiş (alt) sınıfların, temel (üst) sınıfların yerine kullanılabilecek ve aynı davranışı sergilemesi gerektiğini vurgular. Bu ilke, kodun daha güvenilir ve tutarlı olmasını sağlar, çünkü bir türün yerine başka bir tür kullanıldığında beklenmeyen davranışlarla karşılaşmamızı engeller.

### Interface Segregation Principle (Arayüz Ayrım Prensibi)
Bir sınıfın, ihtiyaç duymadığı yöntemlere veya özelliklere bağlı olmaması gerekir. Büyük ve genel arayüzler yerine, spesifik ve küçük arayüzler tercih edilmelidir."

ISP, nesne yönelimli programlamada bir tasarım ilkesidir ve bir sınıfın yalnızca kendi ihtiyaçlarına uygun olan arayüzleri uygulaması gerektiğini vurgular. Bu sayede sınıflar gereksiz bağımlılıklardan kaçınır, daha az karmaşık ve daha bakımı kolay hale gelir. 

### Dependency Inversion Principle(Bağımlılığın Tersine Çevrilmesi Prensibi)
"Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı olmamalıdır. Her iki seviye de soyutlamalara bağlı olmalıdır."

DIP, nesne yönelimli programlamada bir tasarım ilkesidir ve yazılımın düşük seviyeli modüllerinin yüksek seviyeli modüllere bağımlı olmamasını, her iki seviyenin de soyutlamalara (arayüzler, abstract sınıflar) bağlı olması gerektiğini vurgular.
