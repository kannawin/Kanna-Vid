<?php

error_reporting(-1);
ini_set('error_reporting',E_ALL);
ini_set('display_errors',1);

header('Content-Type: application/json');

$dir = "/media/pi/Kannawin Drive/Movies";

$movies = array();

$ext = array('mkv','mp4','wav','mov','avi');


chdir($dir);

if(is_dir(getcwd())){
	if($dh = opendir(getcwd())){
		while(($file = readdir($dh)) !== false){
			$tempdir = getcwd() .'/'. $file . '/';
			if(is_dir($tempdir)){
				if($dh1 = opendir($tempdir)){
					while(($file1 = readdir($dh1)) !== false){
						$file2 = explode('.',$file1);
						if(contains($file2[(count($file2) - 1)], $ext)){ 
							$findir = $tempdir.$file1;
							$temp = array($file,  $findir);
							if($temp !== '..' || $temp !== '.'){
								array_push($movies,$temp );
							}
						}
					}
				}
			}
		}
	}
}

function contains($str, array $arr){
	foreach($arr as $a){
		if (stripos($str,$a) !== false) return true;
	}
	return false;
}
$results = array('results' => $movies);
$results['count'] = count($movies);

echo json_encode($results);

?>
