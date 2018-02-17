<?php
    $stop = $_POST['stopat'];
    echo "<table>";
    for ($i = 1; $i <= $stop; $i++) {
        $output = false;
        $fizz = $i % 3 == 0;
        $buzz = $i % 5 == 0;

        if ($fizz) { $output .= "Fizz"; }
        if ($buzz) { $output .= "Buzz"; }
        if (!$output) { $output = $i; }

        echo "<tr><td>".$i."</td><td><b>".$output."</b></td></tr>";
    }
    echo "</table>";
?>