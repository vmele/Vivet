<?php
include 'db_connect.php';

 // Requête ID MAX Entreprise
$sql = $dbh->query('SELECT MAX(id_client) AS id_max FROM client');
$client = $sql->fetch();
$sql->closeCursor();


// Ajout d'un client : Action doit être set && action doit être = 10
if((isset($_GET['action'])) && ($_GET['action']==10)) {
	
	$raison_sociale_client = $_POST['raison_sociale'];
	$telephone = $_POST['telephone'];
	$mail = $_POST['mail'];
	
	try {
		
		$query = $dbh->prepare("INSERT INTO client(id_client, raison_sociale_client, telephone, mail) VALUES
							(:id_client, :raison_sociale_client, :telephone, :mail)");
		$query->execute(array(
				':id_client' => $client['id_max']+1,
				':raison_sociale_client' => $raison_sociale_client,
				':telephone' => $telephone,
				':mail' => $mail
		));
		$query->closeCursor();
		
	} catch (Exception $e) {
		echo 'Exception : ',  $e->getMessage(), "\n";
	}
}
else{
	// Modification d'une entreprise : action doit être = 11
	try {
		
		if (($_GET['action']==11)){
			// ID de l'entreprise pour la modification
			$id_client = $_POST['client_formulaire'];
			$raison_sociale_client = $_POST['raison_sociale_client'];
			$telephone = $_POST['telephone'];
			$mail = $_POST['mail'];
			// Requête update entreprise
			$query = $dbh->prepare("UPDATE client SET
				raison_sociale_client = :raison_sociale_client,
				telephone = :telephone,
				mail = :mail
           		WHERE id_client = :id_client");
			$query->execute(array(
					':raison_sociale_client' => $raison_sociale_client,
					':telephone' => $telephone,
					':mail' => $mail,
					':id_client' => $id_client
			));
			$query->closeCursor();
		}
		
	} catch (Exception $e) {
		echo 'Exception : ',  $e->getMessage(), "\n";
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
		include('listeChantiers.php');

?>