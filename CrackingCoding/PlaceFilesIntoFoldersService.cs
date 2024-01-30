namespace CrackingCoding;

public class PlaceFilesIntoFoldersService : IRunable
{
    public void Run()
    {
        var path = @"C:\Users\Mikolaj\Desktop\files";
        PlaceFilesIntoFolder(path);
    }

    //place files into folders, based on first character in file content.
    private void PlaceFilesIntoFolder(string path)
    {
        var files = Directory.GetFiles(path);
        var currentDirectories = Directory.GetDirectories(path);

        foreach (var file in files)
        {
            var fileContent = File.ReadAllLines(file).First();
            var firstLetter = string.IsNullOrEmpty(fileContent) 
                ? "" 
                : fileContent.FirstOrDefault().ToString();

            if (!string.IsNullOrEmpty(firstLetter)) 
            {
                if (!currentDirectories.Any(a => a.Contains(firstLetter)))
                {
                    Directory.CreateDirectory(path + $"\\{firstLetter}");
                    currentDirectories = Directory.GetDirectories(path);
                }
                
                var fileName = new FileInfo(file);
                File.Move(file, path + $"\\{firstLetter}" + $"\\{fileName.Name}");
            }
        }
    }
}
