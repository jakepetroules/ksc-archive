<?php

$arr[] = array(
 'title' => $_POST['title'],
 'author' => $_POST['author'],
 'date' => $_POST['date'],
 'location' => $_POST['location'],
 'story' => $_POST['story']
);
echo json_encode($arr); 
?>