<?php
include 'db_connect.php';
$Login = "";
if (isset($_SESSION) == false ){	
	session_start ();
}

// Démarrage de la session
if (isset ( $_SESSION ['LoginOK'] )) {
	if ($_SESSION ['LoginOK'] == true) {
		/**
		 * Si action est vide ou inexistant, alors on include login.php
		 */
		if (empty ( $_GET ['action'] ) == true) {
			include ('login.php');
		} else {
			// Si on veut se d�connecter on n'inclue par le header
			if ($_GET ['action'] == 13) {
				include ('disconnect.php');
			} else {
				// Sinon on le met, �a signifie qu'on est loggu�
				include ('header.php');
				switch ($_GET ['action']) {
					
					case '1' :
						include ('controle_login.php');
						break;
					
					case '2' :
						include ('listeChantiers.php');
						break;
					
					// Ajout contact
					case '3' :
						include ('ajouterChantier.php');
						break;
					
					// Delete contact (passe par query car pas de redirection vers autre page)
					case '4' :
						include ('queryChantier.php');
						break;
					
					// Update contact
					case '5' :
						include ('ajouterChantier.php');
						break;
					
					// Add contact query
					case '6' :
						include ('queryChantier.php');
						break;
					
					// Update contact query
					case '7' :
						include ('queryChantier.php');
						break;
					
					// Add entreprise
					case '8' :
						include ('ajouterClient.php');
						break;
					
					// Update entreprise
					case '9' :
						include ('ajouterClient.php');
						break;
					
					// Add entreprise query
					case '10' :
						include ('queryClient.php');
						break;
					
					// Update entreprise query
					case '11' :
						include ('queryClient.php');
						break;
					
					// Delete entreprise query
					case '12' :
						include ('queryClient.php');
						break;
					
					// Prêt à détruire la session
					case '13' :
					include ('disconnect.php');
					break;
					
					// Include login.php
					case '14' :
						include ('login.php');
						break;
					
					// // Include login.php
					// case '15' :
					// include ('footer.php');
					// break;
				}
			}
		}
	} else {
		
		if (isset($_GET['action'])) {
		
			if ($_GET ['action'] == 1) {
				include ('controle_login.php');
			}
			else {
				include ('login.php');
			}
		}
		else{
			include('login.php');
		}
	}
} else {
	
	if (isset($_GET['action'])) {
		
		if ($_GET ['action'] == 1) {
			include ('controle_login.php');
		} 
		else {
			include ('login.php');
		}
	}
	else{
		include('login.php');
	}

}

?>