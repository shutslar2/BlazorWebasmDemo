This solution is a demo sample of a Webassembly client app.
It includes a docker file which builds an image with ngenx:alpine base image
To build the docker image and start the container execute the following steps:
1. Ensure that windows WSL is enabled
2. Install a linux distro to the WSL from the Microsoft Store
3. Install Docker Desktop for Windows is installed on your windows computer
4. Configure Docker Desktop to use WSL (Settings > Resources > WSL Integration)
5. Open a console (cmd or powershell)
6. Change directory to the project's local resposity (e.g. cd c:\src\BlazorWasmDemo)
7. Ensure the docker file and nginx.conf are present in the current directory
8. Build the docker image:  docker build  -t shutslarnecs/blazorwasmdemo:latest .
	** Note:  Don't forget the period at the end of this step.  It's the most 
				common issue when docker build fails
9. Start the container:  docker run -d -p 8080:80 --name blazorwasmdemo shutslarnecs/blazorwasmdemo
10. open firefox and navigate to http://localhost:8080/index.html

05/10/2021 NOTE: The app starts but it does not server the home page as it should.  This is something
				 that will be worked on in a future update.  In the meantime, click any menu link in 
				 the left nav-menu.  The REST api test link is Fetch Data.  The GraphQL api test link
				 is SpaceX Launches.  

You can use the developer tools (F12) to look at network performance differences between the different api methods.