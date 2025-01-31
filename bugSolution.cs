public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 0; // Or provide a more meaningful default value.
        int value = MyProperty;
    }
}