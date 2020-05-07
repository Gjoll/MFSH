﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MFSH
{
    public class StackFrame
    {
        public VariablesBlock FrameVariables = new VariablesBlock();
        public List<FileData> Redirections = new List<FileData>();
        public FileData Data;

        public StackFrame()
        {
            this.Data = new FileData();
        }
    }
}