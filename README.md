# MethodToDelegate

Create delegates from (partially applied) methods.

MethodToDelegate partners with your Dependency Injection framework to turn a `MethodInfo` object into a delegate type. It uses partially application on the first N arguments of your method that are not found in the delegate signature. For example, if your delegate has 3 parameters and your method has 5, the first 2 parameters will be supplied by depedency injection.

See the files in MethodToDelegate.Test/ for examples on how to set up delegate-based dependency injection on methods, how to wire them into your dependency injection framework, and how to run unit tests against your methods. Here are the basic instructions:

1. Use the `ToDelegate` attribute to tag methods with the delegate type into which they should be converted. Then, use the following methods:

2. `DelegateHelper.GetDelegateTypesAndMethods(Type)` takes a `Type` for a class, and returns the pair of delegate `Type` and `MethodInfo` for each `public static` method using the `ToDelegate` attribute.

3. `DelegateHelper.CreateBuildInfo` and `DelegateHelper.BuildDelegate` together will take one of the outputs from `DelegateHelper.GetDelegateTypesAndMethods`, partially apply the method, and create the delegate.  `DelegateHelper.CreateBuildInfo` can be done without needing your dependency injection framework (i.e. before all dependent types have been registered), whereas `DelegateHelper.BuildDelegate` requires access to your dependency injection framework (specifically how to go from Type to object of that type).

MethodToDelegate also provides extension methods for partial application - `Func.Apply` and `Action.Apply`, as well as extension methods for delegate `Type` conversion.

TODO: Support Generic Delegates
