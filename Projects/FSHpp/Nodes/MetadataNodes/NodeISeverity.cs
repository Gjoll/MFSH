﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSHpp
{
    class NodeSeverity : NodeBase
    {
        public String Severity { get; set; }
        public NodeSeverity() { this.NodeType = "severity"; }
    }
}