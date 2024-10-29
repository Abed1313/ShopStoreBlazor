using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopStore.Client;
using ShopStore.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ShoppingCartService>();
builder.Services.AddScoped<ReviewService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<OrderItemService>();
builder.Services.AddScoped<PaymentService>();
builder.Services.AddScoped<CartItemService>();






await builder.Build().RunAsync();
