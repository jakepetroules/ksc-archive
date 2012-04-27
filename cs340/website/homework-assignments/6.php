<?php

$db = mysql_connect('cs-old.keene.edu', 'cs340', '');
if ($db)
{
	mysql_select_db('cs340', $db);
	$result = mysql_query("SELECT * FROM woof");
	
	$dogs = array();
	
	while ($row = mysql_fetch_array($result))
	{
		$dogs[] = array('id' => $row['id'], 'name' => $row['name'], 'color' => $row['color']);
	}
	
	echo json_encode($dogs);
}
else
{
	echo 'Failed to connect: ' . mysql_error();
}

?>