// File Scoped Namespace
// { } not needed --> less intend
namespace CSharp_10._0;

public class NullParameterChecking
{
    public void SomeMethod(string myParameter)
    {
        // add ! after string myParameter and the null check will be created automatically
        if (myParameter == null)
        {
            throw new ArgumentNullException(nameof(myParameter));
        }
    }
}
