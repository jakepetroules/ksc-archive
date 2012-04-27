<?php

class DAO {
	//connection parameters
	private $db = "cs340";
	private $host = "cs-old.keene.edu";
	private $id = "cs340";
	private $pswd = "";	
	private $conn;

// constructor
	public function __construct() 
	{
		// connect to db server 	
		if ($this->conn = mysqli_connect($this->host, $this->id, $this->pswd))
		{
		}
		else die('DB connection failed: ' . mysql_error());
		// connect to db
		if (mysqli_select_db($this->conn,$this->db))
		{
		}
		else die("database not found");
	}
	function get_user_record($userId)
	{
	}

	function get_news_record($news)
	{
	}

	function get_profile_record($name)
	{
	}

	function get_page_record($pageId)
	{
	}

	function get_users()
	{
	}

	function get_news()
	{
	  $result = $this->conn->query("select * from news");

	  $rows = array();
		while($r = mysqli_fetch_assoc($result)) 
		  {
		  $rows[] = $r;
		  }
		return json_encode($rows); 
	}
	
	function get_pages()
	{
	  $result = $this->conn->query("select * from pages");

	  $rows = array();
		while($r = mysqli_fetch_assoc($result)) 
		  {
		  $rows[] = $r;
		  }
		return json_encode($rows); 
	}
	
	// destructor
	public function __destruct()
	{
		mysqli_close($this->conn);
	}
}

?>