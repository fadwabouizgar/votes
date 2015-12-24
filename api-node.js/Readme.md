==> api-node.js
This is the Node API version for the voting application

==> Contract
The API exposes four operations under the localhost/api/votes url :

- **/Elections (GET) : it returns all elections;
- **/Elections/{id} (GET) : it returns a specified election by the invoqued id ;
- **/Elections/{id} (PUT) : it  creates an election (idempotent) - election should be created without votes;
- **/Elections/{id}/Votes (POST) : it sends a vote.

==> Content
The basic form of The JSON is:
 {
   "id" : "BDE",
   'votes': [
      {
       'choix': 1,
        'prenom': 'Fadwa'
      },
      {
        'choix': 2,
        'prenom': 'Gilles'
      },
      {
        'choix': 2,
        'prenom': 'Adel'
      }]
 }

==> Launch the api with docker lancher:
after have installed docker on your computer,
You should do the command lines in administrator while being in the directory that contains the dockerfile:
> docker build -t test . 

> docker run -d -p 80:5004 --name Test test 

> docker logs Test

> docker rm -fv `docker ps -aq` 

==> command lines of docker
- First one is for building the image test
- Second one is for running the api over the 5004 port with a container that is named 'Test'
- we can also debug the api by using a third command and we see what are the errors in case it does not work.
- last one is for removing all the images that are built already.


BY FADWA Bouizgar