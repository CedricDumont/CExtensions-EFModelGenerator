using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Test.Helpers
{
    public class BaseUnitTest
    {

        public BaseUnitTest()
        {
        }


        public string GetFileContent(string fileName, string folderName = "input")
        {
            string filePath = GetFilePath(folderName, fileName);

            return filePath.FileContent();
        }

        public string GetFileContentInFolder(string testFolderNamle, string fileNameWithExtension)
        {
            string path = GetFilePath(testFolderNamle, fileNameWithExtension);

            return path.FileContent();

        }

        public string GetFilePath(string testFolderNamle, string fileNameWithExtension)
        {
            string filePath = this.GetType().AssemblyDirectory() + "\\" + testFolderNamle + "\\" + fileNameWithExtension;

            if (!File.Exists(filePath))
            {
                throw new Exception("The file [" + filePath + "] does not exists. Make sure that you checked 'Copy always' or 'copy Newer' on the item properties");
            }

            return filePath;
        }
    }

    public static class TestExtensions
    {
        public static string FileContent(this string filePath)
        {
            FileInfo file = new FileInfo(filePath);

            if (file.Exists)
            {
                using (var stream = file.OpenRead())
                {
                    return stream.ReadFromStart();
                }
            }

            throw new Exception("file does not exists : " + filePath);
        }
    }
    }
