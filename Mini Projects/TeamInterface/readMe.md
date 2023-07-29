# Question

Implement inheritance as described below. Create a class Team that has the folowwing :
     1. A member variable teamName [string]
    2. A member variable noOfPlayers[integer]
   3. A constructor function : It tkes 2 parameters and assign the to teamName and noOfPlayers respectively.

4. A member function AddPlayer(count) :
  It takes an integer count as a parameter and increases noOfPlayers by count 

5.  Member functionRemovePlyers(count) : takes a integer count as a parameter and tries to decrease noofPlayers by count ; if decreasing noofPlayer negatives is False ; Else decrease Ofplayer by count and True


Create a class Subteam that inherits from the above class team . It has Folowing : 

. A constructor function : Takes 2 parametres, teamName and noOfPlayer calls the base class constructor with these parameters

B. Member team function ChangeTeamName( name) : Takes a srting name as a parametr and changes teamName to name


Note : declate all the members as public so that they are accesible by the stubbed code
