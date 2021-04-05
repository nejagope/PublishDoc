using System;
using System.IO;

namespace PublishDoc
{
    class PublishUtils
    {
        public const int SYNCHRONIZED = 0;
        public const int NOT_SYNCHRONIZED = 1;
        public const int MISSING = 2;

        public static int DirectoryStatus(DirectoryInfo dir)
        {
            bool isPublished = IsPublished(dir.FullName, true);

            if (!isPublished)
                return MISSING;

            foreach (var subDir in dir.EnumerateDirectories())
            {
                var subdirStatus = DirectoryStatus(subDir);
                if (subdirStatus == MISSING || subdirStatus == NOT_SYNCHRONIZED)
                    return NOT_SYNCHRONIZED;
            }

            foreach (var file in dir.EnumerateFiles())
            {
                int fileStatus = FileStatus(file);
                if (fileStatus == MISSING || fileStatus == NOT_SYNCHRONIZED)
                    return NOT_SYNCHRONIZED;
            }

            return SYNCHRONIZED;
        }

        private static bool IsPublished(string sourcePath, bool isDirectory)
        {
            var relativePath = sourcePath.Remove(0, Config.SOURCE_PATH.Length);
            DateTime? publicationDate = DB.GetPublicationDate(relativePath);
            return publicationDate != null;
        }

        public static int FileStatus(FileInfo fileInfo)
        {
            string sourcePath = fileInfo.FullName;
            var relativePath = sourcePath.Remove(0, Config.SOURCE_PATH.Length);

            DateTime? createdAt = null, modifiedAt = null, publishedAt = null;
            DB.GetFileDates(relativePath, ref createdAt, ref modifiedAt, ref publishedAt);
            if (publishedAt == null)
            {
                return MISSING;
            }
            else
            {
                if (modifiedAt != null)
                {
                    if (DateTime.Compare(File.GetLastWriteTime(Path.Combine(Config.SOURCE_PATH, sourcePath)), (DateTime)modifiedAt) == 0)
                    {
                        return SYNCHRONIZED;
                    }
                }
            }
            return NOT_SYNCHRONIZED;
        }

        public static bool Publish(string sourcePath, string publishPath)
        {

            return false;
        }
    }
}
