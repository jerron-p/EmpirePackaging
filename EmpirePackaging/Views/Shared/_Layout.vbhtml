<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">\
    <!-- The following line is for the tab title-->
    <title>@ViewBag.Title - Empire Packaging</title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/Site.css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <!--Beginning of Navbar-->
    <div class="navbar navbar-inverse navbar-fixed-top" style="background-color: #222222">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Empire Packaging", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <!--End of Navbar-->
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <div class="nav navbar-nav navbar-fixed-bottom" style="background-color: #222222">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>
            </div>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
