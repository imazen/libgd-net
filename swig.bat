mkdir swig_generated_csharp
mkdir swig_generated_c
"C:\Users\nathanael\Downloads\swigwin-2.0.11\swigwin-2.0.11\swig.exe" -csharp -namespace Imazen.LibGD.Native -outdir swig_generated_csharp -o "swig_generated_c/swig_libgd.c" "../gd-libgd/windows/libgd_swig.i"

pause