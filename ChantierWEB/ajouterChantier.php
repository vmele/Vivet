<?php
	include 'db_connect.php';
?>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta charset="utf-8" />
    <link rel="stylesheet" type="text/css" href="stylesheet/add_update_contact.css">

</head>
<body>
    <section id="contact-form">
        <?php  
        
        // Action 3 = Ajouter contact.
        if ($_GET['action']==3) {
        	echo "<h2>Ajouter un chantier</h2>";
        	// Action 6 = requête ajouter
        	$action='index.php?action=6';
        	$nom = 'Nom';
        	$date = 'Date du chantier (YYYY-MM-dd)';
        	$montant = 'Montant total';
        	$client = 'Client';
        	 
        }
        else {
        	// Action 5 = Modifier contact
        	if ($_GET['action']==5) {
        		echo "<h2>Modifier un chantier</h2>";
        		// On récupère l'ID du chantier qu'on veut modifier
				$id_chantier = $_GET['Chantier'];
				// Action qui redirigera avec le bon id contact 
				$action="index.php?action=7&Chantier=". $id_chantier;
			
				// Récupère les données du contact selectionnés par son ID
				$query = $dbh->query("SELECT * FROM chantier WHERE id_chantier=".$id_chantier);
				$row = $query->fetch();
				$id_chantier = $row['id_chantier'];
				$nom = $row['nom'];
				$date = $row['date_debut'];
				$montant = $row['montant'];
				$client = $row['id_client'];
				$id_user = $row['id_user'];
				$query->closeCursor();
        	}
        	
        }
        
        ?>    
        
        <!-- Formulaire ajout / modif contact  -->
        <form id="chantier" name="chantier" action="<?php echo $action;?>" method="POST" onSubmit="return valider()">
        
            <label><span></span><input name="nom" type="text" placeholder="<?php echo $nom ; ?>" 
            	value="<?php echo $nom ;?>" required="required"/></label>
            	
            <label><span></span><input name="montant" type="text" 
            placeholder="<?php echo $montant;?>" value="<?php echo $montant ;?>" required="required"/></label>
            
            <label><span></span><input name="date_debut" type="date" placeholder="<?php echo $date; ?>" 
            value="<?php echo $date ;?>" required="required"/></label>
         
           	<!--  PHP pour remplir la cbx des entreprises. -->
           	<label><span></span><select name='client' placeholder="Client" required>
           	<?php 
           	// Toutes les entreprises de la bdd sont présentes.
           	// Retourne l'id entreprise en affichant sa raison_sociale
           	$sql =  'SELECT id_client, raison_sociale_client
    					FROM client
						ORDER BY raison_sociale_client';
           	foreach ($dbh->query($sql) as $row) {
           		$raison_sociale = $row['raison_sociale_client'];
           		echo '<option value="'.$row[id_client].'">'.$raison_sociale.'</option>';
           	}
           	?>
           	</select></label>
           		
            <input name="cancel" type="reset" value="Annuler" onclick="history.back()"/>
            <input name="submit" type="submit" value="Envoyer" />

        </form>
    </section>
</body>
<footer>
</footer>
</html>
