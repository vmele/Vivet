<?php
	// Si LoginSession n'est pas vide, on défini $Login.
	$Login="";
	if(empty($_SESSION["Login"])==false)
	{
		$Login=$_SESSION["Login"];
	}
?>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<meta charset="utf-8" />
<link rel="stylesheet" type="text/css" href="stylesheet/login_form.css">

</head>
<body>
	<div class="login-page">
		<div class="form">
			<form class="login-form" method="POST" action="index.php?action=1">   
				<input  type="text" placeholder="username" name="username" value="<?php echo $Login?>" />
				<input type="password" placeholder="password" name="password" />
				<button>login</button>
				<?php
					// Si LoginOK est set mais qu'il est à false, c'est que le login n'est pas bon.
					if (isset ( $_SESSION['LoginOK'] ) == true) {
						if ($_SESSION['LoginOK'] == false) {
							echo "<div class='ERREUR'><p>Erreur de la saisie du login! Veuillez recommencer.</p></div>";
						}
					}
				?>
			</form>
		</div>
	</div>
</body>
</html>
<!-- <form class="register-form">
			<input type="text" placeholder="name" />
			<input type="password" placeholder="password" />
			<input type="text" placeholder="email address" />
			<button>create</button>
			</form> -->