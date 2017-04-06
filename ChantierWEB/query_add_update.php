<?php
include ('db_connect.php');

// Max ID pour le contact
$sql = $dbh->query ( 'SELECT MAX(id_chantier) AS id_max FROM chantier' );
$chantier = $sql->fetch ();
$sql->closeCursor ();

//$id_chantier = trim($_GET['Chantier']);
$nom_chantier = trim ( $_POST ['nom'] );
$montant_chantier = trim ( $_POST ['montant'] );
$id_client = trim ( $_POST ['client'] );
$date_debut = trim ( $_POST ['date_debut'] );
$id_user = $_SESSION ['ID_Session'];

// Si nous sommes dans le cas d'une modification ou d'un ajout
if (($_GET ['action'] == 6) || ($_GET ['action'] == 7)) {
	// Si le nom n'est pas vide
	if (empty ( $nom_chantier ) == false) {
		echo ('Nom OK');
		// Si le montant est pas vide ou < 0
		if (empty ( $montant_chantier ) == false || $montant_chantier > 0) {
			echo ('Montant OK');
			// Ajout d'un chantier : action doit �tre set && action = 6 (ajout)
			if ((isset ( $_GET ['action'] )) && ($_GET ['action'] == 6)) {
				// Requ�te insert contact
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
				
				// Redirection ListeContact.
				include ('listeChantiers.php');
			} else {
				// Modification si action = 7
				if (($_GET ['action'] == '7')) {
					$id_chantier = $_GET ['Chantier'];
					// Requete update contact
					$query = $dbh->prepare ( "UPDATE chantier SET
				nom = :nom,
            	montant = :montant,
				date_debut = :date_debut,
				id_client = :id_client,
           		WHERE id_chantier = :id_chantier" );
					var_dump ( $id_chantier );
					$query->execute ( array (
							':nom' => $nom_chantier,
							':montant' => $montant_chantier,
							':date_debut' => $date_debut,
							':id_client' => $id_client,
							':id_chantier' => $id_chantier 
					) );
					$query->closeCursor ();
					var_dump ( $query );
					// Redirection ListeContact.
					include ('listeChantiers.php');
				}
			}
		} 		// Else nom
		else {
			historyBack ();
		}
	} 	// Else genre
	else {
		historyBack ();
	}
} else {
	// On récupère l'ID du contact depuis l'url
	$id_chantier = $_GET ['Chantier'];
	// Requête du delete
	$query = $dbh->prepare ( "DELETE FROM chantier WHERE id_chantier = :id_chantier" );
	$query->execute ( array (
			':id_chantier' => $id_chantier 
	) );
	$query->closeCursor ();
	// Redirection ListeContact.
	include ('listeChantiers.php');
}
Function historyBack() {
	echo '<script type="text/javascript">';
	echo 'window.history.go(-1);';
	echo '</script>';
}
?>