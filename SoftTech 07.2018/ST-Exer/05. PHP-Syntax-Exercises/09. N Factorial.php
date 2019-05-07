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
	    $num;
	    if (isset($_GET['num'])) {
		    $num = intval($_GET['num']);
	    }
	    $result = 1;
	    for ($i = $num; $i > 0; $i--) {
		    $result*=$i;
	    }
	    echo $result;
    ?>
</body>
</html>