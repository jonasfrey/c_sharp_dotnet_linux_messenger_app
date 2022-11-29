class O_crud_operation_response
{
    public string s_model_name {get; set;}
    public string s_function_name {get; set;}
    public O_crud_operation_response(
        string s_model_name__param,
        string s_function_name__param
    )
    {
        s_model_name = s_model_name__param;
        s_function_name = s_function_name__param;
    }
}