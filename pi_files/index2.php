<?php
error_reporting(-1);
ini_set('error_reporting', E_ALL);
ini_set('display_errors',1);

//exec('mkfifo /tmp/cmd');
exec('xset -display :0.0 dpms force off');
exec('pkill omxplayer');

$r = $_GET['path'];
$r = str_replace('{', '&', $r);

echo exec("omxplayer -o hdmi \"".$r."\" < /tmp/cmd");

?>
