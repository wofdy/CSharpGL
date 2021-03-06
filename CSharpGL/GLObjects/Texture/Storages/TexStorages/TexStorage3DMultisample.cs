﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    /// <summary>
    /// 
    /// </summary>
    public class TexStorage3DMultisample : TexStorageBase
    {
        private uint samples;
        private uint internalFormat;
        private uint width;
        private uint height;
        private uint depth;
        private bool fixedSampleLocations;

        internal static readonly GLDelegates.void_uint_uint_uint_uint_uint_uint_bool glTexStorage3DMultisample;
        static TexStorage3DMultisample()
        {
            glTexStorage3DMultisample = GL.Instance.GetDelegateFor("glTexStorage3DMultisample", GLDelegates.typeof_void_uint_uint_uint_uint_uint_uint_bool) as GLDelegates.void_uint_uint_uint_uint_uint_uint_bool;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="samples"></param>
        /// <param name="internalFormat"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="fixedSampleLocations"></param>
        public TexStorage3DMultisample(uint samples, uint internalFormat, uint width, uint height, uint depth, bool fixedSampleLocations)
        {
            this.samples = samples;
            this.internalFormat = internalFormat;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.fixedSampleLocations = fixedSampleLocations;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Apply()
        {
            glTexStorage3DMultisample(GL.GL_TEXTURE_2D_MULTISAMPLE_ARRAY, samples, internalFormat, width, height, depth, fixedSampleLocations);
        }

    }
}
