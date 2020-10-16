//to get all the keys and values from the request body

var dictionary = new Dictionary<string, object>();
Request.Form.CopyTo(dictionary);
