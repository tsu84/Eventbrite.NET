using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventbriteNET.Entities
{
    public class Answer : EntityBase
    {
        public string id, question, answer;
        public Answer(EventbriteContext context) : base(context) { }
    }
}
