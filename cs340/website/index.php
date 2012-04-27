<?php

$q = $_GET['q'];

if ($q != '')
{
	switch ($q)
	{
		case 'about':
		case 'index':
		case 'ftp':
			$page = "$q.html";
			break;
		case 'homework-assignments':
			$page = "$q/index.html";
			break;
		default:
			$hwpages = ':(homework-assignments)/([0-9]+):';
			if (preg_match($hwpages, $q))
			{
				$page = preg_replace($hwpages, '$1/$2.html', $q);
				if (!file_exists($page))
				{
					$page = '404.html';
				}
			}
			else
			{
				$page = '404.html';
			}
			
			break;
	}
}
else
{
	$page = 'index.html';
}

$data = str_replace('<!--${CONTENT}-->', file_get_contents($page), file_get_contents('layout.html'));
$data = str_replace('<!--${HEAD}-->', file_get_contents("$page.head"), $data);
echo $data;

?>