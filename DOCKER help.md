## Create … Run DOCKER Image and other most common Commands
```bash
docker build -t myimage:dev .								create/build an image from Dockerfile with name myimage:dev
docker run -p 80:80 myimage:dev							    create and run a new container with ports specifics (OUT:IN)
docker tag local-image:tagname username/new-repo:tagname	rename an image (create new one)
docker push username/new-repo:tagname	                    send an image to image hub
docker pull username/new-repo:tagname	                    load an image from image hub
docker run username/new-repo:tagname	                    create and run a new container in foreground
docker run -d username/new-repo:tagname	                    create and run a new container in background (detached)
docker run -p 80:80 -d username/new-repo:tagname			create and run a new container with ports specifics
```

```bash
docker				info, commands ...
docker help			get a list of available commands
docker version		shows the Docker client/version and system architecture
docker info			a deep diagnostics page for the Docker engine
docker stats		show the RAM/CPU/network I/O usage of running containers
docker ps       	list the running containers
docker ps -a 		list of all containers on your computer, including the ones that are stopped
docker stop <container ID or NAME>	stop running container
docker rm <container ID or NAME>	removes a stopped container from your machine
docker images						show the images in our library
docker rmi <image ID or NAME>		removes an image from your machine
docker run -v ./archiv/app:/app		bind mount a volume for persistence
docker run -ti imageName			start running a container with a keyboard attached
docker kill						stop a running container
docker rm -f					stop and remove a container
docker system prune -a   		Remove the stopped container and all of the images, including unused or dangling images
```

