#pragma checksum "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c10864bdda051e08b5b3a4b38cd986e1d0a2394"
// <auto-generated/>
#pragma warning disable 1591
namespace Testapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Testapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\greb_\Documents\Mein Scheiß\Projekte\Testapp\Testapp\_Imports.razor"
using Testapp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>


    #ausbildung {
        display: block;
        width: 100%;
        height: auto;
        margin-top: 25px;
        margin-bottom: 50px;
        border: 1px hidden;
        text-align: center;
        align-content: center;
    }
    table {
        list-style: none;
        text-align:center;
    }

    #logo {
        width: 295px;
        height: 70px;
        margin-bottom: 50px;
        padding: 0;
        margin: 0;
    }

    #ausbildungsstellen {
        margin-top: 50px;
        margin-bottom:50px;
        text-align:center;
    }
    .table-striped {
        width: 100%;
        text-align: center;
    }
    .a{
        color:black;
        text-emphasis:none;
    }
    a:hover{
        color:limegreen;   
    }
    h1, h2, h3, h4, h5, h6 {
        text-align: center;
        color: green;
    }
    #footer {
        width: 100%;
        height: 70px;
        background-color: green;
        color: white;
        text-align: center;
        padding: 20px;
        border-radius: 5px;
        font-family: 'Fira Sans', sans-serif;
        margin-top: 50px;
    }

   .down {
        color: white;
        text-decoration: none;
    }

    .down:hover {
            text-decoration: underline;
            color: white;
        }
    ul{
        list-style:none;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<header>
    <img id=""logo"" src=""https://th.bing.com/th/id/R.b5baaa940d6a2b16ab49de45ef8a45d1?rik=VJoMj2No9OeJ6g&riu=http%3a%2f%2fsar-anlagenbau.de%2fwordpress%2fwp-content%2fthemes%2fagency%2fthemify%2fimg.php%3fsrc%3dhttp%3a%2f%2fsar-anlagenbau.de%2fwordpress%2fwp-content%2fuploads%2fmontaplast.gif%26w%3d670%26h%3d&ehk=Ujue7pkoRRJE8m9Qcki%2bs9NFyHFH5Qp7r14H3lXAZcE%3d&risl=&pid=ImgRaw&r=0"">
</header>

");
            __builder.AddMarkupContent(2, "<h1>Ihre Karriere bei Montaplast</h1>\r\n<hr>\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, @"<section id=""ausbildung"">
    Wir bieten Ihnen ein breites Spektrum an Einsatzmöglichkeiten an unseren weltweiten Produktionsstandorten.<br>
    Um unseren Kunden weiterhin moderne und innovative Lösungen bieten zu können,
    benötigen wir verlässliche und <br>engagierte Mitarbeiter in den unterschiedlichsten Bereichen und auf nahezu allen Hierarchieebenen.<br>
    Einen aktuellen Überblick über unsere offenen Stellen am Standort Morsbach finden Sie in der entsprechenden Rubrik. <br>
    Die Informationen zur Datenverarbeitung finden Sie in unseren Datenschutzhinweisen.<br>
    <b> Werden Sie Teil von Montaplast und stellen Sie sich interessanten Aufgaben! </b>

</section>

");
            __builder.AddMarkupContent(4, "<section id=\"ausbildungsstellen\">\r\n    <h3>Offene Ausbildungsstellen</h3>\r\n\r\n    Eine Ausbildung bei Montaplast bietet den perfekten Start in Ihre berufliche Zukunft.<br>\r\n    Bei uns erwartet Sie eine qualifizierte Ausbildung mit guten Zukunftsperspektiven – egal für welchen der 10 folgenden Ausbildungsberufe Sie sich entscheiden:<br>\r\n    <br>\r\n    <ul>\r\n        <li>- Auszubildende zum Elektroniker für Betriebstechnik (m/w)</li>\r\n        <li>- Auszubildende zum Fachinformatiker Anwendungsentwicklung (m/w)</li>  \r\n        <li>- Auszubildende zum Fachinformatiker Systemintegration (m/w)</li>\r\n        <li>- Auszubildende zur Fachkraft für Lagerlogistik (m/w)</li> \r\n        <li>- Auszubildende zum Fachlagerist (m/w)</li> \r\n        <li>- Auszubildende zum Industriekaufmann/-frau</li> \r\n        <li>- Auszubildende zum Industriemechaniker (m/w)</li> \r\n        <li> - Auszubildende zum Mechatroniker (m/w)</li>\r\n        <li>- Auszubildende zum Verfahrensmechaniker (m/w)</li> \r\n        <li>- Auszubildende zum Werkzeugmechaniker (m/w)</li>\r\n    </ul>\r\n    <p>\r\n\r\n        Derzeit genießen über 100 Auszubildende eine nach Ihren individuellen Stärken und Interessen ausgerichtete Berufsausbildung in unserem zertifizierten Ausbildungsbetrieb.<br>\r\n        Ein Prädikat für unsere sehr gute Ausbildung sind unsere jährlichen Auszeichnungen von der IHK als Anerkennung für herausragende Leistungen in der Berufsausbildung.<br>\r\n        <b>Gerne nehmen wir Ihre Bewerbung für folgende Ausbildungsberufe entgegen:</b>\r\n    </p>\r\n</section>\r\n");
            __builder.AddMarkupContent(5, "<div class=\"table-responsive\">\r\n    <table class=\"table table-striped table-hover\">\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=389\" target=\"_blank\">Auszubildende zum Elektroniker für Betriebstechnik (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=387\" target=\"_blank\">Auszublidende zum Fachinformatiker Anwendungsentwicklung (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=388\" target=\"_blank\">Auszublidende zum Fachinformatiker Systeminegration (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=390\" target=\"_blank\">Auszublidende zum Fachlageristen (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=386\" target=\"_blank\">Auszublidende zum Industriekaufmann (m/w/d) 2022 </a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=391\" target=\"_blank\">Auszubildende zum Industriemechaniker (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=392\" target=\"_blank\">Auszublidende zum Mechatroniker (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=393\" target=\"_blank\">Auszubildende zum Verfahrensmechaniker (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=394\" target=\"_blank\">Auszublidende zum Wergzeugmechaniker (m/w/d) 2022</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/auszubildende/stellenangebot-detail.html?no_cache=1&vac=395\" target=\"_blank\">Auszublidende zur Fachkraft für Lagerlogistik (m/w/d) 2022</a></td></tr>\r\n    </table>\r\n</div>\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(6, @"<section id=""ausbildungsstellen"">
   <h3>Fach- und Führungskräfte</h3>

  Montaplast bietet Fach- und Führungskräften interessante Aufgaben mit vielen Freiräumen eigene Ideen zu verwirklichen.
  Nutzen Sie die Möglichkeit und werden Sie Teil von Montaplast.
  Zur Verstärkung unseres Teams in Morsbach und Lichtenberg suchen wir Sie:

</section>
");
            __builder.AddMarkupContent(7, "<div class=\"table-responsive\">\r\n    <table class=\"table table-striped table-hover\">\r\n\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=206\" target=\"_blank\">Anwendungsentwickler (m/w/d)</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=384\" target=\"_blank\">Einkäufer (m/w/d) Produktionsmaterial - Zukaufteile</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=202\" target=\"_blank\">Mitarbeiter (m/w/d) Qualitätsvorausplanung</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=385\" target=\"_blank\">Systemadministrator (m/w/d) Microsoft Umfeld</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=383\" target=\"_blank\">Systemadministrator (m/w/d) Schwerpunkt Netzwerke</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=381\" target=\"_blank\">Systemadministrator (m/w/d) Werke Support</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=367\" target=\"_blank\">Teamleiter (m/w/d) Finanzbuchhaltung</a></td></tr>\r\n        <tr><td><a class=\"a\" href=\"https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/stellenangebot-detail.html?no_cache=1&vac=200\" target=\"_blank\">Teamleiter (m/w/d) Qualitätsvorausplanung</a></td></tr>\r\n    </table>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(8, @"<section id=""ausbildungsstellen"">
    <h3>Schüler & Studenten </h3>
    <p>
        Durch ein Praktikum bei Montaplast haben Schüler  und Studenten die Möglichkeit <br>
        erste praktische Erfahrungen zu sammeln und sich beruflich zu orientieren.<br>
        Unter Berücksichtigung der betrieblichen Einsatzmöglichkeiten kann das Praktikum in unterschiedlichen Geschäftsbereichen je nach Interessen, <br> 
        Neigungen und Studienschwerpunkten absolviert werden.<br>
        In der Schlussphase Ihres Studiums warten interessante Themenstellungen für die Abschlussarbeit auf Sie. <br>
        Bei Montaplast können Sie auf eine gute fachliche Betreuung zählen.<br>
       
    </p>
</section>

");
            __builder.AddMarkupContent(9, @"<section id=""ausbildungsstellen"">
    <h3>Produktionsmitarbeiter</h3>
    <p>
        In Abhängigkeit von der Auftragslage suchen wir für unseren Hauptstandort Morsbach regelmäßig befristet Mitarbeiter für die Produktion.<br>
        Folgendes Anforderungsprofil sollten Sie erfüllen:<br>
    </p>
    <p>

        Bereitschaft zum Einsatz im Mehrschichtbetrieb<br>
        Zuverlässigkeit<br>
        Qualitätsbewusstsein<br>
        Sorgfalt in der Arbeitsausführung<br>
        Deutschkenntnisse<br>
        Volljährigkeit<br>
    </p>
    <p>
        Schülern und Studenten bieten wir in der Haupturlaubszeit die Möglichkeit einer kurzfristigen Beschäftigung von mind. drei Wochen als Produktionsmitarbeiter an.<br>

        Wir freuen uns über Ihre Initiativbewerbung mittels Personalfragebogen, welchen Sie uns an unten stehende Adresse oder per E-Mail zukommen lassen können.<br>
        Bitte haben Sie Verständnis dafür, dass Sie von uns grundsätzlich keinen ablehnenden Bescheid erhalten.<br>
        Sollte sich in absehbarer Zeit die Möglichkeit für eine Zusammenarbeit ergeben, werden wir Sie kontaktieren.<br>
    </p>
    </section>
");
            __builder.AddMarkupContent(10, @"<section id=""ausbildungsstellen""> 
    <p>
        <h3>Bewerben</h3>
        Gerne nehmen wir auch Ihre Initiativbewerbung an unten stehende Anschrift, 
        E-Mail Adresse oder über unser <a href=""https://www.montaplast.com/de/job-karriere/fach-fuehrungskraefte/bewerberformular.html?vac=-1"" target=""_blank"" class=""a"">Bewerberportal</a> 
        entgegen.<br>

        Die Informationen zur Datenverarbeitung finden Sie in unseren 
        <a href=""https://www.montaplast.com/fileadmin/user_upload/datenschutz/Datenschutzhinweise_MONTAPLAST_BEWERBUNGEN.pdf"" class=""a"">Datenschutzhinweisen.</a>
        <hr>

        <b>Montaplast GmbH</b><br>
        - Personalwesen -<br>
        Krottorfer Str. 25<br>
        51597 Morsbach<br>
        Tel.: +49 (22 94) 691 0<br>
        Fax: +49 (22 94) 691 13 29<br>
        <strong> bewerbung(at)montaplast.com</strong><br>
    </p>
    
</section>
");
            __builder.AddMarkupContent(11, @"<footer id=""footer"">
    <a href=""#"" class=""down""> &copy; 2009-2016 Montaplast GmbH </a>|<a href=""#"" class=""down"">info (at) montaplast.com</a>  | <a href=""/impressum"" class=""down"" target=""_blank"">Impressum</a>
    |<a href=""/daten"" class=""down"" target=""_blank""> Datenschutz</a> 

</footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
