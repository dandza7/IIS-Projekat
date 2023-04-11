namespace IIS_Projekat.SupportClasses.FileConverter
{
    public static class FileConverter
    {
        public static byte[] FormFileToBytes(IFormFile formFile)
        {
            using var memoryStream = new MemoryStream();
            formFile.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
