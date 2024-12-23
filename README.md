# Uninitialized Property Access in C#

This repository demonstrates a common, yet easily overlooked, error in C#: accessing a class property before it has been explicitly assigned a value.  This can lead to unexpected behavior and difficult-to-debug issues, especially in larger applications.

The `UninitializedPropertyAccess.cs` file contains the problematic code.  The `UninitializedPropertyAccessSolution.cs` file shows how to correctly initialize the property.

**Problem:**
Accessing the `MyProperty` before assignment leads to it having its default value (0 for `int`).  This can be missed during testing and might not manifest immediately.

**Solution:**
Initialize the property in the constructor or explicitly assign a value before accessing it.