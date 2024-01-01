# ExercismAndreGusmao
Here I will share my free acount exercise solutions from exercism platform (https://exercism.org/). The GitHub action test automation is currently set only for C#, more support later. 
# Folders structure
**.github/** : This folder contains the github workflows that are going to be triggered by github actions (trigger procces explained later).
**assets/** : This folder contains the asset images used in this readme file.
**language/one-exercise** : We have a folder for a language, e.g. csharp and a set of subfolders with the exercises.
# Branches
## main
Contains the most updated version of the Branch with all the exercises from all languages.
## Empty
If you want to start your Exercism exercises by your own you can fork the project and change this branch as your main. This way you will keep all the automation and documentation for working with Exercism.
## exercise-branches
Exercises branches are created and a pull requested is created to merge the content of each exercise branch with main. This flow is compulsory if you want the workflows to be triggered.
# Working with branches and GitHub Actions
1- If you forked the project and want to start from an empty perspective delete the main branch and change the branch "Empty" to your new branch, rename it as "main". If you want to work with my current completed version ignore this step.
2- Create a branch named "exercism-exercise" based on the branch main. E.g.: 
git checkout -f main
git checkout -b "name-of-next-exercism-exercise"
3- The name of the branch should be the same name of the exercism exercise FOLDER you download and are going to work.
4- Create a commit with the same name as the branch.
git commit -m "name-of-folder-of-exercise"
4- Create a Pull Request from that branch to the main branch.
5- If GitHub Actions tests are passed delete your exercise branch after that.
# Setting up
1- Fork this repo:
1.1- Click on fork:
![ForkStart](https://github.com/andresilvagusmao/ExercismCSharpAndreG/assets/46381013/b0bbdd3b-7149-4ea9-adc6-b07e52496fd1)
1.2- Configure your new repo (DO NOT MARK COPY MAIN BRANCH ONLY):
ForkFolder.png
ForkedRepoCreated.png
2- Enable workflow. Go to actions in your new repository in GitHub and accept the workflows.
EnableWorkflow.png
3- Download and install exercism cli manually (https://exercism.org/cli-walkthrough)
DownloadAndInstalExercismCLI.png
4- Check installed CLI version (Might need to reboot)
CheckExercismCLIInstalled.png
5- Install Exercism Extension
ExercismExtension.png
6- Configure exercism CLI.
6.1- Set API Token (https://exercism.org/docs/using/solving-exercises/working-locally).
apitoken.png
6.2- Configure exercism CLI. Set exercism working directory (set as the root of this repo, the language specific folders are created automatically)
ExercismConfigure.png
7- Install your language extensions (contains debug support, lint, auto-complete, compiler, etc)
CSharpExtension.png
8- Run C# programs (dotnet run). You have to call the methods, Exercism often only asks you to create the methods that are going to be tested, they might not be called.
PrintHelloWorld.png
9- Download Exercism exercises. Access the page and copy and paste in your terminal. 
DownloadExercism.png
10- Test your C Sharp programs (dotnet test).
DotnetRunAndDotnetTest.png
11- Submit your answer
ExercismSubmit.png