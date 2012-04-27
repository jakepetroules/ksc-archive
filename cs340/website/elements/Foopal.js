function foopal(link, mode) {
//alert("link: " + link + " mode: " + mode);
navigation(mode);

	//alert("Working: received link " + link);
	switch(link) {
		case news:
			news(link);
		break;
	default: news(link);
	}

} // end foopal	

function navigation(mode) { 
if (mode == 'user') {
	$.getJSON("foopal.php", {param: "navigation"}, function(data) {
		//alert("received: " + data);
		var $html = '';
		$('#navigation').empty();
		$.each(data, function(entryIndex, entry) {
			$html += '<li id="link'+entryIndex+'"><a href="' + entry['pageUrl'] + '" title="' + entry['pageUrl'] + '">' + entry['pageName'] + '</li>';
			
			
		} // end anonymous inner function; function(entryIndex, entry)
		); // end .each
		
		
		
		
		$('#navigation').append('<ul>' + $html + '</ul>');
		
		$.each(data, function(entryIndex, entry) {
		
			$('#link'+entryIndex).click(function(){
				$('#mainContent').empty();
				$('#mainContent').append(entry['content']);
			});
		});
	});
	
	} // end if
	else if (mode == 'admin') {
		$.getJSON("foopal.php", {param: "navigation"}, function(data) {
			//alert("received: " + data);
			var $html = '';
			$('#navigation').empty();
			$.each(data, function(entryIndex, entry) {
				$html += '<li><a href="admin.php?' + entry['pageName'] + '" title="' + entry['pageUrl'] + '">' + entry['pageName'] + '</li>';
			} // end anonymous inner function; function(entryIndex, entry)
			); // end .each
			$('#navigation').append('<ul>' + $html + '</ul>');
		});
	} // end if

} // end navigation

function news(link, mode) {
	if (mode == 'user') {	
	$.getJSON("foopal.php", {param: link}, function(data) {
		//alert("received: " + data);
		var $html = '';
		$('#mainContent').empty();
		$.each(data, function(entryIndex, entry) {
			$html += '<h3>' + entry['title'] + '</h3>';
			$html += '<p>' + entry['author'] + ' ' + entry['date'] + ' ' + entry['location'] +'</p>';
			$html += '<p>' + entry['story'] + '</p>';
		} // end anonymous inner function; function(entryIndex, entry)
		); // end .each
		$('#mainContent').append( $html );
	});
	
	} // end if
		
	else if (mode == 'admin') {
		news_form(link);
	} // end if
} // end news

function news_form(link) {
	
	$.getJSON("foopal.php", {param: 'news'}, function(data) {
		//alert("received: " + data);
		var $html = '';
		$('#mainContent').empty();
		$.each(data, function(entryIndex, entry) {
			$html += '<form action="index.php" method="get">';
			// hidden field, value determines action performed
			$html += '<input type="hidden" name="admin" value="news"/>';
			// input / output fields
			$html += '<p>';
			$html += 'title: ';
			$html += '<input type="text" size="45" name="title" value="' + entry['title'] + '"/>';
			$html += '</p>';
			$html += '<p>';
			$html += 'author: ';
			$html += '<input type="text" size="42" name="author" value="' + entry['author'] + '"/>';
			$html += '</p>';
			$html += '<p>';
			$html += 'date: ';
			$html += '<input type="text" size="9" name="date" value="' + entry['date'] + '"/>';
			$html += ' at: ';
			$html += '<input type="text" size="25" name="location" value="' + entry['location'] + '"/>';
			$html += '</p>';
			$html += '<p>';

			$html += '<textarea rows="2" cols="40" name="title" name="story">' + entry['story'] + '</textarea>';
			$html += '</p>';
			// buttons
			$html += '<p>';
			$html += '&nbsp;&nbsp;'
			$html += '<input type="submit" name="param" value="create" style="height: 23px; width: 70px"/>';
			$html += '&nbsp;&nbsp;'
			$html += '<input type="submit" name="param" value="read" style="height: 23px; width: 70px"/>';
			$html += '&nbsp;&nbsp;'
			$html += '<input type="submit" name="param" value="update" style="height: 23px; width: 70px"/>';
			$html += '&nbsp;&nbsp;'
			$html += '<input type="submit" name="param" value="delete" style="height: 23px; width: 70px"/>';
			$html += '</p';
			$html += '</form>';
			$html += '<hr/>';
		} // end anonymous inner function; function(entryIndex, entry)
		); // end .each
		$('#mainContent').append( $html );
	});
} // end news
