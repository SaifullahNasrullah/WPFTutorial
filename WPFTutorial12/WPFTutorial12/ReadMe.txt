ObservableCollection?
  - is a dynamic collection of objects of a given type.
  - Objects can be added.
  - Object can be removed.
  - Objects can be updated.
with an automict notification of actions.

When an object is added to or removed from an observable collection, the UI is automatically updated.
This happens because, when binding to an observable collection, WPF automatically adds a CollectionChanged event handler to the ObservableCollecion's events.

-------------------------------------------------------------------------------------------------------------------------------------------
[CallerMemberName] is an attribute introduced in C# 5.0, which allows you to obtain the method or property name of the caller to the method.