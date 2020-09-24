Bu projede, herhangi iki string değişkenin birinin permütasyonun diğerinin içerisinde olup olmadığı çözümlenmiştir. 

Aldığımız ilk parametre mainText olarak geçmekte ve aramanın yapılacağı merkez yazı dizisini oluşturmaktadır. İkinci parametre ise pattern olarak isimlendirilmiş olup mainText içerisinde herhangi bir permütasyonunun olup olmadığı araştırılır.

Yöntem olarak öncelikle gelen iki string parametre karakter dizisine dönüştürüldü. Ardından elimizde olan iki adet karakter dizisi kendi içlerinde sıralandırıldı. Permütasyonunun olup olmadığı bulunacağı için minimum bir adet permütasyonunun olması yeterliydi. Bu sebeple ilk sıralanma durumundaki pattern ile işlemler yapılabildi. mainText dizisi içerisinde sıralanmış pattern dizisine ait bir karakter varsa ve bu pattern e ait karakterler sırayla mainText içerisinde bulunuyorsa eşleşme tamamlanmış oldu ve geriye true değeri döndürüldü. Diğer işlemlerde geriye dönen değer false oldu.
