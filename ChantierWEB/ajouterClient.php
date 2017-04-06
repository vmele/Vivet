<?php
	include 'db_connect.php';
?>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<meta charset="utf-8" />
<link rel="stylesheet" type="text/css"
	href="stylesheet/add_update_contact.css">

</head>
<body>
	<section id="contact-form">

        <?php
								// Action 8 = Ajouter entreprise
								if ($_GET ['action'] == 8) {
									echo "<h2>Ajouter un client</h2>";
									// Action 10 = Query ajout cliennt
									$action = 'index.php?action=10';
									$raison_sociale_lbl = 'Raison sociale du client';
									$telephone = 'Telephone';
									$mail = 'eMail';
								} else {
									// Action 9 = modifier entreprise
									if ($_GET ['action'] == 9) {
										
										echo "<h2>Modifier un client</h2>";
										// action 11 = Query update entreprise
										$action = 'index.php?action=11';
										$raison_sociale_lbl = 'Raison sociale du client';
										$telephone = 'Telephone';
										$mail = 'eMail';
									}
								}
								?> 
          
           
        <form id="contact" name="contact" action="<?php echo $action;?>"
			method="POST">
			
           	<?php 
           	// Si nous sommes en modification d'entreprise, alors on affichera la cbx pour sÃ©lectionner l'entreprise
           	// Ã  modifier. 
           	// Cbx des entreprises
           	$sql =  'SELECT id_client, raison_sociale_client, telephone, mail
    					FROM client
						ORDER BY raison_sociale_client';
           	if ($_GET['action']=='9') {
           		echo '<label><span></span><select name="client_formulaire" placeholder="Client" required>';

           		foreach ($dbh->query($sql) as $row) {
           			$raison_sociale_select = $row['raison_sociale_client'];
           			// Renvoie l'ID de l'entreprise via le nom "entreprise_formulaire mais affiche la raison sociale.
           			echo '<option value="'.$row[id_client].'">'.$raison_sociale_select.'</option>';
           		}
           		echo "</select></label>";
        	}

           	?>
           	
            <label><span></span><input name="raison_sociale_client" type="text"
				placeholder="<?php echo $raison_sociale_lbl; ?>"
				value="<?php $raison_sociale_select ;?>" />
				
				<label><span></span><input name="telephone" type="text" placeholder="<?php echo $telephone; ?>"
				required="required" />
				
				<label><span></span><input name="mail" type="text" placeholder="<?php echo $mail; ?>" required="required" />
				
				</label><input name="cancel" type="reset" value="Annuler" onclick="history.back()" /> 
				
				<input name="submit" type="submit" value="Envoyer" />

		</form>
	</section>
</body>
<footer> </footer>
</html>
