﻿namespace RSAcli.Facade
{
    using CommandLine;
    using Options;

    static partial class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<GenerateRSAKeyPair, EncryptVerbOptions, DecryptVerbOptions>(args)
                .WithParsed<EncryptVerbOptions>(ProcessEncryptCommand)
                .WithParsed<DecryptVerbOptions>(ProcessDecryptCommand)
                .WithParsed<GenerateRSAKeyPair>(ProcessGenerateRSAKeyPairCommand);
        }
    }
}