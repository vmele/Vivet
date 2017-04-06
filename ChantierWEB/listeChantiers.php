<?php

include 'db_connect.php';
$id_user = $_SESSION ['ID_Session'];

?>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utSf-8" />
<title>Contacts</title>
<meta charset="utf-8" />
<link rel="stylesheet" type="text/css"
	href="stylesheet/liste_contacts.css">
</head>
<body>	
		<?php  //include 'header.php';?>
		
	<h1>Vos chantiers en cours</h1>
	<table class="rwd-table">
		<tr>
			<th>Nom du chantier</th>
			<th>Date</th>
			<th>Montant total</th>
			<th>Client</th>
		</tr>
        <?php
								$sql = 'SELECT id_chantier, nom, date_debut, montant, chantier.id_client, raison_sociale_client FROM chantier, client WHERE 
				chantier.id_client = client.id_client AND id_user = ' . $_SESSION ['ID_Session'] . ' ORDER BY date_debut';
								foreach ( $dbh->query ( $sql ) as $row ) {
									echo "<tr>";
									echo "<td>" . $row ['nom'] . "</td>";
									echo "<td>" . $row ['date_debut'] . "</td>";
									echo "<td>" . $row ['montant'] . "</td>";
									echo "<td>" . $row ['raison_sociale_client'] . "</td>";
									echo '<td>
        		<a href="index.php?action=5&Chantier=' . $row ['id_chantier'] . '&u=' . $id_user . '"> 
					<img alt="Modifier" src="images/edit.png"/> 
				</a>
        		<a href="index.php?action=4&Chantier=' . $row ['id_chantier'] . '"> 
        		<img alt="Supprimer" src="images/garbage.png"/> 
				</a>
        		</td>';
									unset ( $row );
									echo '</tr>';
								}
								?>
    </table>

</body>
<footer>
</footer>
</html>
