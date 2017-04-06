<?php
	unset($_SESSION);
	unset($_COOKIE);
	session_destroy();
	include('login.php');
?>