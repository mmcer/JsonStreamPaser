namespace JsonStreamPaser
{
    public abstract class JsonListener
    {
        public abstract void Whitespace(char c);

        public abstract void StartDocument();

        public abstract void Key(string key);

        public abstract void Value(string value);

        public abstract void EndArray();

        public abstract void EndObject();

        public abstract void EndDocument();

        public abstract void StartArray();

        public abstract void StartObject();
    }
}
