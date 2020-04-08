using System;
using System.Collections.Generic;
using System.Xml;

class Methods
{
    internal static XmlDocument GetDocument(string company, List<string> persons)
    {
        XmlDocument doc = new XmlDocument();
        XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", String.Empty);
        XmlElement root = doc.DocumentElement;

        throw new NotImplementedException();
    }
}

