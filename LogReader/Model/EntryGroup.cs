namespace LogReader.Model;

public class EntryGroup
{
    public string UserIp;
    public LogEntry Entry;

    public EntryGroup()
    {
        
    }

    public EntryGroup(string newEntry)
    {
        
    }

    public void ReadFile(string sPath)
    {
        //Basic read
        using (StreamReader sr = new StreamReader(sPath))
        {
            // Keep track of known IPs so relevant entries can be grouped.
            List<string> KnownIPs = new List<string>();
            // #Fields: date time c-ip c-port s-ip s-port cs-version cs-method cs-uri streamid sc-status s-siteid s-reason s-queuename
            string line = "";
            int lineNumber = 0;
            while ((line = sr.ReadLine()) != null)
            {
                lineNumber++;
                if (line.Substring(0, 1) == "#")
                {
                    continue;
                }

                string[] newEntry = line.Split(" ");

                if (!(KnownIPs.Contains(newEntry[2])))
                {
                    KnownIPs.Add(newEntry[2]);

                }

                LogEntry newLog = new LogEntry();
        
            }
        };
    }
}