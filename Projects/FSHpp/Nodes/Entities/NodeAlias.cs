﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSHpp
{
    class NodeAlias : NodeBase
    {
        public String Name;
        public String Value;

        public NodeAlias() {this.NodeType = "alias"; }
    }
}