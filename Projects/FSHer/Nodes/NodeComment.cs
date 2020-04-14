﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FSHer
{
    class NodeComment : NodeBase
    {
        public String Comment;

        public NodeComment(String comment) : base()
        {
            this.Comment = comment;
        }

        public NodeComment() : base()
        {
        }

        public override string ToString() => Dump("");
        public override string ToFSH() => this.Comment;
        public override string Dump(String margin) => 
            $"{margin}Comment: '{this.Comment.Replace("\n", "\\n")}'";

        public override NodeBase Clone()
        {
            NodeComment retVal = new NodeComment();
            this.CopyTo(retVal);
            return retVal;
        }

        public override void CopyTo(NodeBase itemBase)
        {
            NodeComment item = (NodeComment) itemBase;
            base.CopyTo(item);
            item.Comment = this.Comment;
        }
    }
}
