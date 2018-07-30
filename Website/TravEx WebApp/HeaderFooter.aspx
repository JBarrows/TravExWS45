<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HeaderFooter.aspx.cs" Inherits="TravEx_WebApp.HeaderFooter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
	<meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
	<link rel="stylesheet" href="styles/fa-solid.min.css" />
    <link rel="stylesheet" href="styles/fontawesome.min.css" />
    <link href="styles/bootstrap.min.css" rel="stylesheet" />
    
    <title>Travel Experts</title>
    <link href="styles/HeaderFooter.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <header>
            <div class="bg-info text-white">
                <h2>Travel <img src="images/logo.png" width="10%" height="55%"/> Experts</h2>
                <h3><i id="phoneicon" class="fas fa-phone"></i> Call Us: 1-403-271-9872</h3>
            </div>

            <nav id="nav1">
                <ul>
                    <li><a href="index.php">Home</a></li>
                    <li><a href="packages.php">Packages</a></li>
                    <li><a href="customer_registration_form.php">Register</a></li>
					<li><a href="login.php">Log in</a></li>
                    <li><a href="AgencyContact.php">Contact</a></li>
                </ul>
            </nav>

<!-------------------------------------------------------------------------------------------------->
			<!--Navbar-->
			<nav id="nav2" class="navbar navbar-light light-blue lighten-4">

			<!-- Navbar brand -->
			<a class="navbar-brand" href="#"></a>

			<!-- Collapse button -->
			<button class="navbar-toggler toggler-example" type="button" data-toggle="collapse" data-target="#navbarSupportedContent1" aria-controls="navbarSupportedContent1"
				aria-expanded="false" aria-label="Toggle navigation"><span class="dark-blue-text"><i class="fa fa-bars fa-1x"></i></span></button>

			<!-- Collapsible content -->
			<div class="collapse navbar-collapse" id="navbarSupportedContent1">

				<!-- Links -->
				<ul class="navbar-nav mr-auto">
					<li class="nav-item active">
						<a class="nav-link" href="index.php">Home <span class="sr-only">(current)</span></a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="packages.php">Vacation Package</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="customer_registration_form.php">Register</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="login.php">Log in</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="AgencyContact.php">Contact</a>
					</li>
				</ul>
				<!-- Links -->

			</div>
			<!-- Collapsible content -->

			</nav>
			<!--/.Navbar-->

    </header>
    <main style="height:500px;">

    </main>
    <footer>
               <h5 class="text-info">Copyright &copy; Travel Experts 2018</h5>
    </footer>
    </form>
</body>
</html>
