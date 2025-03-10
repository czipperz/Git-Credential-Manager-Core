// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using Microsoft.Git.CredentialManager.Interop;

namespace Microsoft.Git.CredentialManager
{
    /// <summary>
    /// Represents a terminal (TTY) interface.
    /// </summary>
    public interface ITerminal
    {
        /// <summary>
        /// Write a message to the terminal screen.
        /// </summary>
        /// <param name="format">Format message to print to the terminal.</param>
        /// <param name="args">Format argument values.</param>
        /// <exception cref="InteropException">Throw if an error occurs interacting with the native terminal device.</exception>
        void WriteLine(string format, params object[] args);

        /// <summary>
        /// Prompt for user input.
        /// </summary>
        /// <param name="prompt">Prompt message.</param>
        /// <returns>User input.</returns>
        /// <exception cref="InteropException">Throw if an error occurs interacting with the native terminal device.</exception>
        string Prompt(string prompt);

        /// <summary>
        /// Prompt for secret user input.
        /// </summary>
        /// <remarks>
        /// Typed user input is masked or hidden.
        /// </remarks>
        /// <param name="prompt">Prompt message.</param>
        /// <returns>Secret user input.</returns>
        /// <exception cref="InteropException">Throw if an error occurs interacting with the native terminal device.</exception>
        string PromptSecret(string prompt);
    }
}
