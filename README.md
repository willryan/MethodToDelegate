# MethodToDelegate

Create delegates from (partially applied) methods.

MethodToDelegate partners with your Dependency Injection framework to turn a MethodInfo object into a delegate type.
If your delegate has 3 parameters and your method has 5, the first two parameters will be supplied by depedency injection.

Use the ToDelegate attribute to tag methods with the delegate type into which they should be converted.  See the tests *GenerateTest.cs for examples.

Then, use the following methods:

DelegateHelper.GetDelegateTypesAndMethods(Type) takes a Type for a class, and returns the pair of delegate type and MethodInfo for each public static method using the ToDelegate attribute.

DelegateHelper.CreateBuildInfo and DelegateHelper.BuildDelegate together will take one of the outputs from DelegateHelper.GetDelegateTypesAndMethods, partially apply the method, and create the delegate.  DelegateHelper.CreateBuildInfo can be done without needing your dependency injection framework (i.e. before all dependent types have been registered), whereas DelegateHelper.BuildDelegate requires access to your dependency injection framework (specifically how to go from Type to object of that type).

MethodToDelegate also provides extension methods for partial application - Func.Apply and Action.Apply, as well as extension methods for delegate type conversion.

TODO: Support Generic Delegates
