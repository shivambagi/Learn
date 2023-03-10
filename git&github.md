- In Command prompt or Git Bash
  - ***git --version***
  
- After Installing we have to configure name and email
  - ***git config --global user.name "your name"***
  - ***git config --global user.email "your.email@email.com"***
  - TO Edit config file it will sow you above details you can change it and press esc to save
    - ***git config --global --edit***

- To check if name & email is configured properly
  - ***git config --global user.name***
  - ***git config --global user.email***

- Create a folder and navigate to it to **initialize** it 
  - ***git init***

- To check for changes in the repo
  - ***git status***

- In git you have **track** a file(which also stages the file) and then **commit**
  - To **Track** a file
    - ***git add filenamewithextension***  == To add specific file
    - ***git add .***  == To add all files
  - To **Commit** a file
    - ***git commit -m "mesage"*** == '-m means message'

- To check **logs** of commits
  - ***git log***

- **Checkout** (To go to a specific commit)
  - ***git checkout -------*** == ------ is hashcode of that commit
  - This goes to specific coomit and files which are not present in that commit will be deleted
    - ***git checkout master*** == To move back to running commit 

- **Branching**
  - When you start you start at **master branch**, and then you can create **mutiple branches** from it
  - And **checkout** command is useful in **moving from branch to branch** 
  - ***git branch*** == shows the HEAD which is the location of current branch
  - In a certain branch if you want to get logs, it will show for that branch only
  - To create a branch
    - ***git branch branchname***
  - You can also checkout to specific branches
    - ***git checkout branchname***
  - Create and Checkout to branch at same time
    - ***git checkout -b ***

- **Merge**
  - To merge 2 branches 
  - This feature is generally used to create a feature separate(branch) from main code(master), develop and test and then merge it into main code(master)
  - To merge checkout in to the branch where you want to merge the feature branch
  - ***git merge branchname*** 

- **Pushing to Github**
  - The git push command is used to transfer or push the commit, which is made on a local branch in your computer to a remote repository like GitHub.
  - Create a repo on github
  - ***git remote -v*** == shows the connected repo of github with your workspace on PC
  - ***git remote add origin https:/linkofrepo***
  - ***git branch -M master*** == To point in which branch to push
  - ***git push -u origin master*** == To push
  - Similarly you can push different branches by changing name

- **Pull**
  - To update the local copy of the repo with the changes we made on GitHub, we use git pull.

- **Work on Others Repos**
- **Forking**
  - It is used to work on others repo. It creates a remote copy of that repo in your account
  - To fork go to github a hit fork button and create fork , it and copy that link.
  - Commiting changes in fork will not affect main repo
  - After commiting you have to make pull request,
    - Hit Contribute Button in Forked repo --> Open Pull Request --> See made changes --> Create Pull Request
    - This will send a request to the main repo owner, and he will approve the the Pull request and will merge with main repo

- **Cloning**
  - Clone will create the repos in you system
  - ***git clone https://github.com/shivambagi/First-Contribution.git***
  - In Azure devops,
    - Go to Repos --> Select the Repo --> Click Clone button --> Select Dropdown for Clone in VS/VSC --> The IDE will be opened -->  Maybe asked for some prompts and login --> clone will be done
