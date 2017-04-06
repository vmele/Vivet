<?php
include ('db_connect.php');

// Max ID pour le contact
$sql = $dbh->query ( 'SELECT MAX(id_chantier) AS id_max FROM chantier' );
$chantier = $sql->fetch ();
$sql->closeCursor ();

// Si nous sommes dans le cas d'une modification ou d'un ajout
if (($_GET ['action'] == 6) || ($_GET ['action'] == 7)) {
	
	// On déclare les variables seulement si on ajoute ou modifie car le suppression ne passe pas par un formulaire. Dans ce cas il fait une erreur.
	$nom_chantier = trim ( $_POST ['nom'] );
	$montant_chantier = trim ( $_POST ['montant'] );
	$id_client = trim ( $_POST ['client'] );
	$date_debut = trim ( $_POST ['date_debut'] );
	$id_user = $_SESSION ['ID_Session'];
	
	// Si le nom n'est pas vide
	if (empty ( $nom_chantier ) == false) {
		// Si le montant est pas vide ou < 0
		if (empty ( $montant_chantier ) == false || $montant_chantier > 0) {
			// Ajout d'un chantier : action doit être set && action = 6 (ajout)
			if ((isset ( $_GET ['action'] )) && ($_GET ['action'] == 6)) {
				
				try {
					
					// Requête insert contact
					$query = $dbh->prepare ( "INSERT INTO chantier(id_chantier, nom, date_debut, montant,
            				id_client, id_user)
							VALUES (:id_chantier, :nom, :date_debut, :montant, :id_client, :id_user)" );
					$query->execute ( array (
							':id_chantier' => $chantier ['id_max'] + 1,
							':nom' => $nom_chantier,
							':montant' => $montant_chantier,
							':date_debut' => $date_debut,
							':id_client' => $id_client,
							':id_user' => $id_user 
					) );
					$query->closeCursor ();
				} catch ( Exception $e ) {
					echo 'Exception : ', $e->getMessage (), "\n";
				}
				
				// Redirection ListeContact.
				include ('listeChantiers.php');
			} else {
				// Modification si action = 7
				if (($_GET ['action'] == '7')) {
					
					try {
						
						// Requete update contact
						$id_chantier = $_GET ['Chantier'];
						$query = $dbh->prepare ( "UPDATE chantier SET
				nom = :nom,
            	montant = :montant,
				date_debut = :date_debut,
				id_client = :id_client
           		WHERE id_chantier = :id_chantier" );
						$query->execute ( array (
								':nom' => $nom_chantier,
								':montant' => $montant_chantier,
								':date_debut' => $date_debut,
								':id_client' => $id_client,
								':id_chantier' => $id_chantier 
						) );
						$query->closeCursor ();
					} catch ( Exception $e ) {
						echo 'Exception : ', $e->getMessage (), "\n";
					}
					// Redirection ListeContact.
					include ('listeChantiers.php');
				}
			}
		}  // Else nom
else {
			historyBack ();
		}
	}  // Else genre
else {
		historyBack ();
	}
} else {
	
	try {
		// RequÃªte du delete
		$id_chantier = $_GET ['Chantier'];
		$query = $dbh->prepare ( "DELETE FROM chantier WHERE id_chantier = :id_chantier" );
		$query->execute ( array (
				':id_chantier' => $id_chantier
		) );
		$query->closeCursor ();
		
	} catch (Exception $e) {
		echo 'Exception : ', $e->getMessage (), "\n";
		
	}

	// Redirection ListeContact.
	include ('listeChantiers.php');
}
Function historyBack() {
	echo '<script type="text/javascript">';
	echo 'window.history.go(-1);';
	echo '</script>';
}
?>