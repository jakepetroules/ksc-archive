<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html dir="ltr" xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>CS-340</title>
<link href="themes/default/style.css" rel="stylesheet" type="text/css" /> 
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.4/jquery.min.js" type="text/javascript"></script >
<script src="foopal.js" type="text/javascript"></script>
<script type="text/javascript">
	// use instead of body tag - insure that DOM is initialized
	window.onload=foopal("<?php echo(LINK) ?>","<?php echo(MODE) ?>");

</script>
</head>
<body>

    <div id="container">

      <div id="header">
          <?php print $page['heading']; ?>
          <?php print $motto; ?>
		  <div id="topnav"> </div>
      </div> <!-- /#header -->