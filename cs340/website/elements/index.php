<?php
error_reporting(0);
// store current root directory
define('FOOPAL_ROOT', getcwd());
// store path of current theme 
define('THEME','/themes/default');
// set the mode to user or admin
define('MODE','user');
// load settings 
require_once FOOPAL_ROOT . '/includes/bootstrap.inc';
// store url parameters, if any
if ( $_GET['param'] ) { 
	define('LINK', $_GET['param']);
	//echo $_GET["param"];	
	}
else {define('LINK', 'news');}

// initialize system
foopal_bootstrap('FOOPAL_BOOTSTRAP_TEST');

?>