using System;
using System.Collections.Generic;
using System.IO;

namespace Directeur_PPE3_DAO.Model.Data
{
    internal class CsvReader : IDisposable
    {
        private StreamReader reader;
        private object invariantCulture;

        public CsvReader(StreamReader reader, object invariantCulture)
        {
            this.reader = reader;
            this.invariantCulture = invariantCulture;
        }

        public object Configuration { get; internal set; }

        internal IEnumerable<theme> EnumerateRecords(theme record)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<salles> EnumerateRecords(salles record)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<avis> EnumerateRecords(avis record)
        {
            throw new NotImplementedException();
        }
    }
}