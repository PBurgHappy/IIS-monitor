using System.Globalization;

namespace LogReader.Model;

public class LogEntry
{
    // Time AND date or datetime?
    public DateTime Timestamp;
    // Move UserIP outside of singular entry? It's the key for grouping entries.
    public string UserIp;
    public string UserPort;
    public string ServerIp;
    public string ServerPort;
    public string Version;

    public string Method;
    public string Uri;
    public string Streamid;
    public string Status;
    public string Siteid;
    public string Reason;
    public string QueueName;

    public int LineNumber;
    // redundant? 
    
    public LogEntry()
    {
        
    }

// Make EntryHandler, add list there
// Multiple "processing" functions, depending on input file format
    public LogEntry(string[] items)
    {
        // string[] dateSplit = items[0].Split("-");
        if (DateTime.TryParseExact(items[0] + " " + items[1],
                "yyyy-MM-dd HH:mm:ss",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out Timestamp))
        {
            
        }
        else
        {
            // failed parsing datetime
        }
    }
}