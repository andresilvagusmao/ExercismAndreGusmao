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

![ForkStart](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/1149aebb-a15a-45ad-a9c5-f6a180e779ed)


1.2- Configure your new repo (DO NOT MARK COPY MAIN BRANCH ONLY):

![ForkFolder](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/4c4ca6f2-2387-4202-bb9c-de1fa469111e)
![ForkedRepoCreated](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/5807e298-d175-41d0-aaff-bc916947181c)


2- Enable workflow. Go to actions in your new repository in GitHub and accept the workflows.

![EnableWorkflow](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/7f704b5c-d4d1-45aa-a52a-7a096d8ff1e5)

3- Download and install exercism cli manually (https://exercism.org/cli-walkthrough)

![DownloadAndInstalExercismCLI](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/13fe50ab-1697-4b3c-a8ab-13779902e1b5)

4- Check installed CLI version (Might need to reboot)

![CheckExercismCLIInstalled](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/b8b63525-dfde-4c56-b6d7-83c466a2b5d2)

5- Install Exercism Extension

![ExercismExtension](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/45b6f74d-1789-4e44-8dc8-400118d32462)

6- Configure exercism CLI.

6.1- Set API Token (https://exercism.org/docs/using/solving-exercises/working-locally).

![apitoken](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/d955483e-477e-4703-b7eb-b5c2835f7457)

6.2- Configure exercism CLI. Set exercism working directory (set as the root of this repo, the language specific folders are created automatically)

![ExercismConfigure](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/769ac12a-195e-40f5-b035-b5d497622d90)

7- Install your language extensions (contains debug support, lint, auto-complete, compiler, etc)

![CSharpExtension](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/79255f8d-299e-4e4f-a19e-df0efe3dff84)

8- Run C# programs (dotnet run). You have to call the methods, Exercism often only asks you to create the methods that are going to be tested, they might not be called.

![PrintHelloWorld](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/ea5ccd32-df34-4154-a6d6-6f6dd50089f8)

9- Download Exercism exercises. Access the page and copy and paste in your terminal. 

![DownloadExercism](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/9ce9810f-2b14-42f3-802b-5b2c3d3d0dea)

10- Test your C Sharp programs (dotnet test).

![DotnetRunAndDotnetTest](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/eead413f-43fc-4f8e-8e31-d0075d43e6cc)

11- Submit your answer
![ExercismSubmit](https://github.com/andresilvagusmao/ExercismAndreGusmao/assets/46381013/6328bb8d-2fc1-47f1-bc05-f800ee1e3ae0)
