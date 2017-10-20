The project needs to be builded first. You need to have .net framework 4.6.1. if going to build it via command prompt.
Visual studio will manage it.

After the compilation - publish the project again via command prompt or Visual studio to a folder of your choice. (You are going to use this path later when creating the service.)

Open a command prompt with admin rights

1. write and hit enter:
sc create {NameOfYourService} binPath="{PathToTheFolderWhereTheProjectIsPublished}"

2. write and hit enter:
sc start {NameOfYourService}

3. Open window services and find your service in the list. Then you can set it to run automaticaly at the windows startup.

It's done. By default the project will listen on localhost:5000

Project test url: localhost:5000/api/values