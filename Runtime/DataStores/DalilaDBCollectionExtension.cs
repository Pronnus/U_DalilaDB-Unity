﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.DalilaDB
{
    public static class DalilaDBCollectionExtension
    {

        public static async Task<DataOperation> SaveAsync<TCollection>(this IEnumerable<TCollection> collection) where TCollection : DalilaDBCollection<TCollection>, new()
        {
            var saved = 0;

            if (collection == null)
                throw new ArgumentNullException();


            foreach (var element in collection)
            {

                if (element == null)
                    continue;

                var opp = await element.SaveAsync().ConfigureAwait(continueOnCapturedContext: false);

                if (opp)
                    saved++;

            }

            return new DataOperation().Successful(saved + "");
        }

        public async static Task<DataOperation> SaveNewAsync<TCollection>(this IEnumerable<TCollection> collection) where TCollection : DalilaDBCollection<TCollection>, new()
        {
            var saved = 0;

            if (collection == null)
                throw new ArgumentNullException();


            foreach (var element in collection)
            {

                if (element == null)
                    continue;

                var opp = await element.SaveNewAsync().ConfigureAwait(continueOnCapturedContext: false);

                if (opp)
                    saved++;

            }

            return new DataOperation().Successful(saved + "");
        }

        public static DataOperation Save<TCollection>(this IEnumerable<TCollection> collection) where TCollection : DalilaDBCollection<TCollection>, new()
        {
            var saved = 0;

            if (collection == null)
                throw new ArgumentNullException();


            foreach (var element in collection)
            {

                if (element == null)
                    continue;

                var opp = element.Save();

                if (opp)
                    saved++;

            }

            return new DataOperation().Successful(saved + "");
        }

        public static DataOperation SaveNew<TCollection>(this IEnumerable<TCollection> collection) where TCollection : DalilaDBCollection<TCollection>, new()
        {
            var saved = 0;

            if (collection == null)
                throw new ArgumentNullException();


            foreach (var element in collection)
            {

                if (element == null)
                    continue;

                var opp = element.SaveNew();

                if (opp)
                    saved++;

            }

            return new DataOperation().Successful(saved + "");
        }

    }
}
