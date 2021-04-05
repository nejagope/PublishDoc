using System;
using System.IO;

namespace PublishDoc
{
    class IOActions
    {
        public static void CloneDirectory(string sourceDirName, string destDirName, Func<string, bool, DateTime, DateTime, bool> OnFileCloned)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            OnFileCloned?.Invoke(dir.FullName, true, dir.CreationTime, dir.LastWriteTime);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException($"Source directory does not exist or could not be found: {sourceDirName}");
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
                OnFileCloned?.Invoke(file.FullName, false, file.CreationTime, file.LastWriteTime);
            }

            // copy subdirectories and their contents to new location.
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);

                CloneDirectory(subdir.FullName, temppath, OnFileCloned);
            }
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}
