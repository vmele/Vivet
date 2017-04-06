<?php
	// Affectation aux variables de sessions et le pw
	$_SESSION['Login']=$_POST['username'];
	$_SESSION['PASSWORD']=$_POST['password'];
	
	//Requête pour savoir s'il existe bien des utilisateurs
	$sql =  "SELECT COUNT(*) FROM users WHERE username='".$_SESSION['Login']."'";
	
	//
	if ($stmt = $dbh->query($sql)) 
	{
		// On vérifie ici que le nb d'utilisateurs > 0 
		if($stmt->fetchColumn() > 0)
		{
			// Si Login n'est pas vi, on lance la requete pour chercher le pw, id_user en fonction du Login
			if (!empty($_SESSION['Login'])) {
				$sql =  "SELECT password, id_user, username FROM users WHERE username='".$_SESSION['Login']."'";
				$stmt=$dbh->query($sql);
				$stmtTableau=$stmt->fetch();
				
				// Si pw de la requete = pw du formulaire
				if ($stmtTableau['password'] == $_SESSION['PASSWORD'])
				{
					// On crée notre ID session
					$_SESSION['ID_Session'] = $stmtTableau['id_user'];
					$_SESSION['LoginOK']=true;
					$_GET['action']='2';
					// Redirection sur index avec action = 2 : Login réussi
					include_once 'header.php';
					include('listeChantiers.php');
				}
				else
				{
					// Sinon, on redirige sur login.php
					$_SESSION['LoginOK']=false;
					include('login.php');
				}
			}
		}
		else
		{
			$_SESSION['LoginOK']=false;
			include('login.php');
		}
	}	
?>