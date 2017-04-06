<?php
	include '../db_connect.php';
	$id_user = $_SESSION['ID_Session'];
	// TODO : Vérifications saisie + design. + suppression entreprise.
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
        $date_lbl = 'Date de création (YYYY-MM-dd)';
        // Action 8 = Ajouter entreprise
        if ($_GET['action']==8) {
        	echo "<h2>Ajouter une entreprise</h2>";
        	// Action 10 = Query ajout entreprise
        	$action='index.php?action=10';
        	$raison_sociale_lbl ='Raison sociale de l\'entreprise';
        }
        else {
        	// Action 9 = modifier entreprise
        	if ($_GET['action']==9) {
        		
        		echo "<h2>Modifier une entreprise</h2>";
        		// action 11 = Query update entreprise
				$action='index.php?action=11';
        		$raison_sociale_lbl ='Raison sociale de l\'entreprise';
        	}
        }
        ?> 
        
        	<form id="contact" name="contact" action="<?php echo $action;?>" method="POST">

			        	           	
           	<?php 
           	// Si nous sommes en modification d'entreprise, alors on affichera la cbx pour sélectionner l'entreprise
           	// à modifier. 
           	// Cbx des entreprises
           	$sql =  'SELECT id_entreprise, raison_sociale
    					FROM entreprise
						ORDER BY raison_sociale';
           	if ($_GET['action']=='9') {
           		echo '<label><span></span><select name="entreprise_formulaire" placeholder="Entreprise">';

           		foreach ($dbh->query($sql) as $row) {
           			$raison_sociale_select = $row['raison_sociale'];
           			// Renvoie l'ID de l'entreprise via le nom "entreprise_formulaire mais affiche la raison sociale.
           			echo '<option value="'.$row[id_entreprise].'">'.$raison_sociale_select.'</option>';
           		}
           		echo "</select></label>";
        	}

           	?>
           
           	
            <label><span></span><input name="raison_sociale" type="text" 
            placeholder="<?php echo $raison_sociale_lbl; ?>" value="<?php $raison_sociale_select ;?>"/></label>
            
            <label><span></span><input name="date_creation" type="date" placeholder="<?php echo $date_lbl; ?>"
            required="required"/></label>   
            
            <input name="cancel" type="reset" value="Annuler" onclick="history.back()"/>
            <input name="submit" type="submit" value="Envoyer"/>

        </form>
    </section>
</body>
<footer>
</footer>
</html>
