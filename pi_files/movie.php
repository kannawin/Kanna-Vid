<?php

error_reporting(-1);
ini_set('error_reporting',E_ALL);

//$r = $_GET['comm'];
//$p = $_GET['path'];

//$r = 's';
//$p = '/media/pi/KANNSTICK/media/Iron_Sky_2012/Iron_Sky_2012.mp4';

//echo $p;

//$p = str_replace(',','/',$p);
/*
if(isset($r) && $r == 's' && isset($p)){
//	exec('mkfifo /tmp/cmd');
	shell_exec('omxplayer '. $p .' < /tmp/cmd');
	sleep(1);
	shell_exec('echo -n p > /tmp/cmd');	
}
*/


exec('echo -n . > /tmp/cmd');
exec('echo -n , > /tmp/cmd');




?>
