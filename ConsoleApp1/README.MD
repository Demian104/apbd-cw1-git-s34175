1. When does Git do a fast-forward vs a merge commit?
   Git performs a fast-forward when the current branch has no new commits and can simply move its pointer forward.
   A merge commit is created when both branches have diverged and Git needs to combine their histories.

2. What is the difference between merge and rebase?
   Merge keeps the full history and creates a merge commit.
   Rebase rewrites history by applying commits from one branch on top of another, creating a linear history.

3. How was the conflict resolved?
   The conflict was resolved by combining the logic of >= 4 and != 4.
   As a developer, I decided that the best solution was = 4, and I rewrote the code logic accordingly to resolve the conflict.