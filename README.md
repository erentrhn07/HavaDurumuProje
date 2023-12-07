# HavaDurumuProje

Bu C# programı, anlık hava durumunu ve o günden sonraki 3 günün hava durumunu tahmin edip konsol ekranına yazdırır. Program Microsoft Visual Studio’da yapılmıştır.

1)WeatherData.cs : Hava durumu verilerini depolamak için kullanılır ve dış bir API'den alınan verilerin işlenmesi için kullanılır. Hava durumu bilgilerini taşır.

2)ForecastData.cs : Genellikle birden fazla gün için hava durumu tahminleri alındığında bu tahminlerin her birini temsil etmek için kullanılır. WeatherData sınıfı içindeki Forecast özelliği aracılığıyla gelecekteki günler için ayrıntılı tahmin bilgilerini tutmak amacıyla kullanılır.

3)Program.cs : Hava durumu verilerini çekmek ve bu verileri belirli şehirler için ekrana yazdırmak amacıyla oluşturulmuş bir konsol uygulamasını temsil ediyor. Program, dışarıdan bir API olan "https://goweather.herokuapp.com/weather/" adresine HTTP istekleri gönderir, belirli şehirlerin anlık hava durumu bilgilerini alır ve kullanıcıya sunar. Kullanıcı, bu şehirler için anlık hava durumu bilgisini ekranda görebilir. 
