// Task 3: File Download Simulation
// Task: Create a class FileDownload with:
// Constructor that prints "Download started".
// Add a destructor that prints "Download completed".
// In Main(), create an object inside a method and observe when the destructor is called.

class FileDownload
{
    private string filename;


    public FileDownload(string filename)
    {   
        this.filename = filename; 
        Console.WriteLine($"this file {this.FileName} download started");
    }

    public string FileName
    {
        get { return filename; }
    }

    ~FileDownload()
    {
        Console.WriteLine("Download completed");
    }
}


class Program
{
    public static void Main(string[] args)
    {
        FileDownload file = new FileDownload("file.txt");
        // GC.Collect();
        // GC.WaitForPendingFinalizers();

    }
}