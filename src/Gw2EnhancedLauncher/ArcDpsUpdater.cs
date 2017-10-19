using System;
using System.IO;
using System.Security.Cryptography;

namespace Gw2EnhancedLauncher
{
    internal class ArcDpsUpdater
    {
        private const string arcUriBase = "https://www.deltaconnected.com/arcdps/x64/";
        private const string arcName = "d3d9.dll";
        private const string arcTemplateName = "d3d9_arcdps_buildtemplates.dll";
        private readonly bool useTemplates;
        private readonly string gameBinPath;
        
        public ArcDpsUpdater(string gameFolderPath, bool useArcDpsTemplates)
        {
            this.gameBinPath = Path.Combine(gameFolderPath, "bin64");
            this.useTemplates = useArcDpsTemplates;
        }

        public void Remove()
        {
            var arcFilePath = Path.Combine(this.gameBinPath, arcName);
            if (File.Exists(arcFilePath))
            {
                File.Delete(arcFilePath);
            }

            var templateFilePath = Path.Combine(this.gameBinPath, arcTemplateName);
            if (File.Exists(templateFilePath))
            {
                File.Delete(templateFilePath);
            }
        }

        public void Update()
        {
            this.UpdateFile(arcName, this.gameBinPath, arcUriBase, true);
            if (this.useTemplates)
            {
                var templatesRemotePath = arcUriBase + "buildtemplates/";
                this.UpdateFile(arcTemplateName, this.gameBinPath, templatesRemotePath, false);
            }
        }

        private void UpdateFile(string fileName, string localPath, string remotePath, bool hasChecksum)
        {
            var localFilePath = Path.Combine(localPath, fileName);
            var remoteFilePath = remotePath + fileName;
            if (!this.NeedsUpdate(localFilePath, remoteFilePath))
            {
                return;
            }

            if (File.Exists(localFilePath))
            {
                File.Copy(localFilePath, localFilePath + ".old", true);
            }                

            if (hasChecksum)
            {
                var checksumRemotePath = remotePath + fileName + ".md5sum";
                this.DownloadFile(localFilePath, remoteFilePath, checksumRemotePath);
            }
            else
            {
                this.DownloadFile(localFilePath, remoteFilePath);
            }
        }

        private bool NeedsUpdate(string localPath, string remotePath)
        {
            if (!File.Exists(localPath))
            {
                return true;
            }

            var localLastModified = File.GetLastWriteTimeUtc(localPath);
            var remoteLastModified = this.GetLastModified(remotePath);
            if (remoteLastModified >= localLastModified)
            {
                return true;
            }

            return false;
        }

        private DateTimeOffset? GetLastModified(string uri)
        {
            var client = new System.Net.Http.HttpClient();
            var message = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Head, uri);
            var response = client.SendAsync(message).Result;
            return response.Content.Headers.LastModified;
        }

        private void DownloadFile(string localFilePath, string remoteFilePath)
        {
            byte[] file;
            using (var wc = new System.Net.WebClient())
            {
                file = wc.DownloadData(remoteFilePath);
            }

            File.WriteAllBytes(localFilePath, file);
        }

        private void DownloadFile(string localFilePath, string remoteFilePath, string checksumRemotePath)
        {
            byte[] file;
            using (var wc = new System.Net.WebClient())
            {
                file = wc.DownloadData(remoteFilePath);
                using (var hash = MD5.Create())
                {
                    string checksum = wc.DownloadString(checksumRemotePath).Split(' ')[0];
                    string downloadChecksum = BitConverter.ToString(hash.ComputeHash(file)).Replace("-", "").ToLower();
                    if (checksum != downloadChecksum)
                    {
                        throw new System.Net.WebException();
                    }
                }
            }

            File.WriteAllBytes(localFilePath, file);
        }
    }
}
