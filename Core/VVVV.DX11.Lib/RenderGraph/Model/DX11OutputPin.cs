﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVVV.DX11.RenderGraph.Model
{
    public class DX11OutputPin : DX11Pin
    {

        public DX11OutputPin(DX11Node parentnode) : base(parentnode) 
        {
            this.ChildrenPins = new List<DX11InputPin>();
            this.ParentNode.OutputPins.Add(this);
        }

        public List<DX11InputPin> ChildrenPins { get; private set; }

    }
}
