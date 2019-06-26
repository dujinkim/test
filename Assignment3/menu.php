<?php
session_start();
if (isset($_POST["userid"]) and isset($_POST["password"])) {
    if ($_POST["userid"] === "dujin" and $_POST["password"] === "dujinpassword") {
        $_SESSION["userid"] = $_POST["userid"];
    } else {
        session_unset();
        session_destroy();
    }
}
?>

<html>
    <head>
        <title>Login</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
    </head>
    <body>
        <?php
        if (isset($_SESSION["userid"])) {
            ?>
            <h1>Welcome <?= $_SESSION["userid"] ?>!</h1>
            <p>What would you like to do?</p>
            <ul>
                <li><a href="insert.php">insert</a></li>
                <li><a href="delete.php">delete</a></li>
                <li><a href="update.php">update</a></li>
                <li><a href="file.html">file</a></li>
            </ul>
            <?php
        } else {
            ?>
            <h1>Login Error! Access denied.</h1>
            <a href="index.php">Try again.</a>
            <?php
        }
        ?>
    </body>
</html>
