# Kanna-Vid
Kanna-Vid Local Movie Server


This is the client side code of the movie server itself. If there is a raspberry pi at the specified IP address in the 
Form1.cs file with the given files in it, it will generate a usable list of movies in which the TV connected to it can play and control

If there is no IP address to a given Raspberry pi, it will compile to load just Form1.cs (Form2.cs is still under development) and a few
test movies to demonstrate what it does with the list.

The list is generated by a generic list of movie names where when clicked on one it will gather movie information using TheMovieDB's 
REST API in real time. The data is then stored temporarily during run time in cooperation with their terms of service.

This project is at the end of the first iteration and works, but it's inner workings need to be fine tuned and cleaned up,
with more features to come. 

As of now it can:
- Turn TV on/off
- Play/Pause any movie on the 'server' side
- Full movie control on the client side
- Optimized for touch screens 
- Gets full information of a movie before you watch


To run:
1. Put the pi files folder into /var/www/html of the raspberry pi (requires apache2 webserver installed previously)
	- change the permissions of all the files to allow any use to execute and read
	- run 'mkfifo /tmp/cmd' on the pi, this creates a fifo file to pipe usable commands for the video
	- go into the list.php file and change the directory of all of your movies
		- all movies must be each individually directories with the movie file inside titles <movie>(year)

2. Change the IP address in the Form1.cs file in the Kanna_Movies directory to the IP address of your PI
3. Run the Csharp solution and either export it to make an installable .exe or just compile, the only external library needed is restsharp, if your compiler does not have it. It uses all standard .net libraries
4. Plug the PI into a TV and enjoy the show.
