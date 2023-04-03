// See https://aka.ms/new-console-template for more information

using LogReader.Model;

List<EntryGroup> logList = new List<EntryGroup>();

//C:\\Users\\Piet Burgmans\\Documents\\IIS-Logging\\Logs\\HTTPERR\\httperr623.log
string sPath = "C:\\Users\\Piet Burgmans\\Documents\\IIS-Logging\\Logs\\HTTPERR\\httperr623.log";

logList.Add(new EntryGroup());
logList[0].ReadFile(sPath);

Console.ReadLine();