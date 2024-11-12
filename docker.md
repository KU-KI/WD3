# Create … Run DOCKER Image and other most common Commands
```bash
docker build -t myimage:dev .	                                        create an image with name myimage:dev
docker tag local-image:tagname username/new-repo:tagname		rename an image
docker push username/new-repo:tagname	                                send an image to image hub
docker pull username/new-repo:tagname	                                load an image from image hub
docker run username/new-repo:tagname	                                run an image in foreground
docker run username/new-repo:tagname -d	                                run an image in background
docker run -p 80:80 username/new-repo:tagname -d	                run an image with ports specifics
```

```bash
docker			info, commands ...
docker --version	get the current version of docker that is installed
docker --help		get a list of available commands
docker ps       	list the running containers
docker ps -a 		list of all containers on your computer, including the ones that are stopped
docker stop <container ID or NAME>	stop running container
docker rm <container ID or NAME>	removes a stopped container from your machine
docker images		        show the images in our library
docker rmi <image ID or NAME>	removes an image from your machine
docker search		        find an image on the public Hub
docker build -t appname .	building the image from dockerfile with tag appname
docker run -ti imageName	start running a container with a keyboard attached
docker run -d imageName	        start running a container in the background (detached)
docker kill		stop a running container
docker rm -f		stop and remove a container
docker stats		show the RAM/CPU/network I/O usage of running containers
docker version		shows the Docker client/version and system architecture
docker info		a deep diagnostics page for the Docker engine
docker system prune -a   	Remove the stopped container and all of the images, including unused or dangling images
```

