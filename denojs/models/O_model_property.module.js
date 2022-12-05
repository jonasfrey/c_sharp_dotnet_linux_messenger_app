class O_model_property{
    constructor(
        s_name,
        s_type,
        b_private = false,
        n_minimum_number = null, 
        n_maximum_number = null, 
        n_minimum_string_length = null, 
        n_maximum_string_length = null, 
        s_regex = null,
        default_value = null, 
        b_required = null, 
        b_unique = null,
        b_primary_key = false,
        o_model_property_foreign = null,
        b_cascade_on_update = false, 
        b_cascade_on_delete = false
    ){
        this.s_name = s_name
        this.s_type = s_type
        this.b_private = b_private
        this.n_minimum_number = n_minimum_number
        this.n_maximum_number = n_maximum_number
        this.n_minimum_string_length = n_minimum_string_length
        this.n_maximum_string_length = n_maximum_string_length
        this.s_regex = s_regex
        this.default_value = default_value
        this.b_required = b_required
        this.b_unique = b_unique
        this.b_primary_key = b_primary_key
        this.o_model_property_foreign = o_model_property_foreign
        this.b_cascade_on_update = b_cascade_on_update
        this.b_cascade_on_delete = b_cascade_on_delete
        
    }
}

export {O_model_property}