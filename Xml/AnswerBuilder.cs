using EventbriteNET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace EventbriteNET.Xml
{
    class AnswerBuilder : BuilderBase
    {
        public AnswerBuilder(EventbriteContext context) : base(context) { }

        public Answer Build(string xmlString)
        {
            this.Validate(xmlString);

            var toReturn = new Answer(this.Context);

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            toReturn.id = TryGetElementValue("question_id", doc);
            toReturn.question = TryGetElementValue("question", doc);
            toReturn.answer = TryGetElementValue("answer_text", doc);

            return toReturn;
        }
    }
}
