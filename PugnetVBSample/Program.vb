Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Pugnet

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)

        ' Add services to the container.
        builder.Services.AddControllersWithViews().AddPug()

        Dim app = builder.Build()

        ' Configure the HTTP request pipeline.
        If Not app.Environment.IsDevelopment() Then
            app.UseExceptionHandler("/Home/Error")
            app.UseHsts()
        Else
            app.UseDeveloperExceptionPage()
        End If

        app.UseHttpsRedirection()
        app.UseStaticFiles()
        app.UseRouting()
        app.UseAuthorization()

        app.MapControllerRoute(
            name:= "default",
            pattern:= "{controller=Home}/{action=Index}/{id?}")

        app.Run()
    End Sub
End Module