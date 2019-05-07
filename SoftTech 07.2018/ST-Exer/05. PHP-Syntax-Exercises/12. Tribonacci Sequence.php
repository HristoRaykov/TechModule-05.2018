<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
	<?php
		$num =0;
		if (isset($_GET['num'])) {
			$num = intval($_GET['num']);
		}
		$firstNum = 1;
		$secondNum =1;
		$thirdNum = 2;
		$counter = 2;
		if ($num==1){
			echo "1";
		}elseif ($num==2){
			echo "1 1 ";
		}elseif ($num==3){
			echo "1 1 2";
		}else if ($num>3){
			echo "1 1 2 ";
			while ($counter < $num) {
				$temp = $thirdNum;
				$thirdNum = $firstNum+$secondNum+$temp;
				$firstNum = $secondNum;
				$secondNum = $temp;
				$counter++;
				echo "$thirdNum ";
			}
		}
	?>
</body>
</html>