using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System;

namespace Sabujcha.Utilities
{
    public static class FileUtilities
    {
        public static async Task<string> FileCreate(this IFormFile file, string root, string folder)
        {
            string fileName = Guid.NewGuid() + file.FileName;
            string path = Path.Combine(root, folder);
            string fullPath = Path.Combine(path, fileName);

            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
        public static void FileDelete(string root, string path, string imageName)
        {
            string fullPath = Path.Combine(root, path, imageName);
            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
