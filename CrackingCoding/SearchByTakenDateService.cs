namespace CrackingCoding;

public class SearchByTakenDateService : IRunable
{
    public void Run()
    {
        string path = @"J:\";
        var foundFiles = SearchByTakenDate(path);

        foreach (var fileName in foundFiles)
        {
            Console.WriteLine(fileName);
        }
    }

    public List<string> SearchByTakenDate(string path)
    {
        var files = GetAllFiles(path);
        
        var fullNames = new List<string>();
        var searchValue = new DateTime(2012, 11, 1);
        var maxsearchValue = new DateTime(2012, 11, 30);

        Parallel.ForEach(files, (file) => 
        {
            var fileInfo = new FileInfo(file);

            if(fileInfo.LastWriteTime.Date >= searchValue 
            && fileInfo.LastWriteTime.Date <= maxsearchValue)
            {
                fullNames.Add(fileInfo.FullName);
            }
        });

        return fullNames;
    }

    static string[] GetAllFiles(string directoryPath)
    {
        try
        {
            // Get all files in the current directory
            string[] files = Directory.GetFiles(directoryPath);

            // Recursively get files in subdirectories
            string[] subdirectoryFiles = Directory.GetDirectories(directoryPath)
                .SelectMany(subdirectory => GetAllFiles(subdirectory))
                .ToArray();

            // Combine the arrays and return
            return files.Concat(subdirectoryFiles).ToArray();
        }
        catch (UnauthorizedAccessException)
        {
            // Handle unauthorized access exceptions, if necessary
            Console.WriteLine($"Access to directory '{directoryPath}' is unauthorized.");
            return new string[0];
        }
        catch (DirectoryNotFoundException)
        {
            // Handle directory not found exceptions, if necessary
            Console.WriteLine($"Directory '{directoryPath}' not found.");
            return new string[0];
        }
    }
}
