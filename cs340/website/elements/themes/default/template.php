<?php include('includes/header.php'); ?>

      <?php if ($page['sidebar_left']): ?>
        <div id="sidebar-left" >
			<div id="navigation"></div>
        </div>
      <?php endif; ?>
	  
	  <?php if ($page['sidebar_right']): ?>
        <div id="sidebar-right">
          
        </div>
      <?php endif; ?>
	  

      <div id="mainContent">
			<!-- include php code to perform sql query and insert into html-->
			<!-- ?php include('includes/' . LINK) ?-->
      
	  </div> <!-- #mainContent -->

     <?php include('includes/footer.php'); ?>