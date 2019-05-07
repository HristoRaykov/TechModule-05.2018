<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>First Steps Into PHP</title>
</head>
<body>
	<?php
		function drawRow1()
		{
			for ($i = 1; $i <= 5; $i++) {
				echo "<button style='background-color: blue'>1</button>";
			}
		}
		
		function drawRow2()
		{
			echo "<button style='background-color: blue'>1</button>";
			for ($i = 1; $i <= 4; $i++) {
				echo "<button>0</button>";
			}
		}
		
		function drawRow3()
		{
			for ($i = 1; $i <= 4; $i++) {
				echo "<button>0</button>";
			}
			echo "<button style='background-color: blue'>1</button>";
		}
		
		drawRow1();
		echo "<br>\n";
		for ($i = 1; $i <= 3; $i++) {
			drawRow2();
			echo "<br>\n";
		}
		drawRow1();
		echo "<br>\n";
		for ($i = 1; $i <= 3; $i++) {
			drawRow3();
			echo "<br>\n";
		}
		drawRow1();
	?>
</body>
</html>