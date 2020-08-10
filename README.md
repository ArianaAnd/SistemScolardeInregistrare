# SistemUniversitardeInregistrare
The school registration system is an application made with Visual C # and Microsoft SQL Server.


What I used in the project:

1. MaterialSkin -> NuGet Packages Manager (MaterialSkin library for adding a theming to .NET WinForms, C# or VB.Net with Google's Material Design Principles. This library follows the guidelines defined in the material design specification and use the same components and functionalities.)
2. Databases - Microsoft SQL Server => tables
                                       procedures
                                       inner joins etc.
3. Extensions: Microsoft RDLC Reports
               Microsoft.ReportingServices.ReportViewerControl.Winforms
               Microsoft.ReportingViewer.Commonv12 -> NuGet Packages
               
               Reports - export excel/pdf
               
               
4. Databases Connection
 public Connect()
        {
            connect = new SqlConnection("Data Source=LAPTOP; Initial Catalog=SistemScolar; Integrated Security=True");
        }


Some images from Project
![SQL](https://github.com/ArianaAnd/SistemScolardeInregistrare/blob/master/SQL.png)
