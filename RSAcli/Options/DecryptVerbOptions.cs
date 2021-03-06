﻿namespace RSAcli.Options
{
    using System.Collections.Generic;
    using CommandLine;
    using CommandLine.Text;
    using Interfaces;

    [Verb("dec", HelpText = "Enforces file decryption with the specified key RSA private key.")]
    class DecryptVerbOptions : IOutputableOption
    {
        [Option('i', "input", Required = true,
            HelpText = "Source file containing the data to be decrypted with RAS private key.")]
        public string InputFilePath { get; set; }

        [Option('k', "key", Required = true,
            HelpText = "Path to file containing RSA public key for decryption of data from supplied file.")]
        public string KeyPath { get; set; }

        [Option('o', "output",
            HelpText = "Output File Name. This file will contain the result of the encryption operation.")]
        public string OutputFilePath { get; set; }

        [Usage(ApplicationAlias = "RSAcli")]
        public static IEnumerable<Example> Examples
        {
            get {
                yield return new Example("Decryption", new EncryptVerbOptions
                {
                    KeyPath = "Secret-4096bits.private",
                    InputFilePath = "ToBeDecrypted.ext",
                    OutputFilePath = "Decrypted.ext"
                });
            }
        }
    }
}