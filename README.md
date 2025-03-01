# GYM_buddy
app for gym


# GYM_buddy

App for gym

----------------------------------------

## Step 1: Install .NET MAUI
Download and initialize .NET MAUI using this tutorial:
[https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/intro)

If you need help, ask ChatGPT for specific details on installation.

----------------------------------------

## Getting Started

### Clone the Repository
To get the latest project version, open a terminal (search "Terminal" in the top bar) and run:
(also you can do everything using buttons in git change view)

```
git clone https://github.com/JozefPro/GYM_buddy
cd gymBuddy
```

### Fetch and Pull the Latest Changes
After cloning, always **fetch and pull** the latest updates:
```
git fetch origin
git pull origin dev  # If working on the dev branch
```

### Set Up a New Branch
Before making changes, create a **new branch** for your task:
```
git checkout -b feature/GYM-5-workout-tracking
```
Use the **Jira issue number** in the branch name for tracking.

----------------------------------------

## Making Changes and Pushing to GitHub

### 1. Edit the Code
Make the necessary changes in the codebase.

### 2. Stage Your Changes in Git Changes Window
- Open **Git Changes** window in Visual Studio.
- Review modified files.
- Click **Stage All** to prepare changes for commit.

### 3. Write a Commit Message
In **Git Changes**, describe what you did:
```
GYM-5: Implemented workout tracking UI
```
Then click **Commit**.

### 4. Push Changes to GitHub
After committing, push the branch:
```
git push origin feature/GYM-5-workout-tracking
```

----------------------------------------

## Merging Changes to Main Branch
Once the task is completed, merge your feature branch into `main`:

### 1. Open a Pull Request in GitHub
- Go to **GitHub** → Open **Pull Requests**.
- Click **New Pull Request**.
- Select `feature/GYM-5-workout-tracking` → `main`.
- Click **Create Pull Request**.

### 2. Merge the PR
- Once reviewed, click **Merge Pull Request**.
- Delete the merged branch:
```
git branch -d feature/GYM-5-workout-tracking
git push origin --delete feature/GYM-5-workout-tracking
```




