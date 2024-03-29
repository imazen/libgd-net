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

public class gdFont : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal gdFont(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(gdFont obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~gdFont() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libgdPINVOKE.delete_gdFont(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int nchars {
    set {
      libgdPINVOKE.gdFont_nchars_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdFont_nchars_get(swigCPtr);
      return ret;
    } 
  }

  public int offset {
    set {
      libgdPINVOKE.gdFont_offset_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdFont_offset_get(swigCPtr);
      return ret;
    } 
  }

  public int w {
    set {
      libgdPINVOKE.gdFont_w_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdFont_w_get(swigCPtr);
      return ret;
    } 
  }

  public int h {
    set {
      libgdPINVOKE.gdFont_h_set(swigCPtr, value);
    } 
    get {
      int ret = libgdPINVOKE.gdFont_h_get(swigCPtr);
      return ret;
    } 
  }

  public string data {
    set {
      libgdPINVOKE.gdFont_data_set(swigCPtr, value);
    } 
    get {
      string ret = libgdPINVOKE.gdFont_data_get(swigCPtr);
      return ret;
    } 
  }

  public gdFont() : this(libgdPINVOKE.new_gdFont(), true) {
  }

}

}
