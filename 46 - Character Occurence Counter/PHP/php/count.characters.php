<?php
    $input = $_POST['input'];
    $total = 0;
    $results = array();

    // Iterate through characters and count the occurence of each.
    for ($i=0;$i<=strlen($input);$i++) {
        $char = substr($input, $i, 1);
        if ($char !== '') {
            if (array_key_exists($char, $results)) {
                $results[$char]++;
            } else {
                $results[$char] = 1;
            }
            $total++;
        }
    }

    // Sort by occurence.
    arsort($results);

    // Display results as table rows
    foreach ($results as $key => $value) {
?>
    <tr>
        <td><?php echo "'".$key."'"; ?></td>
        <td><?php echo $value; ?></td>
        <td><?php echo round(($value/$total) * 100, 2).'%'; ?></td>
    </tr>
<?php
    }

?>