<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Delete</title>
        <link rel="stylesheet" href="css/style.css">
        <meta name="viewport" content="width=device-width">
    </head>
    <body>
        <div id="container">
            <form action="delete.php" method="post">
                <input type="number" name="deleteid" required><br>
                <input type="submit" value="Delete">
            </form>
            <p><a href="index.php">back</a></p>
            <p style='color:blue'>
            </p>
        </div>
    </body>
</html>
<?php
try {
    $dbh = new PDO('mysql:host=localhost;dbname=mysql', "root", "");
} catch (Exception $e) {
    die('Could not connect to DB: ' . $e->getMessage());
}

 

    $deleteid = filter_input(INPUT_POST, "deleteid", FILTER_VALIDATE_INT);

       // $deletecommand = "DELETE FROM assignment3_dujin_dogs WHERE registered_number=?";
       // $stmt = $dbh->prepare($deletecommand);
       /* if ($stmt->execute([$deleteid])->rowCount() > 0) {
            $message = "Poll $deleteid deleted.";
        } else {
            $message = "Poll $deleteid could not be deleted.";
        }*/
    if ($deleteid != NULL && $deleteid != false) {
    if (!$deleteid) {
        $message = "Sorry";
    } else {
        $deletecommand = "DELETE FROM assignment3_dujin_dogs WHERE registered_number=?";
        $stmt = $dbh->prepare($deletecommand);
        if ($stmt->execute([$deleteid])) {
            $message = "Poll $deleteid deleted.";
        } else {
            $message = "Poll $deleteid could not be deleted.";
        }
}
}
?>
