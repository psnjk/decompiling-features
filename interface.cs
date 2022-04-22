interface IAnimal 
{
    /*  Based on found similarities 
    *   between Java bytecode and CIL .NET bytecode
    *   TODO - INCOMPLETE
    */  
    string generateIf(string condition, string body, string elseBody);
    string generateFunction(string id, string[] parameters, string body, string returnValue, string type);
    string generateFunctionInvocation(string invocation, string[] arguments);

    string generateWhileLoop(string condition, string body);

    string generateForLoop(string init, string condition, string increment, string body);

    string generateVariableAssignment(string type, string value);

    string generateCalc(string[] operators, string[] operands); //???

}