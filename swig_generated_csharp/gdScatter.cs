/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Imazen.LibGD.Native {

using System;
using System.Runtime.InteropServices;

public class gdScatter : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal gdScatter(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(gdScatter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~gdScatter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libgdPINVOKE.delete_gdScatter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int sub {
    set {
      libgdPINVOKE.gdScatter_sub_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdScatter_sub_get(swigCPtr);
      return ret;
    } 
  }

  public int plus {
    set {
      libgdPINVOKE.gdScatter_plus_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdScatter_plus_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_colors {
    set {
      libgdPINVOKE.gdScatter_num_colors_set(swigCPtr, value);
    } 
    get {
      uint ret = libgdPINVOKE.gdScatter_num_colors_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_int colors {
    set {
      libgdPINVOKE.gdScatter_colors_set(swigCPtr, SWIGTYPE_p_int.getCPtr(value));
    } 
    get {
      IntPtr cPtr = libgdPINVOKE.gdScatter_colors_get(swigCPtr);
      SWIGTYPE_p_int ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_int(cPtr, false);
      return ret;
    } 
  }

  public uint seed {
    set {
      libgdPINVOKE.gdScatter_seed_set(swigCPtr, value);
    } 
    get {
      uint ret = libgdPINVOKE.gdScatter_seed_get(swigCPtr);
      return ret;
    } 
  }

  public gdScatter() : this(libgdPINVOKE.new_gdScatter(), true) {
  }

}

}
