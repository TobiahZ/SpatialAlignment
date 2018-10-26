﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Persistence;

namespace Microsoft.SpatialAlignment
{
    /// <summary>
    /// An alignment strategy that attaches the object to one or more world anchors.
    /// </summary>
    public class MultiAnchorAlignment : AlignmentStrategy
    {
        #region Member Variables
        static private WorldAnchorStore anchorStore;
        #endregion // Member Variables

        #region Unity Inspector Variables
        public string AnchorId;
        #endregion // Unity Inspector Variables

        private void LoadAnchor()
        {

        }

        private void LoadStoreAndAnchor()
        {
            // If no store, attempt to acquire it then load
            if (anchorStore == null)
            {
                // Get store via callback
                WorldAnchorStore.GetAsync((WorldAnchorStore store) =>
                {
                    // Store acquired?
                    if (store != null)
                    {
                        anchorStore = store;
                        LoadAnchor();
                    }
                    else
                    {
                        // TODO: WARN
                    }
                });
            }
            else
            {
                // Already have a store, just load the anchor.
                LoadAnchor();
            }
        }

        protected virtual void Awake()
        {

        }

        // Start is called before the first frame update
        protected virtual void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}