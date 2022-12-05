import { O_model } from "./O_model.module.js"
import { O_model_property } from "./O_model_property.module.js"

var f_o__cloned = function(o){

    return Object.assign(Object.create(Object.getPrototypeOf(o)), o);

}
var a_o_model = [];

var o_model_property__n_id_default_id = new O_model_property(
    "n_id", 
    "integer", 
    false, 
    null, 
    null, 
    null,
    null, 
    null, 
    null, 
    true, 
    true, 
    true, 
    null
);

var o_model__o_person = new O_model(
    "O_person",
    [
        f_o__cloned(o_model_property__n_id_default_id),
        new O_model_property(
            "s_name", 
            "string",
        ),
    ]
);
a_o_model.push(o_model__o_person);

var o_model__o_chatroom = new O_model(
    "O_chatroom", 
    [
        f_o__cloned(o_model_property__n_id_default_id),
        new O_model_property(
            "s_name", 
            "string",
        ),
    ]
);
a_o_model.push(o_model__o_chatroom);

var o_model__o_message =     new O_model(
    "O_message", 
    [
        f_o__cloned(o_model_property__n_id_default_id),
        new O_model_property(
            "s_markdown", 
            "string",
        ),
    ]
);
a_o_model.push(o_model__o_message);



var o_model__o_person_o_chatroom_o_message =     new O_model(
    "O_person_o_chatroom_o_message", 
    [
        f_o__cloned(o_model_property__n_id_default_id),
        new O_model_property(
            "n_o_person_n_id",  
            "number",
            null,
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            o_model__o_person.a_o_model_property.filter(o=>o.s_name=="n_id")[0], 
            true,
            true
        ),
        new O_model_property(
            "n_o_chatroom_n_id",  
            "number",
            null,
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            o_model__o_chatroom.a_o_model_property.filter(o=>o.s_name=="n_id")[0], 
            true,
            true
        ),
        new O_model_property(
            "n_o_message_n_id",  
            "number",
            null,
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            null, 
            o_model__o_message.a_o_model_property.filter(o=>o.s_name=="n_id")[0], 
            true,
            true
        ),
    ]
);
a_o_model.push(o_model__o_person_o_chatroom_o_message);

export {a_o_model}

