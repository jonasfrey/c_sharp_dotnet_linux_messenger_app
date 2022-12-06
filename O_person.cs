
//{"s_msg":"this file was automatically generated","s_by":"f_create_csharp_class.module.js","s_ts_created":"Mon Dec 05 2022 23:28:14 GMT+0100 (Central European Standard Time)","n_ts_created":1670279294682}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
public class O_person{
    
    [Key]
    public int n_id { get; set; } = default!;
    public string s_name { get; set; } = default!;
    public List<O_message> O_Messages {get;} = new();



}
