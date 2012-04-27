<?php
error_reporting(0);
// store current root directory
define('FOOPAL_ROOT', getcwd());
// store path of current theme 
define('THEME','/themes/default');
// set the mode to user or admin
define('MODE','admin');
// load settings 
require_once FOOPAL_ROOT . '/includes/bootstrap.inc';

// obtain url parameters, if any
if ( $_GET['param'] ) { 
	define('LINK', $_GET['param']);
	//echo $_GET["param"];	
	}
// or set default content
else {define('LINK', 'news');}

// initialize system
foopal_bootstrap('FOOPAL_BOOTSTRAP_TEST');

?>