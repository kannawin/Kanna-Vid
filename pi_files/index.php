<?php

$q = $_GET['comm'];
if($q == 'prepare')
	exec('rm -v /tmp/cmd');
if($q == 'p')
	exec('echo -n p > /tmp/cmd');
if($q == 'q')
	exec('echo -n q > /tmp/cmd');
if($q == '>')
	exec('echo -n . > /tmp/cmd');
if($q == '<')
	exec('echo -n , > /tmp/cmd');
if($q == '^[[C')
	exec('echo -n ^[[C > /tmp/cmd');
if($q == '^[[D')
	exec('echo -n ^[[D > /tmp/cmd');
if($q == '^[[B')
	exec('echo -n ^[[B > /tmp/cmd');
if($q == '^[[A')
	exec('echo -n ^[[A > /tmp/cmd');
if($q == '9')
	exec('echo -n + > /tmp/cmd');
if($q == '-')
	exec('echo -n - > /tmp/cmd');
if($q == 'tvon')
	exec('echo on 0 | cec-client -s -d 1');
if($q == 'tvoff')
	exec('echo standby 0 | cec-client -s -d 1');
?>
