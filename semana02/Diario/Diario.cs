using System;
using System.Diagnostics;

public class Diario


{
    {
        Diario criar = new Diario();
        object value = Console.WriteLine("teste");

    }
}

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Diario : NewBaseType
{
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}