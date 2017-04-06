<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=Cp1252">
<link rel="stylesheet" type="text/css"
	href="stylesheet/liste_contacts.css">
</head>
<body>
	<!--  Envoie en paramètre de l'url l'ID session pour pouvoir modifier les cbx en fonction. -->
	<?php 
		$login = $_SESSION ['ID_Session'];
	
	?>
	<ul>
		<li><a <?php echo 'href="index.php?action=3&u=' . $_SESSION['Login'] . '"'?>>Nouveau
				chantier</a></li>
		<li><a
			<?php echo 'href="index.php?action=8&u=' . $_SESSION['Login'] . '"'?>>Nouveau
				client</a></li>
		<li><a
			<?php echo 'href="index.php?action=9&u=' . $_SESSION['Login'] . '"'?>>Modifier
				client</a></li>
		<li style="float: right"><a class="active"
			<?php echo 'href="index.php?action=13"'?>>Deconnexion</a></li>
	</ul>
</body>
</html>