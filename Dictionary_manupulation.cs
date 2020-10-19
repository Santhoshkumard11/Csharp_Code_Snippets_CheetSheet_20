//convert the form collection to key,value pair
Dictionary<string, string> form = formCollection.AllKeys.ToDictionary(k => k, v => formCollection[v]);
