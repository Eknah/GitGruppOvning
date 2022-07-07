var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

Console.WriteLine("Welcome to Git i grupp! Grupp 2! Happy coding!");
	Console.WriteLine("Welcome to Git i grupp! Grupp 2! Happy coding!");

//Hej
app.Run();


Console.WriteLine("Hej från Andreas! Merge conflicts");
Console.WriteLine("Merge conflicts!");
Console.WriteLine("Hej hej från Jimmy");
Console.WriteLine("Hej från Andreas! Igen");
Console.WriteLine("Test");

Console.WriteLine("Personlig ändring i Andreas branch");

int a = 10;
int b = 20;
//test2 från Farzin
string firstName = "Jimmy";