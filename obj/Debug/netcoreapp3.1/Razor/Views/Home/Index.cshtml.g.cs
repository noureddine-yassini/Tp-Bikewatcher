#pragma checksum "C:\Users\HP\source\repos\MvcMovie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774a661eef10af4915030a62c7b0086398e6ac6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\source\repos\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774a661eef10af4915030a62c7b0086398e6ac6d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\source\repos\MvcMovie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
        <h1 class=""display-4"">Yassini Noureddine</h1>
        </div>
        <div class=""text-center"">
            1- Avoir une application ASP.Net Core de base nommée ""BikeWatcher"" qui tourne sur sa machine
            Démarrer un site avec asp dotnet core :
        </div>
        <div class=""text-center"">
            2-Créer un repository public sur github, bitbucket ou gitlab pour héberger votre code.
        </div>

        <div class=""text-center"">
            3-Publier votre code sur le repository à chaque avancée
        </div>

        <div class=""text-center"">
            4- Supprimer du menu les pages de bases pour 2 liens de menu fonctionnels vers les pages vides suivantes : ""Accueil"", ""Liste des stations"", ""Carte"", ""Mes favoris""
        </div>

        <div class=""text-center"">
            5-Compléter la pages ""Accueil"" pour présenter votre travail, votre nom/prenom, cette liste d'objectifs (que vous rayerez au fur et à mesure) et l'URL où votre co");
            WriteLiteral(@"de source est visible


        </div>



        <div class=""text-center"">
            6- Se brancher sur l'API VeloV du grand Lyon pour récupérer les données en temps réel
            -API OpenData du Grand Lyon :
            -re des données issues d'un flux JSON :
        </div>




        <div class=""text-center"">
            7- Afficher les données de l'API sous forme de tableau sur la page ""Liste des stations"" (les stations sont triées par ordre alphabétique)
            Razor Cheat sheet :

        </div>

        <div class=""text-center"">
            8-Afficher les données de l'API sous forme de carte sur la page ""Carte"" (chaque station sera représentée par une épingle à son emplacement)
            Intégrer une carte openstreet map sur un site :
        </div>

        <div class=""text-center"">
            9-jouter sur caque épingle de la carte la possibilité de cliquer pour afficher une infobulle qui indiquera le nombre de vélos et de places à la station en question
   ");
            WriteLiteral(@"     </div>

        <div class=""text-center"">
            10-  Ajouter la possibilité de créer un compte utilisateur sur votre application
        </div>

        <div class=""text-center"">
            11-  Ajouter sur la page ""Liste des stations"" et/ou ""Carte"" la possibilité de rajouter des stations en favoris
        </div>

        <div class=""text-center"">
            12-Compléter la page ""Mes favoris"" pour n'afficher sous forme de tableau que les stations marquées en favoris
        </div>


        <div class=""text-center"">
            13- Stocker les stations favorites dans une base SQL
            Prise en main d'EF Core dans une application web MVC
        </div>


        <div class=""text-center"">
            14-  Centrer automatiquement la carte par rapport à la position de l'utilisateur
            Récupérer la position de l'utilisateur
        </div>


        <div class=""text-center"">
            15- Trier automatiquement la liste des stations par rapport à la positio");
            WriteLiteral(@"n de l'utilisateur
        </div>



        <div class=""text-center"">
            16-rendre votre application bilingue Français / Anglais
        </div>

        <div class=""text-center"">
            17-Rendre votre application utilisable à la fois pour la ville de Lyon et la ville de Bordeaux (par exemple un bouton permettra de passer de l'un à l'autre dans le menu)
            Une API affichant les données pour la ville de Bordeaux

            <div class=""text-center"">
                18- Déployer votre code sur un serveur accessible publiquement en consultation
                Déployer une application ASP.Net Core sur un serveur Debian :
            </div>

            <div class=""text-center"">
                19- rmettre aux utilisateurs de signaler un vélo en panne

                <div class=""text-center"">
                    20-Faire en sorte que votre site soit agréable à utiliser sur mobile (il ne doit pas comporter ascenseur horizontal)
                </div>

            ");
            WriteLiteral("    <div class=\"text-center\">\r\n                    21-BONUS : toute fonctionnalité supplémentaire sera valorisée, pensez-juste à l\'indiquer sur votre page d\'accueil que je puisse la comptabiliser\r\n\r\n                </div>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
