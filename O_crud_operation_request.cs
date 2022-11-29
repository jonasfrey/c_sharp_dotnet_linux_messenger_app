class O_crud_operation_request
{
    public string s_model_name {get; set;}
    public string s_function_name {get; set;}
    public object[] a_o {get; set;}
    public O_crud_operation_request(
        string s_model_name__param,
        string s_function_name__param,
        object[] a_o__param
    )
    {
        s_model_name = s_model_name__param;
        s_function_name = s_function_name__param;
        a_o = a_o__param;
    }
}