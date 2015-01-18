﻿using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a tab page.
    /// </summary>
    public class TabPage : NdapiObject
    {
        /// <summary>
        /// Creates a tab page.
        /// </summary>
        /// <param name="canvas">Canvas object.</param>
        /// <param name="name">Tab page name.</param>
        public TabPage(Canvas canvas, string name) : base(name, ObjectType.TabPage, canvas)
        {
        }

        internal TabPage(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets whether the tab is enabled.
        /// </summary>
        [Property(NdapiConstants.D2FP_ENABLED)]
        public bool Enabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [Property(NdapiConstants.D2FP_LABEL)]
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets or sets whether the tab is visible.
        /// </summary>
        [Property(NdapiConstants.D2FP_VISIBLE)]
        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        /// <summary>
        /// Gets all the graphic objects attached to the canvas.
        /// </summary>
        [Property(NdapiConstants.D2FP_GRAPHIC)]
        public NdapiObjectList<Graphics> Graphics => GetObjectList<Graphics>(NdapiConstants.D2FP_GRAPHIC);
    }
}
