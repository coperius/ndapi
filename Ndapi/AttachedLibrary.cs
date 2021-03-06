﻿using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents an attached library object.
    /// </summary>
    public class AttachedLibrary : NdapiObject<AttachedLibrary>
    {
        /// <summary>
        /// Creates an attached library in the specified module.
        /// </summary>
        /// <param name="module">Form module to attach the library.</param>
        /// <param name="location">Library location.</param>
        public AttachedLibrary(FormModule module, string location)
        {
            var status = NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module._handle, out _handle, false, location);
            Ensure.Success(status);
        }

        /// <summary>
        /// Creates an attached library in the specified module.
        /// </summary>
        /// <param name="module">Form module to attach the library.</param>
        /// <param name="location">Library location.</param>
        public AttachedLibrary(MenuModule module, string location)
        {
            var status = NativeMethods.d2falbat_Attach(NdapiContext.GetContext(), module._handle, out _handle, false, location);
            Ensure.Success(status);
        }

        internal AttachedLibrary(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment property.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets the library location.
        /// </summary>
        [Property(NdapiConstants.D2FP_LIB_LOC)]
        public string Location => GetStringProperty(NdapiConstants.D2FP_LIB_LOC);

        /// <summary>
        /// Gets the library source type.
        /// </summary>
        [Property(NdapiConstants.D2FP_LIB_SRC)]
        public SourceType SourceType => GetNumberProperty<SourceType>(NdapiConstants.D2FP_LIB_SRC);

        /// <summary>
        /// Detaches the attached library and destroy the object.
        /// </summary>
        public void Detach()
        {
            var status = NativeMethods.d2falbdt_Detach(NdapiContext.GetContext(), _handle);
            Ensure.Success(status);

            _handle = null;
        }
    }
}