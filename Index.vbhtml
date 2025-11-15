@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row" aria-labelledby="Finance Tracking">
        <h1 id="title">Finance Tracking</h1>
        <p class="welcome">Welcome to the new Personal Finance Tracker. This is still a work in progress and will be upgrading </p>
        <p>@Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "nav-link"})</p>
    </section>

    
</main>
