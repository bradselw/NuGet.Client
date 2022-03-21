// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// Do not manually edit this autogenerated file:
// instead modify the neighboring .tt file (text template) and/or NuGet.CommandLine.Xplat\Commands\Commands.xml (data file),
// then re-execute the text template via "run custom tool" on VS context menu for .tt file, or via dotnet-t4 global tool.

using System;
using Microsoft.Extensions.CommandLineUtils;
using NuGet.Commands;
using NuGet.Common;

namespace NuGet.CommandLine.XPlat
{
    internal partial class AddVerbParser
    {
        internal static void Register(CommandLineApplication app,
                                      Func<ILogger> getLogger)
        {
            app.Command("add", AddCmd =>
            {
                AddCmd.Command("source", SourceCmd =>
                {
                    CommandArgument Source = SourceCmd.Argument(
                        "PackageSourcePath", Strings.SourcesCommandSourceDescription);
                    CommandOption name = SourceCmd.Option(
                        "-n|--name",
                        Strings.SourcesCommandNameDescription,
                        CommandOptionType.SingleValue);
                    CommandOption username = SourceCmd.Option(
                        "-u|--username",
                        Strings.SourcesCommandUsernameDescription,
                        CommandOptionType.SingleValue);
                    CommandOption password = SourceCmd.Option(
                        "-p|--password",
                        Strings.SourcesCommandPasswordDescription,
                        CommandOptionType.SingleValue);
                    CommandOption storePasswordInClearText = SourceCmd.Option(
                        "--store-password-in-clear-text",
                        Strings.SourcesCommandStorePasswordInClearTextDescription,
                        CommandOptionType.NoValue);
                    CommandOption validAuthenticationTypes = SourceCmd.Option(
                        "--valid-authentication-types",
                        Strings.SourcesCommandValidAuthenticationTypesDescription,
                        CommandOptionType.SingleValue);
                    CommandOption configfile = SourceCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    SourceCmd.HelpOption("-h|--help");
                    SourceCmd.Description = Strings.AddSourceCommandDescription;
                    SourceCmd.OnExecute(() =>
                    {
                        var args = new AddSourceArgs()
                        {
                            Source = Source.Value,
                            Name = name.Value(),
                            Username = username.Value(),
                            Password = password.Value(),
                            StorePasswordInClearText = storePasswordInClearText.HasValue(),
                            ValidAuthenticationTypes = validAuthenticationTypes.Value(),
                            Configfile = configfile.Value(),
                        };

                        AddSourceRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                AddCmd.Command("client-cert", ClientCertCmd =>
                {
                    CommandOption packagesource = ClientCertCmd.Option(
                        "-s|--package-source",
                        Strings.Option_PackageSource,
                        CommandOptionType.SingleValue);
                    CommandOption path = ClientCertCmd.Option(
                        "--path",
                        Strings.Option_Path,
                        CommandOptionType.SingleValue);
                    CommandOption password = ClientCertCmd.Option(
                        "--password",
                        Strings.Option_Password,
                        CommandOptionType.SingleValue);
                    CommandOption storepasswordincleartext = ClientCertCmd.Option(
                        "--store-password-in-clear-text",
                        Strings.Option_StorePasswordInClearText,
                        CommandOptionType.NoValue);
                    CommandOption storelocation = ClientCertCmd.Option(
                        "--store-location",
                        Strings.Option_StoreLocation,
                        CommandOptionType.SingleValue);
                    CommandOption storename = ClientCertCmd.Option(
                        "--store-name",
                        Strings.Option_StoreName,
                        CommandOptionType.SingleValue);
                    CommandOption findby = ClientCertCmd.Option(
                        "--find-by",
                        Strings.Option_FindBy,
                        CommandOptionType.SingleValue);
                    CommandOption findvalue = ClientCertCmd.Option(
                        "--find-value",
                        Strings.Option_FindValue,
                        CommandOptionType.SingleValue);
                    CommandOption force = ClientCertCmd.Option(
                        "-f|--force",
                        Strings.Option_Force,
                        CommandOptionType.NoValue);
                    CommandOption configfile = ClientCertCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    ClientCertCmd.HelpOption("-h|--help");
                    ClientCertCmd.Description = Strings.AddClientCertCommandDescription;
                    ClientCertCmd.OnExecute(() =>
                    {
                        var args = new AddClientCertArgs()
                        {
                            PackageSource = packagesource.Value(),
                            Path = path.Value(),
                            Password = password.Value(),
                            StorePasswordInClearText = storepasswordincleartext.HasValue(),
                            StoreLocation = storelocation.Value(),
                            StoreName = storename.Value(),
                            FindBy = findby.Value(),
                            FindValue = findvalue.Value(),
                            Force = force.HasValue(),
                            Configfile = configfile.Value(),
                        };

                        AddClientCertRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                AddCmd.HelpOption("-h|--help");
                AddCmd.Description = Strings.Add_Description;
                AddCmd.OnExecute(() =>
                {
                    app.ShowHelp("add");
                    return 0;
                });
            });
        }
    }

    internal partial class DisableVerbParser
    {
        internal static void Register(CommandLineApplication app,
                                      Func<ILogger> getLogger)
        {
            app.Command("disable", DisableCmd =>
            {
                DisableCmd.Command("source", SourceCmd =>
                {
                    CommandArgument name = SourceCmd.Argument(
                        "name", Strings.SourcesCommandNameDescription);
                    CommandOption configfile = SourceCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    SourceCmd.HelpOption("-h|--help");
                    SourceCmd.Description = Strings.DisableSourceCommandDescription;
                    SourceCmd.OnExecute(() =>
                    {
                        var args = new DisableSourceArgs()
                        {
                            Name = name.Value,
                            Configfile = configfile.Value(),
                        };

                        DisableSourceRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                DisableCmd.HelpOption("-h|--help");
                DisableCmd.Description = Strings.Disable_Description;
                DisableCmd.OnExecute(() =>
                {
                    app.ShowHelp("disable");
                    return 0;
                });
            });
        }
    }

    internal partial class EnableVerbParser
    {
        internal static void Register(CommandLineApplication app,
                                      Func<ILogger> getLogger)
        {
            app.Command("enable", EnableCmd =>
            {
                EnableCmd.Command("source", SourceCmd =>
                {
                    CommandArgument name = SourceCmd.Argument(
                        "name", Strings.SourcesCommandNameDescription);
                    CommandOption configfile = SourceCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    SourceCmd.HelpOption("-h|--help");
                    SourceCmd.Description = Strings.EnableSourceCommandDescription;
                    SourceCmd.OnExecute(() =>
                    {
                        var args = new EnableSourceArgs()
                        {
                            Name = name.Value,
                            Configfile = configfile.Value(),
                        };

                        EnableSourceRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                EnableCmd.HelpOption("-h|--help");
                EnableCmd.Description = Strings.Enable_Description;
                EnableCmd.OnExecute(() =>
                {
                    app.ShowHelp("enable");
                    return 0;
                });
            });
        }
    }

    internal partial class RemoveVerbParser
    {
        internal static void Register(CommandLineApplication app,
                                      Func<ILogger> getLogger)
        {
            app.Command("remove", RemoveCmd =>
            {
                RemoveCmd.Command("source", SourceCmd =>
                {
                    CommandArgument name = SourceCmd.Argument(
                        "name", Strings.SourcesCommandNameDescription);
                    CommandOption configfile = SourceCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    SourceCmd.HelpOption("-h|--help");
                    SourceCmd.Description = Strings.RemoveSourceCommandDescription;
                    SourceCmd.OnExecute(() =>
                    {
                        var args = new RemoveSourceArgs()
                        {
                            Name = name.Value,
                            Configfile = configfile.Value(),
                        };

                        RemoveSourceRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                RemoveCmd.Command("client-cert", ClientCertCmd =>
                {
                    CommandOption packagesource = ClientCertCmd.Option(
                        "-s|--package-source",
                        Strings.Option_PackageSource,
                        CommandOptionType.SingleValue);
                    CommandOption configfile = ClientCertCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    ClientCertCmd.HelpOption("-h|--help");
                    ClientCertCmd.Description = Strings.RemoveClientCertCommandDescription;
                    ClientCertCmd.OnExecute(() =>
                    {
                        var args = new RemoveClientCertArgs()
                        {
                            PackageSource = packagesource.Value(),
                            Configfile = configfile.Value(),
                        };

                        RemoveClientCertRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                RemoveCmd.HelpOption("-h|--help");
                RemoveCmd.Description = Strings.Remove_Description;
                RemoveCmd.OnExecute(() =>
                {
                    app.ShowHelp("remove");
                    return 0;
                });
            });
        }
    }

    internal partial class UpdateVerbParser
    {
        internal static void Register(CommandLineApplication app,
                                      Func<ILogger> getLogger)
        {
            app.Command("update", UpdateCmd =>
            {
                UpdateCmd.Command("source", SourceCmd =>
                {
                    CommandArgument name = SourceCmd.Argument(
                        "name", Strings.SourcesCommandNameDescription);
                    CommandOption source = SourceCmd.Option(
                        "-s|--source",
                        Strings.SourcesCommandSourceDescription,
                        CommandOptionType.SingleValue);
                    CommandOption username = SourceCmd.Option(
                        "-u|--username",
                        Strings.SourcesCommandUsernameDescription,
                        CommandOptionType.SingleValue);
                    CommandOption password = SourceCmd.Option(
                        "-p|--password",
                        Strings.SourcesCommandPasswordDescription,
                        CommandOptionType.SingleValue);
                    CommandOption storePasswordInClearText = SourceCmd.Option(
                        "--store-password-in-clear-text",
                        Strings.SourcesCommandStorePasswordInClearTextDescription,
                        CommandOptionType.NoValue);
                    CommandOption validAuthenticationTypes = SourceCmd.Option(
                        "--valid-authentication-types",
                        Strings.SourcesCommandValidAuthenticationTypesDescription,
                        CommandOptionType.SingleValue);
                    CommandOption configfile = SourceCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    SourceCmd.HelpOption("-h|--help");
                    SourceCmd.Description = Strings.UpdateSourceCommandDescription;
                    SourceCmd.OnExecute(() =>
                    {
                        var args = new UpdateSourceArgs()
                        {
                            Name = name.Value,
                            Source = source.Value(),
                            Username = username.Value(),
                            Password = password.Value(),
                            StorePasswordInClearText = storePasswordInClearText.HasValue(),
                            ValidAuthenticationTypes = validAuthenticationTypes.Value(),
                            Configfile = configfile.Value(),
                        };

                        UpdateSourceRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                UpdateCmd.Command("client-cert", ClientCertCmd =>
                {
                    CommandOption packagesource = ClientCertCmd.Option(
                        "-s|--package-source",
                        Strings.Option_PackageSource,
                        CommandOptionType.SingleValue);
                    CommandOption path = ClientCertCmd.Option(
                        "--path",
                        Strings.Option_Path,
                        CommandOptionType.SingleValue);
                    CommandOption password = ClientCertCmd.Option(
                        "--password",
                        Strings.Option_Password,
                        CommandOptionType.SingleValue);
                    CommandOption storepasswordincleartext = ClientCertCmd.Option(
                        "--store-password-in-clear-text",
                        Strings.Option_StorePasswordInClearText,
                        CommandOptionType.NoValue);
                    CommandOption storelocation = ClientCertCmd.Option(
                        "--store-location",
                        Strings.Option_StoreLocation,
                        CommandOptionType.SingleValue);
                    CommandOption storename = ClientCertCmd.Option(
                        "--store-name",
                        Strings.Option_StoreName,
                        CommandOptionType.SingleValue);
                    CommandOption findby = ClientCertCmd.Option(
                        "--find-by",
                        Strings.Option_FindBy,
                        CommandOptionType.SingleValue);
                    CommandOption findvalue = ClientCertCmd.Option(
                        "--find-value",
                        Strings.Option_FindValue,
                        CommandOptionType.SingleValue);
                    CommandOption force = ClientCertCmd.Option(
                        "-f|--force",
                        Strings.Option_Force,
                        CommandOptionType.NoValue);
                    CommandOption configfile = ClientCertCmd.Option(
                        "--configfile",
                        Strings.Option_ConfigFile,
                        CommandOptionType.SingleValue);
                    ClientCertCmd.HelpOption("-h|--help");
                    ClientCertCmd.Description = Strings.UpdateClientCertCommandDescription;
                    ClientCertCmd.OnExecute(() =>
                    {
                        var args = new UpdateClientCertArgs()
                        {
                            PackageSource = packagesource.Value(),
                            Path = path.Value(),
                            Password = password.Value(),
                            StorePasswordInClearText = storepasswordincleartext.HasValue(),
                            StoreLocation = storelocation.Value(),
                            StoreName = storename.Value(),
                            FindBy = findby.Value(),
                            FindValue = findvalue.Value(),
                            Force = force.HasValue(),
                            Configfile = configfile.Value(),
                        };

                        UpdateClientCertRunner.Run(args, getLogger);
                        return 0;
                    });
                });
                UpdateCmd.HelpOption("-h|--help");
                UpdateCmd.Description = Strings.Update_Description;
                UpdateCmd.OnExecute(() =>
                {
                    app.ShowHelp("update");
                    return 0;
                });
            });
        }
    }

}
