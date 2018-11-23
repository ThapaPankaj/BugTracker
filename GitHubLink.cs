using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugtracker
{
    class GitHubLink

    {
        private readonly string _repoSource;
        private readonly UsernamePasswordCredentials _credentials;
        private readonly DirectoryInfo _localFolder;
        private string localfolder;
        public GitHubLink(string username, string password, string gitRepoUrl, string localFolder) {

            this.localfolder = localFolder;
            var folder = new DirectoryInfo(localFolder);

            if (!folder.Exists)
            {
                throw new Exception(string.Format("Source folder '{0}' does not exist.", _localFolder));
            }

            _localFolder = folder;

            _credentials = new UsernamePasswordCredentials
            {
                Username = username,
                Password = password
            };

            _repoSource = gitRepoUrl;

        }

        public void PushCommits()
        {
            try {
                using (var repo = new Repository(localfolder))
                {
                    // Write content to file system
                    var content = "Commit this!";
                    File.WriteAllText(Path.Combine(repo.Info.WorkingDirectory, "fileToCommit.txt"), content);

                    // Stage the file
                    repo.Stage("fileToCommit.txt");

                    // Create the committer's signature and commit
                    Signature author = new Signature("timro naam", "@timro username", DateTime.Now);
                    Signature committer = author;

                    // Commit to the repository
                    Commit commit = repo.Commit("k k message lekhni ho commit garda lekha", author, committer);  // eha k vanera psh garni ho euta msg rakh

                    Remote remote = repo.Network.Remotes["origin"];
                    var options = new PushOptions();
                    options.CredentialsProvider = (_url, _user, _cred) =>
                        new UsernamePasswordCredentials { Username = "xawbeenregmi", Password = "timro password" };  //eha tero username ra pw rakh github ko

                    repo.Network.Push(remote, @"refs/heads/master", options);
                    Console.WriteLine("Pushed to github");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
           

        }

    }



}


