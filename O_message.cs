
//{"s_msg":"this file was automatically generated","s_by":"f_create_csharp_class.module.js","s_ts_created":"Mon Dec 05 2022 23:28:14 GMT+0100 (Central European Standard Time)","n_ts_created":1670279294682}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
public class O_message{
    [Key]
    public int n_id { get; set; } = default!;
    public string s_markdown { get; set; } = default!;
    
    [ForeignKey("n_o_person_n_id")]
    public int n_o_person_n_id {get; set;} = default!;
    public O_person O_person {get;set;} = default!;



}
