==> api-python
This is the python API version for the voting application

==> Contract
The API exposes four operations under the localhost/api/votes url :

- **/Elections (GET) : it returns all elections;
- **/Elections/{id} (GET) : it returns a specified election by the invoqued id ;
- **/Elections/{id} (PUT) : it  creates an election (idempotent) - election should be created without votes;
- **/Elections/{id}/Votes (POST) : it sends a vote.

==> Content
The basic form of The JSON is: :
 elections = [
     {"id":"BDE",
             "votes":
            [
                {
                    "choix":1,
                    "prenom":"JP"
                },
                {
                   "choix":2,
                    "prenom":"Fadwa"
                }
            ]
         },
         {   
         "id":"BDI",
             "votes":
            [
                {
                    "choix":7,
                    "prenom":"Adel"
                },
                {
                    "choix":2,
                    "prenom":"Gilles"
                }
            ]     

        }
      
		]
==> Launch the api with docker launcher:
after have installed docker on your computer,
You should do the command lines in administrator while being in the directory that contains the dockerfile:
 docker build -t test .

 docker run -d -p 81:5000 --name Test test

 docker logs Test

 docker rm -fv `docker ps -aq`

==> command lines of docker
- First one is for building the image test
- Second one is for running the api over the 5000 port with a container that is named 'Test'
- we can also debug the api by using a third command and we see what are the errors in case it does not work.
- last one is for removing all the images that are built already.



BY Fadwa BOUIZGAR