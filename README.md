# mxParserDemo


----------

### Summary 
Demo `.NET Core` Console App using mXParser - a popular math expression parsing library.

### Background

I was recently tasked with writing tax calculator middleware where the client could pass in one of (literally) hundreds of formulas ans other certain critical arguments such as a product, a state, sale amount, and so on, and the middleware would parse the formula and inject the needed arguments.  "A = 100, B = 0.5, and so on.

After doing a little bit of research, I found that 'mXparser' was both popular and highly rated among the `.NET` community.  

[http://mathparser.org/](http://mathparser.org/ "http://mathparser.org/")

This basic console app is a simple proof of concept using this library and a handful of formulas.  It will loop through a small list of formulas and parse the expressions.

  

