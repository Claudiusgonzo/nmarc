﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using YamlDotNet.Serialization;

namespace NMARC.Models
{
    /// <summary>
    /// Represents a user returned in the Native Mode YAML.
    /// </summary>
    public class User
    {
        [YamlMember(Alias = "name", ApplyNamingConventions = false)] public string Name { get; set; }

        [YamlMember(Alias = "id", ApplyNamingConventions = false)] public long Id { get; set; }

        [YamlMember(Alias = "email", ApplyNamingConventions = false)]
        public string Email { get; set; }

        [YamlMember(Alias = "internal", ApplyNamingConventions = false)]
        public bool Internal { get; set; }

        [YamlMember(Alias = "state", ApplyNamingConventions = false)]
        public string State { get; set; }

        [YamlMember(Alias = "roles", ApplyNamingConventions = false)]
        public object Roles { get; set; }

        [YamlMember(Alias = "last_date_accessed", ApplyNamingConventions = false)]
        public LastAccessed LastAccessed { get; set; }

        [YamlMember(Alias = "private_message_files", ApplyNamingConventions = false)]
        public long PrivateFileCount { get; set; }

        [YamlMember(Alias = "user_mapped", ApplyNamingConventions = false)]
        public bool IsUserMapped { get; set; }

        [YamlMember(Alias = "community_message_count", ApplyNamingConventions = false)]
        public object PublicMessageCount { get; set; }

        [YamlMember(Alias = "private_message_count", ApplyNamingConventions = false)]
        public object PrivateMessageCount { get; set; }

        [YamlMember(Alias = "guest_group_ids", ApplyNamingConventions = false)]
        public object GuestGroupIdList { get; set; }

        /// <summary>
        /// Gets a representation of the user as a row of CSV
        /// </summary>
        /// <returns>String containing CSV.</returns>
        public string GetCsv()
        {
            return
                $@"{Email},{Internal},{State},{PrivateFileCount},{IsUserMapped},{PublicMessageCount},{PrivateMessageCount},{LastAccessed}";
        }

        public string GetTsv()
        {
            return
                $@"{Email}\t{Internal}\t{State}\t{PrivateFileCount}\t{IsUserMapped}\t{PublicMessageCount}\t{PrivateMessageCount}";
        }
    }
}