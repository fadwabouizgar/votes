==> api-core.net
This Core .NET version of the voting API.

==> Contract
The API exposes four operations under the /api/votes base:

- **/Elections (GET)** : returns all elections;
- **/Elections/{id} (GET)** : returns a given election;
- **/Elections/{id} (PUT)** : creates an election (idempotent) - election should be created without votes;
- **/Elections/{id}/Votes (POST)** : sends a vote.

==> Content
The JSON basic form is the following for an exception:
>
 {
   "id" : "BDE",
   "votes" : [
      { choix : 1, prenom : "Fadwa" },
      { choix : 1, prenom : "Gilles" }
   ]
 }

==> Launch the api with docker:
after have installed docker on your computer,
You should do the command lines in administrator while being in the directory that contains the dockerfile:
> docker build -t test . 

> docker run -d -p 80:5004 --name Test test 

> docker logs Test

> docker rm -fv `docker ps -aq` 

==> Explanation docker command lines
- The first command allows to build the image test (do not forget the .)
- The second allows to run the api over the 5004 port with a container name 'Test'
- In case it doesn't work, you can debug the api by doing the third command line
- The last command line allows to remove all the images already built.


BY Fadwa BOUIZGAR