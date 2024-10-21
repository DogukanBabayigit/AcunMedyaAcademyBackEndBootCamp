//Buradaki tüm kodlar aslında Main metodunun içindeler.
var builder = WebApplication.CreateBuilder(args);//Bir web application oluşturucu yaratılıyor.

// Bu satırla bu uygulamanın bir MVC uygulaması olacağı bildiriliyor.
builder.Services.AddControllersWithViews();

var app = builder.Build();//Bir web application(MVC) oluşturuluyor.

// Bu aşamadan run yapılana kadar olan kısımda gelen istekler yapılandırılıyor.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();//http üzerinden gelen istekleri https'e yönlendirir
app.UseStaticFiles();//wwwroot klasörünün kullanılabilir olmasını sağlar

app.UseRouting();//Gelen isteklerin hangi controller'a gitmesi gerektiğini belirler

app.UseAuthorization();//Yetkilendirme özelliklerini aktif kılar

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //https://localhost:5100/Home/Index
    //https://localhost:5100/Home
    //https://localhost:5100
    //https://localhost:5100
    //https://localhost:5100
    //https://localhost:5100
    //https://localhost:5100

app.Run();//Oluşturulan web application çalıştırılıyor.
