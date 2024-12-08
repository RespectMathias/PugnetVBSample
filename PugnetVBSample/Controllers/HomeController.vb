Imports Microsoft.AspNetCore.Mvc
Imports PugnetVBSample.Models

Namespace Controllers
    Public Class HomeController : Inherits Controller

        Public Function Index() As IActionResult
            Return View()
        End Function

        Public Function Privacy() As IActionResult
            Return View()
        End Function

        <ResponseCache(Duration:= 0, Location:= ResponseCacheLocation.None, NoStore:= True)>
        Public Function[Error]() As IActionResult
            Return View(New ErrorViewModel With {.RequestId = If(Activity.Current?.Id, HttpContext.TraceIdentifier)})
        End Function
    End Class

End Namespace