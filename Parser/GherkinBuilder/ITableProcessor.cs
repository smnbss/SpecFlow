﻿using TechTalk.SpecFlow.Parser.SyntaxElements;

namespace TechTalk.SpecFlow.Parser.GherkinBuilder
{
    internal interface ITableProcessor
    {
        void ProcessTableRow(string[] row, int lineNumber);
    }
}