# Detail Example

> Factory Pattern berguna ketika kita ingin membuat objek tanpa harus tahu detail implementasi atau kelas konkretnya. Hal ini memungkinkan kita untuk menggunakan abstraksi dalam pembuatan objek, sehingga memudahkan dalam mengganti implementasi objek tanpa harus merubah banyak bagian dari kode yang sudah ada.

Contoh sederhana ilustrasi perbedaan antara penggunaan `Television tv = new Television();` langsung dan penggunaan **Factory Pattern**.

Misal kita punya 2 kelass yang implementasi interface `IElectronicDevice`: yaitu class `Television` dan `Radio`:

```csharp
interface IElectronicDevice
{
    void On();
    void Off();
    void VolumeUp();
    void VolumeDown();
}

class Television : IElectronicDevice
{
    public void On() { Console.WriteLine("TV is On"); }
    public void Off() { Console.WriteLine("TV is Off"); }
    public void VolumeUp() { Console.WriteLine("TV Volume Up"); }
    public void VolumeDown() { Console.WriteLine("TV Volume Down"); }
}

class Radio : IElectronicDevice
{
    public void On() { Console.WriteLine("Radio is On"); }
    public void Off() { Console.WriteLine("Radio is Off"); }
    public void VolumeUp() { Console.WriteLine("Radio Volume Up"); }
    public void VolumeDown() { Console.WriteLine("Radio Volume Down"); }
}

```

Kalau kita gunakan `Television tv = new Television();` langsung, kita buat objek `Television` secara langsung:

```csharp
class Program
{
    static void Main()
    {
        Television tv = new Television();
        // Operasikan TV
        tv.On();
        tv.VolumeUp();
        tv.Off();
    }
}
```

sama hal nya kalau misal mau implementasi radio. maka perlu buat objek `Radio` secara langsung:

```csharp
class Program
{
    static void Main()
    {
        Radio rad = new Rad();
        // Operasikan Radio
        rad.On();
        rad.VolumeUp();
        rad.Off();
    }
}
```

-----

Jika kita menggunakan **Factory Pattern** untuk buat objek `IElectronicDevice`:

```csharp
class TVRemote
{
    public static IElectronicDevice GetDevice(string deviceType)
    {
        switch (deviceType)
        {
            case "Television":
                return new Television();
            case "Radio":
                return new Radio();
            default:
                throw new ArgumentException("Unknown device type");
        }
    }
}

class Program
{
    static void Main()
    {
        IElectronicDevice device = TVRemote.GetDevice("Television");
        // Operasikan perangkat
        device.On();
        device.VolumeUp();
        device.Off();
    }
}

```

Kalau misal kita mau ganti ke radio, tinggal ganti 1 baris aja menjadi: `IElectronicDevice device = TVRemote.GetDevice("Radio");`


> Dalam contoh tersebut, kita menggunakan Factory Pattern dengan metode `GetDevice` untuk membuat objek `IElectronicDevice`. Dengan pendekatan ini, kita dapat dengan mudah mengganti perangkat yang ingin kita gunakan hanya dengan mengubah parameter yang dilewatkan ke `GetDevice`, tanpa harus merubah kode yang digunakan untuk mengoperasikan perangkat.

<br>

[Factory Pattern Article](https://refactoring.guru/design-patterns/factory-method)


[<- back](https://github.com/QuackPlayground/csharp/blob/main/theory/basic/22.md)
[continue ->](https://github.com/QuackPlayground/csharp/blob/main/theory/basic/23.md)