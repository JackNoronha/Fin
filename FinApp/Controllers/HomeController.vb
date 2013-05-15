Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to ASP.NET MVC!"
        Return View()
        'teste de novo
    End Function

    Function About() As ActionResult
        Return View()
    End Function
End Class
