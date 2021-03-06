// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Wes Day">
//   Copyright (c) 2015 Wes Day
//   
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//   
//          http://www.apache.org/licenses/LICENSE-2.0
//   
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Reviewed", Scope = "member", Target = "Serilog.LoggerConfigurationKafkaExtensions.#Kafka(Serilog.Configuration.LoggerSinkConfiguration,System.String,System.String,System.String,Serilog.Events.LogEventLevel,System.Int32,System.Nullable`1<System.TimeSpan>,System.IFormatProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "Reviewed", MessageId = "restrictedToMinimumLevel", Scope = "member", Target = "Serilog.LoggerConfigurationKafkaExtensions.#Kafka(Serilog.Configuration.LoggerSinkConfiguration,System.String,System.String,System.String,Serilog.Events.LogEventLevel,System.Int32,System.Nullable`1<System.TimeSpan>,System.IFormatProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "Reviewed", MessageId = "formatProvider", Scope = "member", Target = "Serilog.LoggerConfigurationKafkaExtensions.#Kafka(Serilog.Configuration.LoggerSinkConfiguration,System.String,System.String,System.String,Serilog.Events.LogEventLevel,System.Int32,System.Nullable`1<System.TimeSpan>,System.IFormatProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Reviewed", Scope = "member", Target = "Serilog.Sinks.Kafka.KafkaSink.#.ctor(Serilog.Sinks.Kafka.KafkaSinkOptions,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Justification = "Reviewed", Scope = "member", Target = "Serilog.LoggerConfigurationKafkaExtensions.#Kafka(Serilog.Configuration.LoggerSinkConfiguration,System.String,System.String,System.String,Serilog.Events.LogEventLevel,System.Int32,System.Nullable`1<System.TimeSpan>,System.IFormatProvider)")]
