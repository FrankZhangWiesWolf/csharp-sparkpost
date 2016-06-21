﻿using System;
using System.Collections.Generic;

namespace SparkPost
{
    public class RetrieveTemplatesResponse : Response
    {
        public RetrieveTemplatesResponse()
        {
            Templates = new List<Template>();
        }

        public List<Template> Templates { get; set; }

        public class Template
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Published { get; set; }
            public DateTime LastUpdateTime { get; set; }
        }
    }
}