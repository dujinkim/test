<html>
    <head>
        <title>Update</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width">
        <link rel="stylesheet" href="css/style.css">
    </head>
    <body>
        <div id="container">
            <h1>Update</h1>
            <form action="update.php" method="POST">
                <table>
                    <tr>
                        <td>Breed:</td>
                        <td><input type="text" required name="breed"></td>
                    </tr>
                    <tr>
                        <td>Name: </td>
                        <td><input type="text" required name="name"></td>
                    </tr>
                    <tr>
                        <td>Date of birth 1: </td>
                        <td><input type="text" required name="date_of_birth"></td>
                    </tr>
                    <tr>
                        <td>Colour: </td>
                        <td><input type="text" required name="colour"></td>
                    </tr>
                    <tr>
                        <td>Sex: </td>
                        <td><input type="text" required name="sex"></td>
                    </tr>
                    <tr>
                        <td>Description: </td>
                        <td><input type="text" required name="description"></td>
                    </tr>
                                        <tr>
                        <td>Number: </td>
                        <td><input type="text" required name="number"></td>
                    </tr>
                    <tr>
                        <td colspan="2"><input type="submit" value="Update"></td>
                </table>
            </form>
        </div>
    </body>
</html>

<?php


try {
    $dbh = new PDO('mysql:host=localhost;dbname=mysql', "root", "");
} catch (Exception $e) {
    die('Could not connect to DB: ' . $e->getMessage());
}


$breed = filter_input(INPUT_POST, "breed", FILTER_SANITIZE_SPECIAL_CHARS);
$name = filter_input(INPUT_POST, "name", FILTER_SANITIZE_SPECIAL_CHARS);
$date_of_birth = filter_input(INPUT_POST, "date_of_birth", FILTER_SANITIZE_SPECIAL_CHARS);
$colour = filter_input(INPUT_POST, "colour", FILTER_SANITIZE_SPECIAL_CHARS);
$sex = filter_input(INPUT_POST, "sex", FILTER_SANITIZE_SPECIAL_CHARS);
$description = filter_input(INPUT_POST, "description", FILTER_SANITIZE_SPECIAL_CHARS);
$number = filter_input(INPUT_POST, "number", FILTER_SANITIZE_SPECIAL_CHARS);



    
// do the insert
   //
   $command = "UPDATE assignment3_dujin_dogs SET breed=$breed, name=$name, date_of_birth=$date_of_birth, colour=$colour, sex=$sex,  description=$description WHERE registered_number=$number;";
    $stmt = $dbh->prepare($command);
    $result = $stmt->execute([$breed, $name, $date_of_birth, $colour, $sex, $description]);
    if ($result) {
        $msg = "update successful id = {$dbh->lastInsertId()}";
    } else {
        $msg = "update failed";
    }

?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Update</title>
        <link rel="stylesheet" href="../css/style.css">
        <meta name="viewport" content="width=device-width">
    </head>
    <body>
        <div id="container">
            <h1>Update</h1>
            <p><?= $msg ?></p>
            <i style='color:blue'><?= $command ?></i><br>
            <p><a href="menu.php">back</a></p>
        </div>
    </body>
</html>
