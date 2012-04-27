<?php

class Dog
{
	private $id;
	private $name;
	private $color;
	
	public function __construct($name, $color)
	{
		$this->id = -1;
		$this->name = $name;
		$this->color = $color;
	}
	
	public function getID() { return $this->id; }
	public function getName() { return $this->name; }
	public function setName($name) { $this->name = $name; }
	public function getColor() { return $this->color; }
	public function setColor($color) { $this->color = $color; }
	
	public function insert()
	{
		$iName = mysql_real_escape_string($this->name);
		$iColor = mysql_real_escape_string($this->color);
		return mysql_query("INSERT INTO `woof` (`name`, `color`) VALUES ('$iName', '$iColor')");
	}
	
	public function update()
	{
		$iID = intval($this->id);
		$iName = mysql_real_escape_string($this->name);
		$iColor = mysql_real_escape_string($this->color);
		return mysql_query("UPDATE `woof` SET `name` = '$iName', `color` = '$iColor' WHERE `id` = $iID");
	}
	
	public function delete()
	{
		$iID = intval($this->id);
		return mysql_query("DELETE FROM `woof` WHERE `id` = $iID");
	}
}

$db = mysql_connect('cs-old.keene.edu', 'cs340', '');
if ($db)
{
	mysql_select_db('cs340', $db);
	
	$dog = new Dog($_POST['name'], $_POST['color']);
	$name = $dog->getName();
	$color = $dog->getColor();
	
	if ($dog->insert())
	{
		header('Location: /homework-assignments/8');
	}
	else
	{
		echo 'Database error: ' . mysql_error();
	}
}
else
{
	echo 'Failed to connect: ' . mysql_error();
}

?>