Random butonu tıklandığında aralığı kullanıcı tarafından belirlenecek rastgele 30 sayı butonların üzerine yazdırılmalıdır.

Başlangıç noktası olacak buton kullanıcı tarafından tıklanarak seçildiğinde; seçilen butonun 4-lü komşuluğundaki (alt, üst, sağ, sol) butonlardan en yüksek değere sahip olan butona doğru hareket edilecektir. Hareket edilen butonun arka plan rengi beyaz yapılır ve bu işlem hareket edecek bir buton kalmayıncaya kadar devam edecektir.

Bir kez ziyaret edilen buton tekrar ziyaret edilemez. Diğer bir ifadeyle arka plan rengi beyaz olan buton ziyaret edilemez. Son ziyaret edilen butonun arka plan rengi siyah olarak ayarlanacaktır.

Bu işlemi yerine getirmek için döngü ve dizi kullanılmadan, buton ID’sini parametre alan özyinelemeli (recursive) bir metot tasarlayınız.
