<?php
/* Connect to an ODBC database using driver invocation */
$dbname = "tp_chantier";
$dbhost = "localhost";
$dbuser = "postgres";
$dbpassword = "postgres";
$dbh;

try {
    $dbh = new PDO('pgsql:host='.$dbhost.';dbname='.$dbname.'', $dbuser, $dbpassword);
    //echo "Connexion réussie";
    $dbh->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    echo 'Connection failed: ' . $e->getMessage();
    
}

?>