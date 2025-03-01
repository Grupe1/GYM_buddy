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

Clone the Repository
To get the latest project version, open a terminal(search  and run:

```
git clone https://github.com/JozefPro/gymBuddy.git
cd gymBuddy
```

----------------------------------------

## Branching Strategy

We follow this Git branch workflow:
- `main` → Stable production-ready code
- `dev` → Development branch (features merged here before going to `main`)
- `feature/XYZ` → Feature branches (one per issue/task)

Create a New Branch for a Task
Always create a new branch when working on a task/feature:

```
git checkout -b feature/GYM-5-workout-tracking
```

Use the Jira issue number in the branch name for tracking.

----------------------------------------

## Syncing with Remote Repository

Fetch the Latest Changes
Before making changes, update your local repo:

```
git fetch origin
git pull origin dev  # If working on the dev branch
```

----------------------------------------

## Committing and Pushing Changes

Add and Commit Changes
1. Add modified files:
   ```
   git add .
   ```
2. Commit with a message (use Jira issue key):
   ```
   git commit -m "GYM-5: Implemented workout tracking UI"
   ```
3. Push the branch to GitHub:
   ```
   git push origin feature/GYM-5-workout-tracking
   ```

----------------------------------------

## Merging Changes

Merging a Feature Branch into `dev`
Once a feature is completed:
1. Open a Pull Request (PR) in GitHub.
2. Merge `feature/GYM-5-workout-tracking` → `dev`.
3. When `dev` is ready, merge it into `main`.

After merging, delete the feature branch:

```
git branch -d feature/GYM-5-workout-tracking
git push origin --delete feature/GYM-5-workout-tracking
```

----------------------------------------

## Keeping Your Branch Up-to-Date

If your branch is behind `dev`, rebase your branch to avoid conflicts:

```
git checkout dev
git pull origin dev
git checkout feature/GYM-5-workout-tracking
git rebase dev
```

----------------------------------------

Best Practices

- Commit often: Small commits make it easier to track changes.
- Use Jira issue keys in commit messages for tracking.
- Always pull before pushing to avoid merge conflicts.
- Don’t commit sensitive data like API keys.

----------------------------------------

Need Help?

If you have any issues, ask in our team chat or check GitHub documentation: [GitHub Docs](https://docs.github.com/)

Happy coding!
