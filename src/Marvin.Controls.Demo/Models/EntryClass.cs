﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Marvin.Configuration;

namespace Marvin.Controls.Demo.Models
{
    public class EntrySubClass
    {
        public byte AByte { get; set; }
    }

    public class EntryClass
    {
        [Description("Represents a string"), DefaultValue("Some default")]
        public string ChainOfChars { get; set; }

        public EntrySubClass SubClass { get; set; }

        public List<EntrySubClass> ListSubClass { get; set; }

        public byte[] ArrayOfByte { get; set; }

        [FileSystemPath(FileSystemPathType.File)]
        public string File { get; set; }

        [FileSystemPath(FileSystemPathType.Directory)]
        public string Directory { get; set; }

        [Password]
        public string Password { get; set; }

        public MemoryStream Stream { get; set; }

        public string ExceptionEntry => throw new InvalidOperationException("This is ver long Exception text to test if the exception editor is readable. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.");
    }
}