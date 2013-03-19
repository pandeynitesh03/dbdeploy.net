﻿namespace Net.Sf.Dbdeploy.Scripts
{
    /// <summary>
    /// Status of the script execution.
    /// </summary>
    public enum ScriptStatus
    {
        /// <summary>
        /// The script failed to execute fully.
        /// </summary>
        Failed = 0,

        /// <summary>
        /// The script ran successfully.
        /// </summary>
        Success = 1,

        /// <summary>
        /// The problem was resolved from a previous script failure, and it should be retried.
        /// </summary>
        ProblemResolved = 2
    }
}
