public class ExampleClass{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass() {
        MyProperty = 0; // Assign a default value
    }

    public void MyMethod() {
        int value = MyProperty; // Now, MyProperty is guaranteed to have a value
    }
}