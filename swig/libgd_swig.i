 %module libgd
 %{
 /* Includes the header in the wrapper code */
 #include "../../gd-libgd/src/gd.h"
 %}
 
 /* Parse the header file to generate wrappers */
 %include "../../gd-libgd/src/gd.h"