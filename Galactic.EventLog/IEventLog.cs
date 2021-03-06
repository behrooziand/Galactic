﻿using System;
using System.Collections.Generic;

namespace Galactic.EventLog
{
    /// <summary>
    /// An interface for classes that wish to implement functionality that allows them to be a catalog of application events.
    /// </summary>
    public interface IEventLog
    {
        // ---------- PROPERTIES ----------

        // ---------- METHODS ----------

        /// <summary>
        /// Finds events that match the filters provided.
        /// See each parameter for information on how to filter the search.
        /// </summary>
        /// <param name="source">Searches for all events with sources that match the string provided. Returns events of all sources on a null or empty string.</param>
        /// <param name="severity">Searches for events with the specified severity level. Returns events of all severity levels on null.</param>
        /// <param name="category">Searches for events with categories that match the string provided. Returns events of all categories on a null or empty string.</param>
        /// <param name="begin">Returns events with a date/time on or after the date/time supplied. Does not put a lower range on event dates on a null date/time.</param>
        /// <param name="end">Returns events with a date/time on or before the date/time supplied. Does not put an upper range on event dates on a null date/time.</param>
        /// <returns>A list of events sorted from earliest to latest that match the given search parameters.</returns>
        List<Event> Find(string source, Event.SeverityLevels? severity, string category, DateTime? begin, DateTime? end);

        /// <summary>
        /// Logs the event to the event log.
        /// </summary>
        /// <param name="eventToLog">The event to log.</param>
        /// <returns>True if the event was logged successfully. False otherwise.</returns>
        bool Log(Event eventToLog);
    }
}
