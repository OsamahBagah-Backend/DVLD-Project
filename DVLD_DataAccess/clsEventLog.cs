using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

public static class clsEventLog
{
    public static void EventLogException(string Message, EventLogEntryType EventLogEntryType)
    {
        string SourceName = "DVLD App";
        try
        {
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");

            }
            EventLog.WriteEntry(SourceName, Message, EventLogEntryType);
        }
        catch (Exception ex)
        {
            EventLog.WriteEntry(SourceName, "Exception in logException Method : " + ex.Message, EventLogEntryType);
        }
    }
}

