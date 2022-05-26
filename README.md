# STIX Database Webapp

## NHL Stenden Project 6.2

## 2021-2022 Period 4 



### Docker and Project Installation Guide (Windows 10 & 11)
=======
### Installation Guide (Windows 10 & 11)


1. IDE - Visual Studio 2022 (recommended)  [Get from here](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)

2. (Optional for other editors/IDEs)  - Install .Net 6 [Install both SDK and Core Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). Install latest version that supports your editor of choice. Target version 6.0.4. (older versions may not be supported). .Net 5 and lower is not supported.

3. Install Docker [Docker Desktop installer](https://desktop.docker.com/win/main/amd64/Docker%20Desktop%20Installer.exe)

4. Install WSL2. Note! x64 systems running any Windows 10 build earlier than 1903 do not support this. Upgrade to a newer version to proceed.

5. Download and install the latest version of  [WSL2](https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi)

6. After running the .msi file, open Powershell or a terminal window

7. Type `wsl --install` . If the help menu is shown, installation was successful, if not proceed with the install.

8. Type `wsl --set-default-version 2` to set the default version to v2.

9. Install the Linux distribution of your choice (recommended Ubuntu)

   9.1 Type `wsl --install -d ubuntu`

10. On the ubuntu terminal window, enter a new UNIX username and password of your choosing, and then exit the terminal when configuration completes.


**Congrats!** You have finished installing the required dependencies and software.

To run the docker image, open Docker Desktop and open the .sln file using Visual Studio 2022 to open the project. 

Click on the tab left of the Start Without Debugging (should be names Stix with a green arrow) and select Docker. Start the service and wait for it to complete configuration

NOTE! First time running you will have to set up your own web certificate. To do so, just confirm on the popup asking you to accept in Visual Studio. Some browsers may display a Warning page where you have to click "Accept the risks and continue" to accept the unknown certificate.


### Troubleshooting

In some cases, when opening Docker for the first time, the service will enter a loop of starting and stopping the engine, and trying to access the settings will result in a loading animation. To solve this, run Docker Desktop as admin, click on the Troubleshoot button and then click on Clean/Purge Data. Proceed and select all the items and then restart Docker. This should fix the problem.



**Database and Docker Installation**

1. Assuming Docker is installed, open any terminal and run

   `docker images`

2. If MongoDB is not listed, run

    `docker pull mongo`. This will pull the latest Mongo library

3. Create a Docker container

   `docker run -d -p 27017:27017 --name Stix-Mongo mongo`

   This will create a new container on port 27017 with the mongo image. 

4. (Important - run only after setting up steps 1 to 3 first time if the container was stopped)

   `docker restart Stix-Mongo`

   or alternatively use Docker Desktop and press on Start. Make sure to never delete the container, just stop it.

5. In order to run commands inside the container, you have to use this command

    `docker exec -it Stix-Mongo /bin/bash`

    or alternatively, from Docker Desktop, select CLI on the Stix-Mongo container.

6. Run the mongo shell by typing 

    `mongo`

7. To get a list of all databases, type

    `show databases`

8. To create a new database, as well as using an existing one, type

    `use Stix`

    Once a collection or an document is uploaded to a newly created database, mongo will save it.

9. To display existing collections inside the selected database, run

    `show collections`

10. In order to create a collection run

    `db.createCollection("CollectionName")`

    this will select the "CollectionName" collection. Exchange the second parameter with whatever table you need.

11. To see all the collections :

     `show collections`

12. To insert in the database, use :

     `db.CollectionName.insert(`

     ​	`{`

     ​			`"_id" : "1234",`

     ​			`"Name" : "Namy McNameFace"`

     ​	`})`

     You can also insert multiple items at once with the `.insertMany([])`command.

13. To get a list of all elements in a collection use

     `db.CollectionName.find().pretty()`

     

     

     


### Troubleshooting

In some cases, when opening Docker for the first time, the service will enter a loop of starting and stopping the engine, and trying to access the settings will result in a loading animation. To solve this, run Docker Desktop as admin, click on the Troubleshoot button and then click on Clean/Purge Data. Proceed and select all the items and then restart Docker. This should fix the problem.

