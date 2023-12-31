﻿using System;
using System.Collections.Generic;

namespace MiniBus.Contracts
{
    public interface IBusConfig
    {
        int MaxRetries { get; set; }
        int SlidingRetryInterval { get; set; }
        string ReadQueue { get; set; }
        string ErrorQueue { get; set; }
        List<string> WriteQueues { get; }
        List<Action<string>> ErrorActions { get; }
        bool AutoCreateLocalQueues { get; set; }
        bool EnlistInAmbientTransactions { get; set; }
        bool JsonSerialization { get; set; }
        bool AutoDistributeOnSend { get; set; }
        bool FailFast { get; set; }
        bool DiscardFailures { get; set; }
        bool AutoPurgeSystemJournal { get; set; }
        TimeSpan TimeToBeReceived { get; set; }
        bool UseJournalQueue { get; set; }
        bool UseDeadLetterQueue { get; set; }
        bool EnvironmentalErrorsOnly { get; set; }
        bool RequireNewTransaction { get; set; }
    }
}
