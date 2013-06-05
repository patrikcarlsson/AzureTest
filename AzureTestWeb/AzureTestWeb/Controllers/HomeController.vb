Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Patrik tests Azurecccc"

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Azure test"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Patrik Carlsson"

        Return View()
    End Function
End Class
