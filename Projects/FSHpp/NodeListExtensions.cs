﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSHpp
{
    public static class NodeListExtensions
    {
        /// <summary>
        /// Return only the NodeTokens in list with the TokenName.
        /// </summary>
        public static IEnumerable<NodeToken> WithTokenName(this IEnumerable<NodeToken> items,
            String tokenName)
        {
            foreach (NodeToken item in items)
            {
                if (item.TokenName == tokenName)
                    yield return item;
            }
        }

        /// <summary>
        /// Return only the NodeTokens in list.
        /// </summary>
        public static IEnumerable<NodeToken> Tokens(this IEnumerable<NodeBase> items)
        {
            foreach (NodeBase item in items)
            {
                NodeToken t = item as NodeToken;
                if (t != null)
                    yield return t;
            }
        }

        /// <summary>
        /// Return only the NodeRules in list.
        /// </summary>
        public static IEnumerable<NodeRule> Rules(this IEnumerable<NodeBase> items)
        {
            foreach (NodeBase item in items)
            {
                NodeRule r = item as NodeRule;
                if (r != null)
                    yield return r;
            }
        }
    }
}
