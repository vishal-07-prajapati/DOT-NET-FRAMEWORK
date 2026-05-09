-- this is how you can add any repo in git and manage code.

-- replace test with you repo name
echo "# test" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/vishal-07-prajapati/test.git
git push -u origin main