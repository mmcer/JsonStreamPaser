# JsonStreamPaser
.Net file stream Json Paser for Big file

This library is a port of json-streaming-parser (https://github.com/squix78/json-streaming-parser).

#How to use

This is a streaming parser, which means that you feed a stream of chars into the parser and you take out from that stream whatever you are interested in. In order to do that you will create a subclass of JsonListener class and implement methods which will be notified in case of certain events in the feed occure. Available events are:

StartDocument()

Key(String key)

Value(String value)

EndArray()

EndObject()

EndDocument()

StartArray()

StartObject()


In your implementation of these methods you will have to write problem specific code to find the parts of the document that you are interested in. Please see the example to understand what that means. In the example the ExampleListener implements the event methods declared in the JsonListener interface and prints to the serial console when they are called.

#License

This code is available under the MIT license, which basically means that you can use, modify the distribute the code as long as you give credits to me (and Salsify) and add a reference back to this repository. 
