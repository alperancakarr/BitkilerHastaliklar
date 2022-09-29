<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uye_ol.aspx.cs" Inherits="BitkilerHastaliklarStaj.uye_ol" %>


<!doctype html>
<html lang="en">
  <head>
  	<title>Üyelik Ekranı</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	
	<link rel="stylesheet" href="giris/css/style.css">

	</head>
	<body class="img js-fullheight" style="background-image: url(giris/images/bg.jpg);">
	<section class="ftco-section">
		<div class="container">
			<div class="row justify-content-center">
				<div class="col-md-6 text-center mb-5">
					<h2 class="heading-section">Üyelik Ekranı</h2>
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-md-6 col-lg-4">
					<div class="login-wrap p-0">
		      	<form action="#" class="signin-form" runat="server">

					<div class="form-group">
						<asp:TextBox class="form-control"  id="ad_kutusu" runat="server" placeholder="Ad"></asp:TextBox>
		      		</div>

					<div class="form-group">
						<asp:TextBox class="form-control"  id="soyad_kutusu" runat="server" placeholder="Soyad"></asp:TextBox>
		      		</div>

		      		<div class="form-group">
						<asp:TextBox class="form-control"  id="mail_kutusu" runat="server" placeholder="E-mail"></asp:TextBox>
		      		</div>
					
					<div class="form-group">
					  <asp:TextBox class="form-control" type="password" id="sifre_kutusu" runat="server" placeholder="Şifre"></asp:TextBox>
					  <span toggle="#sifre_kutusu" class="fa fa-fw fa-eye field-icon toggle-password"></span>
					</div>

					<div class="form-group">
	            		 <asp:Button ID="uyelik_butonu" runat="server" Text="Üye Ol" 
						CssClass="form-control btn btn-primary submit px-3" OnClick="uyelik_butonu_Click"
						/>	
					</div>
					  
	           
	          </form>
	          <div class="social d-flex text-center">
	          	<a href="giris.aspx" class="px-2 py-2 mr-md-1 rounded"><span class="ion-logo mr-2"></span>Giriş</a>
	          	<a href="ziyaretci_anasayfa.aspx" class="px-2 py-2 ml-md-1 rounded"><span class="ion-logo mr-2"></span>Ana Sayfa</a>
	          </div>
		      </div>
				</div>
			</div>
		</div>
	</section>

	<script src="giris/js/jquery.min.js"></script>
  <script src="giris/js/popper.js"></script>
  <script src="giris/js/bootstrap.min.js"></script>
  <script src="giris/js/main.js"></script>

	</body>
</html>

