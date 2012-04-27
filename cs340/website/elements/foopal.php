<?php 

	require('includes/dao.php'); 
	$link = $_GET["param"];
	//echo $link;
	//$dao = new DAO();

	switch ($link) {
		case "news":
			news();
		break;
		case "navigation":
			navigation();
		break;
		case "profiles":
			profiles();
		break;
	}
	
	function news() {
		$dao = new DAO();
		echo($dao->get_news());
	}
	
	function profiles() {
		//echo("profiles!");
	}
	
	function navigation() {
		$dao = new DAO();
		echo($dao->get_pages());
	}

?>