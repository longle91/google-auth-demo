using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DbContext>(options => options.UseSqlServer());
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DbContext>().AddDefaultTokenProviders();
builder.Services.AddAuthentication()
        .AddGoogle(opts =>
        {
            opts.ClientId = "430525621940-uoo3c45fdqukl4s2nlvq5jae03c4n800.apps.googleusercontent.com";
            opts.ClientSecret = "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";
            opts.SignInScheme = IdentityConstants.ExternalScheme;
        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();

app.Run();
