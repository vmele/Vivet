<?php
include '../db_connect.php';

 // Requête ID MAX Entreprise
$sql = $dbh->query('SELECT MAX(id_entreprise) AS id_max FROM entreprise');
$entreprise = $sql->fetch();
$sql->closeCursor();

// On récupère la raison sociale
$raison_sociale = $_POST['raison_sociale'];
$date = $_POST['date_creation'];

// Ajout d'une entreprise : Action doit être set && action doit être = 10
if((isset($_GET['action'])) && ($_GET['action']==10)) {
	// Requête insert entreprise
	$query = $dbh->prepare("INSERT INTO entreprise(raison_sociale, id_entreprise, date_creation) VALUES 
							(:raison_sociale, :id_entreprise, :date)");
	$query->execute(array(
			':raison_sociale' => $raison_sociale,
			':id_entreprise' => $entreprise['id_max']+1,
			':date' => $date
			));
	$query->closeCursor();

}
else{
	// Modification d'une entreprise : action doit être = 11
	if (($_GET['action']==11)){
		// ID de l'entreprise pour la modification
		$id_entreprise_frm = $_POST['entreprise_formulaire'];
		// Requête update entreprise
		$query = $dbh->prepare("UPDATE entreprise SET
				raison_sociale = :raison_sociale, date_creation = :date
           		WHERE id_entreprise = :id_entreprise");
		$query->execute(array(
				':raison_sociale' => $raison_sociale,
				':id_entreprise' => $id_entreprise_frm,
				':date' => $date
		));
		$query->closeCursor();
	}
	// Sinon, c'est une suppression.
	/*else{
		$id_contact = $_GET['Contact'];
		$query = $dbh->prepare("DELETE FROM entreprise WHERE id_entreprise =  :id_entreprise");
		$query->execute(array(
				':id_entreprise' => $id_entreprise_frm
		));
		$query->closeCursor();
	} */
}
		include('../listeChantiers.php');

?>